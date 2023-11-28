using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OpenTK;
using STL_Tools;

namespace EPTG_Measurer_V3
{
    public partial class Measurer
    {
        List<Point> points = new List<Point>();
        Process process = new Process();
        internal List<ImageObject> images = new List<ImageObject>();
        int ImageIndex = 0;
        Point epiCondyle1;
        Point epiCondyle2;
        Point trochlea;
        Point endpoint;
        Point transitionPoint;
        Point ridge1;
        Point ridge2;
        string directory;
        double slopeNormal;
        double angle;
        double eptp;
        double transitionscale;
        DemographicsGetter demographicsGetter;

        private enum ProcessDPIAwareness
        {
            ProcessDPIUnaware = 0,
            ProcessSystemDPIAware = 1,
            ProcessPerMonitorDPIAware = 2
        }

        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(ProcessDPIAwareness value);

        private void GetImages(object sender)
        {
            try
            {
                List<string> nonloaded = new List<string>();
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        directory = fbd.SelectedPath;
                        if (!File.Exists(directory + @"\MeasurementResult.txt"))
                        {
                            using (FileStream file = File.Create(directory + @"\MeasurementResult.txt"))
                            {
                                string header = "FileName;Evaluator;EPTG;EPTP;TransitionScale;TimeStamp;Age;Gender(0=female);Dysplastic(1=dysplastic);EaseOfIdentification(0easy,2hard);Comments;" + Environment.NewLine;
                                file.Write(Encoding.UTF8.GetBytes(header),
                                    0, Encoding.UTF8.GetByteCount(header));
                            }

                        }
                        string[] filesShape = Directory.GetFiles(Path.Combine(directory, "Shape"), "*.png");
                        string[] filesNormal = Directory.GetFiles(Path.Combine(directory, "Normal"), "*.png");
                        string[] filesRidge = Directory.GetFiles(Path.Combine(directory, "Ridge"), "*.png");
                        string[] filesTransition = Directory.GetFiles(Path.Combine(directory, "Transition"), "*.png");

                        int errors = 0;
                        foreach (string shape in filesShape)
                        {
                            string identifier = Path.GetFileName(shape).Split('_')[0];

                            try
                            {
                                string normal = filesNormal.First(x => Path.GetFileName(x).Split('_')[0] == identifier);
                                string transition = filesTransition.First(x => Path.GetFileName(x).Split('_')[0] == identifier);
                                string ridge = filesRidge.First(x => Path.GetFileName(x).Split('_')[0] == identifier);
                                if (!preExistingIdentifiers.Contains(identifier))
                                {
                                    images.Add(new ImageObject(identifier, System.Drawing.Image.FromFile(shape), System.Drawing.Image.FromFile(normal), System.Drawing.Image.FromFile(ridge), System.Drawing.Image.FromFile(transition)));
                                }
                            }
                            catch (Exception ex)
                            {
                                nonloaded.Add(identifier);
                                errors++;
                            }
                        }
                        btnContinue.Visible = false;
                        if (errors > 0)
                        {
                            MessageBox.Show(errors.ToString() + " image(s) were not loaded.");
                        }
                        try
                        {
                            demographicsGetter = new DemographicsGetter(directory + @"\Demographics.txt");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Demographics document not available or faulty. Ex " + ex.Message);
                            throw ex;
                        }
                        Random rng = new Random();
                        int n = images.Count;
                        while (n > 1)
                        {
                            n--;
                            int k = rng.Next(n + 1);
                            ImageObject value = images[k];
                            images[k] = images[n];
                            images[n] = value;
                        }
                        lblImages.Text = "Image 0 of " + images.Count;
                        ((System.Windows.Forms.Button)sender).Visible = false;
                        process.MoveNext(Command.Begin);
                    }
                    else
                    {
                        MessageBox.Show("Choosing folder not successful");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choosing folder not successful");
            }
        }

        private void Femur_MouseDown(object sender, MouseEventArgs e)
        {
            switch (process.CurrentState)
            {
                case (ProcessState.Condyles):

                    if (points.Count < 2)
                    {
                        PictureBox pB = (PictureBox)sender;
                        Graphics g = pB.CreateGraphics();
                        Brush p = new SolidBrush(Color.Blue);

                        DrawCircle(g, p, e.Location, 6);
                        points.Add(new Point(e.Location.X, e.Location.Y));
                        btnRestart.Visible = true;
                    }
                    if (points.Count == 2)
                    {
                        Graphics g = pBFemur.CreateGraphics();
                        Pen p = new Pen(Color.Blue,2);
                        g.DrawLine(p, points[0], points[1]);
                        epiCondyle1 = points[0];
                        epiCondyle2 = points[1];
                        points.Clear();

                        lblIFU.Text = "Click on the most distal/apex point of the trochlea groove";
                        process.MoveNext(Command.Confirm);
                    }
                    break;

                case (ProcessState.TrochleaGrove):
                    if (points.Count < 1)
                    {
                        PictureBox pB = (PictureBox)sender;
                        Graphics g = pB.CreateGraphics();
                        Brush p = new SolidBrush(Color.Blue);
                        DrawCircle(g, p, e.Location, 6);
                        points.Add(new Point(e.Location.X, e.Location.Y));
                    }
                    if (points.Count == 1)
                    {
                        try
                        {
                            trochlea = points[0];
                            points.Clear();
                            double k = -((double)(epiCondyle2.Y - epiCondyle1.Y)) / ((double)(epiCondyle2.X - epiCondyle1.X));
                            slopeNormal = 1 / k;
                            Point first = new Point(trochlea.X + 50, Convert.ToInt32(trochlea.Y + 1 / k * 50));
                            Point second = new Point(trochlea.X - 50, Convert.ToInt32(trochlea.Y - 1 / k * 50));
                            Graphics g = pBFemur.CreateGraphics();
                            Pen p = new Pen(Color.Red,2);
                            g.DrawLine(p, first, second);
                            lblIFU.Text = "Click on the medial and lateral ridge (one point each)";
                            tabControl1.SelectTab(0);
                            process.MoveNext(Command.Confirm);
                        }
                        catch
                        {
                            MessageBox.Show("Division through zero, please restart.");
                            Restart();
                        }
                    }
                    break;
                case (ProcessState.Endoint):

                    if (points.Count < 2)
                    {
                        PictureBox pB = (PictureBox)sender;
                        Graphics g = pB.CreateGraphics();
                        Brush p = new SolidBrush(Color.Blue);
                        DrawCircle(g, p, e.Location, 6);
                        points.Add(new Point(e.Location.X, e.Location.Y));
                    }
                    if (points.Count == 2)
                    {
                        endpoint = new Point((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2);
                        try
                        {
                            ridge1 = points[0];
                            ridge2 = points[1];
                            Graphics g = pBFemur.CreateGraphics();
                            Pen p = new Pen(Color.Green, 2);
                            g.DrawLine(p, endpoint, trochlea);
                            var slope = ((double)(endpoint.Y - trochlea.Y)) / ((double)(endpoint.X - trochlea.X));
                            angle = Math.Abs(Math.Atan((slopeNormal - slope) / (1 + slope * slopeNormal)) * 180 / Math.PI);
                            lblIFU.Text = "Angle: " + angle.ToString("N2") + " degrees.";
                            cBEasy.Visible = true;
                            cBHard.Visible = true;
                            cBOkay.Visible = true;
                            tabControl1.SelectTab(1);
                            process.MoveNext(Command.Confirm);
                            points.Clear();
                            btnNotTransition.Visible = true;
                            if (angle == double.NaN)
                            {
                                MessageBox.Show("Division through 0 occured (coincidence), please redo.");
                                Restart();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Division through zero occured, please try again.");
                            Restart();
                        }
                    }
                    break;
                case (ProcessState.TransitionPoint):

                    transitionPoint = new Point(e.Location.X, e.Location.Y);
                    try
                    {
                        PictureBox pB = (PictureBox)sender;
                        Graphics g = pB.CreateGraphics();
                        Brush b = new SolidBrush(Color.Blue);
                        DrawCircle(g, b, e.Location, 6);

                        Pen p = new Pen(Color.Green);
                        g.DrawLine(p, endpoint, transitionPoint);
                        g.DrawLine(p, trochlea, transitionPoint);
                        Vector2 transTroch = new Vector2(transitionPoint.X - trochlea.X, transitionPoint.Y - trochlea.Y);
                        Vector2 transEndPoint = new Vector2(transitionPoint.X - endpoint.X, transitionPoint.Y - endpoint.Y);
                        Vector2 trochEndpoint = new Vector2(endpoint.X - trochlea.X, endpoint.Y - trochlea.Y);
                        eptp = Math.Acos(Vector2.Dot(Vector2.Normalize(transTroch), Vector2.Normalize(transEndPoint))) * 180 / Math.PI;
                        double A = transTroch.Length;
                        double B = transEndPoint.Length;
                        double C = trochEndpoint.Length;
                        transitionscale = A * B * Math.Sin(eptp / 180 * Math.PI) / Math.Pow(A + B + C, 2) * (2 + Math.Pow(Math.Sqrt(2), 2));
                        lblIFU.Text += Environment.NewLine + "EPTP: " + eptp.ToString("N2") + "Degree." + Environment.NewLine + "Transitionscale: " + transitionscale.ToString("N2") + ".";
                        btnNotTransition.Visible = false;
                        process.MoveNext(Command.Confirm);
                    }
                    catch
                    {
                        MessageBox.Show("Division through zero occured, please try again.");
                        Restart();
                    }
                    break;
            }

        }
        private void btnNotTransition_Click(object sender, EventArgs e)
        {
            if (process.CurrentState == ProcessState.TransitionPoint)
            {
                eptp = 175;
                transitionscale = 0.05;
                lblIFU.Text += Environment.NewLine + "EPTP: " + eptp.ToString("N2") + "Degree." + Environment.NewLine + "Transitionscale: " + transitionscale.ToString("N2") + ".";
                process.MoveNext(Command.Confirm);
                btnNotTransition.Visible = false;
            }
        }
        void DrawCircle(Graphics g, Brush brush, Point center, float radius)
        {
            float centerX = center.X;
            float centerY = center.Y;

            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        private void Restart()
        {
            points.Clear();
            pBFemur.Image = images[ImageIndex].ShapeImage;
            pBNormal.Image = images[ImageIndex].NormalImage;
            lblImages.Text = "Image " + (ImageIndex + 1) + " of " + images.Count;
            pBFemur.Refresh();
            lblIFU.Text = "Click on the apex of the medial/lateral condyles (one point each).";
            btnRestart.Visible = false;
            process.CurrentState = ProcessState.Condyles;
        }

        private void Redraw()
        {
            pBFemur.Refresh();
            if (tabControl1.SelectedIndex == 0)
            {
                Graphics g = pBFemur.CreateGraphics();
                if (points.Count != 0 || process.CurrentState == ProcessState.TrochleaGrove || process.CurrentState == ProcessState.Endoint || process.CurrentState == ProcessState.Angles)
                {

                    if (ProcessState.Angles == process.CurrentState || ProcessState.Endoint == process.CurrentState || ProcessState.TrochleaGrove == process.CurrentState)
                    {
                        Brush p = new SolidBrush(Color.Blue);
                        DrawCircle(g, p, epiCondyle1, 6);
                        DrawCircle(g, p, epiCondyle2, 6);
                    }
                    if (points.Count != 0 && ProcessState.Endoint == process.CurrentState)
                    {
                        Brush p = new SolidBrush(Color.Blue);
                        DrawCircle(g, p, points[0], 6);
                    }
                }

                if (process.CurrentState == ProcessState.Endoint || process.CurrentState == ProcessState.Angles)
                {
                    Brush b = new SolidBrush(Color.Blue);
                    DrawCircle(g, b, trochlea, 6);
                    Pen p = new Pen(Color.Red);
                    double k = -((double)(epiCondyle2.Y - epiCondyle1.Y)) / ((double)(epiCondyle2.X - epiCondyle1.X));
                    slopeNormal = 1 / k;
                    Point first = new Point(trochlea.X + 50, Convert.ToInt32(trochlea.Y + 1 / k * 50));
                    Point second = new Point(trochlea.X - 50, Convert.ToInt32(trochlea.Y - 1 / k * 50));
                    g.DrawLine(p, first, second);
                    if (points.Count == 1)
                    {
                        DrawCircle(g, b, points[0], 6);
                    }
                }
                if (process.CurrentState == ProcessState.Angles)
                {
                    Pen p = new Pen(Color.Red);
                    g.DrawLine(p, endpoint, trochlea);
                    Brush b = new SolidBrush(Color.Blue);
                    DrawCircle(g, b, ridge1, 6);
                    DrawCircle(g, b, ridge2, 6);
                }

            }
        }

        private static void SetDpiAwareness()
        {
            try
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    SetProcessDpiAwareness(ProcessDPIAwareness.ProcessPerMonitorDPIAware);
                }
            }
            catch (EntryPointNotFoundException)//this exception occures if OS does not implement this API, just ignore it.
            {
            }
        }

    }

    internal class ImageObject
    {
        internal System.Drawing.Image ShapeImage;
        internal System.Drawing.Image NormalImage;
        internal System.Drawing.Image RidgeImage;
        internal System.Drawing.Image TransitionImage;

        internal string Identifier;
        public ImageObject(string filePath, System.Drawing.Image shapeImage, System.Drawing.Image normalImage, System.Drawing.Image ridgeImage, System.Drawing.Image transitionImage)
        {
            Identifier = filePath;
            ShapeImage = shapeImage;
            NormalImage = normalImage;
            RidgeImage = ridgeImage;
            TransitionImage = transitionImage;
        }
    }
}





