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
        Point ridge1;
        Point ridge2;
        string directory;
        double slopeNormal;
        double angle;
        DemographicsGetter demographicsGetter;

        private void GetImages(object sender)
        {
            try
            {
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
                                string header = "FileName;Evaluator;Angle;TimeStamp;Age;Gender(0=female);Dysplastic(1=dysplastic);EaseOfIdentification(0easy,2hard);Comments;" + Environment.NewLine;
                                file.Write(Encoding.UTF8.GetBytes(header),
                                    0, Encoding.UTF8.GetByteCount(header));
                            }

                        }
                        string[] filesShape = Directory.GetFiles(Path.Combine(directory, "Shape"), "*.png");
                        string[] filesNormal = Directory.GetFiles(Path.Combine(directory, "Normal"), "*.png");
                        int errors = 0;
                        foreach (string shape in filesShape)
                        {
                            string identifier = Path.GetFileName(shape).Split('_')[0];

                            try
                            {
                                string normal = filesNormal.First(x => Path.GetFileName(x).Split('_')[0] == identifier);
                                images.Add(new ImageObject(identifier, System.Drawing.Image.FromFile(shape), System.Drawing.Image.FromFile(normal)));
                            }
                            catch (Exception ex)
                            {
                                errors++;
                            }
                        }
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
                            MessageBox.Show("Demographics document not available or faulty. Ex " + ex.Message,);
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
                        Pen p = new Pen(Color.Blue);
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
                            Pen p = new Pen(Color.Red);
                            g.DrawLine(p, first, second);
                            lblIFU.Text = "Click on the medial and lateral ridge (one point each)";
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
                            Pen p = new Pen(Color.Red);
                            g.DrawLine(p, endpoint, trochlea);
                            var slope = ((double)(endpoint.Y - trochlea.Y)) / ((double)(endpoint.X - trochlea.X));
                            angle = Math.Abs(Math.Atan((slopeNormal - slope) / (1 + slope * slopeNormal)) * 180 / Math.PI);
                            lblIFU.Text = "Angle: " + angle.ToString("N2") + " degrees. Specify ease of identification and confirm.";
                            cBEasy.Visible = true;
                            cBHard.Visible = true;
                            cBOkay.Visible = true;
                            process.MoveNext(Command.Confirm);
                            points.Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Division through zero occured, please try again.");
                            Restart();
                        }
                    }
                    break;
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

    }

    internal class ImageObject
    {
        internal System.Drawing.Image ShapeImage;
        internal System.Drawing.Image NormalImage;
        internal string Identifier;
        public ImageObject(string filePath, System.Drawing.Image shapeImage, System.Drawing.Image normalImage)
        {
            Identifier = filePath;
            ShapeImage = shapeImage;
            NormalImage = normalImage;
        }
    }


}

