using BatuGL;
using Mouse_Orbit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using STL_Tools;
using OpenTK.Graphics.OpenGL;
using System.IO;
using System.Xml.Linq;
using System.Drawing.Imaging;
using static Mouse_Orbit.Orbiter;

namespace EPTG_Measurer_V3
{
    public partial class Measurer : Form
    {
        #region STLViewer Vars
        bool monitorLoaded = false;
        bool moveForm = false;
        int moveOffsetX = 0;
        int moveOffsetY = 0;
        Batu_GL.VAO_TRIANGLES modelVAO = null; // 3d model vertex array object
        private Orbiter orb;
        Vector3 minPos = new Vector3();
        Vector3 maxPos = new Vector3();
        private const float kScaleFactor = 5.0f;
        #endregion

        public Measurer()
        {
            InitializeComponent();
            Init();
            SetDpiAwareness();
        }

        private void Measurer_Load(object sender, EventArgs e)
        {
            Batu_GL.Configure(GL_Monitor, Batu_GL.Ortho_Mode.CENTER);
            process.StateChanged += Process_StateChanged;
        }
        private void Process_StateChanged(object sender, EventArgs e)
        {
            if (process.CurrentState == ProcessState.Condyles)
            {
                pBFemur.Image = images[ImageIndex].ShapeImage;
                pBNormal.Image = images[ImageIndex].NormalImage;
                LoadSTL();
                lblImages.Text = "Image " + (ImageIndex + 1) + " of " + images.Count;
                pBFemur.Refresh();
                lblIFU.Text = "Click on the apex of the medial/lateral condyles (one point each).";
                btnRestart.Visible = false;
                btnSave.Visible = false;
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            GetImages(sender);
        }

        private void btnResetView_Click(object sender, EventArgs e)
        {
            orb.firstOrbiterUpdate = true;
            orb.Reset_All();
        }

        private void pBFemur_MouseDown(object sender, MouseEventArgs e)
        {
            Femur_MouseDown(sender, e);
        }

        private void cBEasy_CheckedChanged(object sender, EventArgs e)
        {
            cBOkay.Checked = false;
            cBHard.Checked = false;
            btnSave.Visible = true;
        }

        private void cBOkay_CheckedChanged(object sender, EventArgs e)
        {
            cBHard.Checked = false;
            cBEasy.Checked = false;
            btnSave.Visible = true;
        }

        private void cBHard_CheckedChanged(object sender, EventArgs e)
        {
            cBEasy.Checked = false;
            cBOkay.Checked = false;
            btnSave.Visible = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            btnSave.Visible = false;
            try
            {
                if (cBScreenshots.Checked)
                {
                    string screenshotpath = Path.Combine(directory, "Screenshots_" + tBEvaluator.Text);
                    Rectangle bounds = this.Bounds;
                    Directory.CreateDirectory(screenshotpath);
                    using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                    {
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                            bitmap.Save(Path.Combine(screenshotpath, images[ImageIndex].Identifier + ".png"), ImageFormat.Png);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Screenshot couldn't be saved");
            }

            cBEasy.Visible = false;
            cBOkay.Visible = false;
            cBHard.Visible = false;
            points.Clear();
            var demo = demographicsGetter.GetDemographic(images[ImageIndex].Identifier);

            int hard;
            if (cBEasy.Checked)
            {
                hard = 0;
            }
            else if (cBOkay.Checked)
            {
                hard = 1;
            }
            else
            {
                hard = 2;
            }

            cBEasy.Checked = false;
            cBOkay.Checked = false;
            cBHard.Checked = false;

            string line = images[ImageIndex].Identifier + ";" + tBEvaluator.Text + ";" + angle.ToString("N2") + ";" + DateTime.Now.ToString() + ";NaN;NaN;NaN;NaN;NaN;" + Environment.NewLine;
            if (demo != null)
            {
                line = images[ImageIndex].Identifier + ";" + tBEvaluator.Text + ";" + angle.ToString("N2") + ";" + DateTime.Now.ToString() + ";" + demo.Age + ";" + demo.Gender + ";" + demo.Dysplastic + ";" + hard + ";" + txtComments.Text + ";" + Environment.NewLine;
            }
            File.AppendAllText(directory + @"\MeasurementResult.txt", line);
            ImageIndex++;

            txtComments.Text = "";
            if (ImageIndex == images.Count)
            {
                lblIFU.Text = "Done!";
                btnExit.Visible = true;
                btnSave.Visible = false;
                process.MoveNext(Command.Done);
            }
            else
            {
                process.MoveNext(Command.Confirm);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Redraw();
        }

        private void startTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tutorial not implemented");
        }
    }
}
