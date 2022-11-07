namespace EPTG_Measurer_V3
{
    partial class Measurer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measurer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPMeasurer = new System.Windows.Forms.TabPage();
            this.pBFemur = new System.Windows.Forms.PictureBox();
            this.tPNormal = new System.Windows.Forms.TabPage();
            this.pBNormal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBOkay = new System.Windows.Forms.CheckBox();
            this.cBHard = new System.Windows.Forms.CheckBox();
            this.cBEasy = new System.Windows.Forms.CheckBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBEvaluator = new System.Windows.Forms.TextBox();
            this.lblImages = new System.Windows.Forms.Label();
            this.btnImages = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.startTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GL_Monitor = new OpenTK.GLControl();
            this.Draw_Timer = new System.Windows.Forms.Timer(this.components);
            this.pnl4 = new System.Windows.Forms.Panel();
            this.btnLoadSTL = new System.Windows.Forms.Button();
            this.lblIFU = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tPMeasurer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFemur)).BeginInit();
            this.tPNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBNormal)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPMeasurer);
            this.tabControl1.Controls.Add(this.tPNormal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 644);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tPMeasurer
            // 
            this.tPMeasurer.Controls.Add(this.pBFemur);
            this.tPMeasurer.Location = new System.Drawing.Point(4, 22);
            this.tPMeasurer.Name = "tPMeasurer";
            this.tPMeasurer.Padding = new System.Windows.Forms.Padding(3);
            this.tPMeasurer.Size = new System.Drawing.Size(578, 618);
            this.tPMeasurer.TabIndex = 0;
            this.tPMeasurer.Text = "Measure";
            this.tPMeasurer.UseVisualStyleBackColor = true;
            // 
            // pBFemur
            // 
            this.pBFemur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBFemur.Location = new System.Drawing.Point(3, 3);
            this.pBFemur.Name = "pBFemur";
            this.pBFemur.Size = new System.Drawing.Size(572, 612);
            this.pBFemur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBFemur.TabIndex = 0;
            this.pBFemur.TabStop = false;
            this.pBFemur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBFemur_MouseDown);
            // 
            // tPNormal
            // 
            this.tPNormal.Controls.Add(this.pBNormal);
            this.tPNormal.Location = new System.Drawing.Point(4, 22);
            this.tPNormal.Name = "tPNormal";
            this.tPNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tPNormal.Size = new System.Drawing.Size(578, 618);
            this.tPNormal.TabIndex = 1;
            this.tPNormal.Text = "Normal Map";
            this.tPNormal.UseVisualStyleBackColor = true;
            // 
            // pBNormal
            // 
            this.pBNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBNormal.Location = new System.Drawing.Point(3, 3);
            this.pBNormal.Name = "pBNormal";
            this.pBNormal.Size = new System.Drawing.Size(572, 612);
            this.pBNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBNormal.TabIndex = 0;
            this.pBNormal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cBOkay);
            this.panel1.Controls.Add(this.cBHard);
            this.panel1.Controls.Add(this.cBEasy);
            this.panel1.Controls.Add(this.txtComments);
            this.panel1.Controls.Add(this.lblComments);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBEvaluator);
            this.panel1.Controls.Add(this.lblImages);
            this.panel1.Controls.Add(this.btnImages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1113, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 644);
            this.panel1.TabIndex = 2;
            // 
            // cBOkay
            // 
            this.cBOkay.AutoSize = true;
            this.cBOkay.Location = new System.Drawing.Point(90, 382);
            this.cBOkay.Name = "cBOkay";
            this.cBOkay.Size = new System.Drawing.Size(51, 17);
            this.cBOkay.TabIndex = 13;
            this.cBOkay.Text = "Okay";
            this.cBOkay.UseVisualStyleBackColor = true;
            this.cBOkay.Visible = false;
            this.cBOkay.CheckedChanged += new System.EventHandler(this.cBOkay_CheckedChanged);
            // 
            // cBHard
            // 
            this.cBHard.AutoSize = true;
            this.cBHard.Location = new System.Drawing.Point(171, 382);
            this.cBHard.Name = "cBHard";
            this.cBHard.Size = new System.Drawing.Size(49, 17);
            this.cBHard.TabIndex = 12;
            this.cBHard.Text = "Hard";
            this.cBHard.UseVisualStyleBackColor = true;
            this.cBHard.Visible = false;
            this.cBHard.CheckedChanged += new System.EventHandler(this.cBHard_CheckedChanged);
            // 
            // cBEasy
            // 
            this.cBEasy.AutoSize = true;
            this.cBEasy.Location = new System.Drawing.Point(9, 382);
            this.cBEasy.Name = "cBEasy";
            this.cBEasy.Size = new System.Drawing.Size(49, 17);
            this.cBEasy.TabIndex = 11;
            this.cBEasy.Text = "Easy";
            this.cBEasy.UseVisualStyleBackColor = true;
            this.cBEasy.Visible = false;
            this.cBEasy.CheckedChanged += new System.EventHandler(this.cBEasy_CheckedChanged);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 485);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(236, 156);
            this.txtComments.TabIndex = 10;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(9, 468);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Comments";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(9, 438);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ease of Identification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evaluator name";
            // 
            // tBEvaluator
            // 
            this.tBEvaluator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBEvaluator.Location = new System.Drawing.Point(6, 313);
            this.tBEvaluator.Name = "tBEvaluator";
            this.tBEvaluator.Size = new System.Drawing.Size(242, 20);
            this.tBEvaluator.TabIndex = 2;
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Location = new System.Drawing.Point(3, 278);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(111, 13);
            this.lblImages.TabIndex = 1;
            this.lblImages.Text = "Image 0 out of 0 done";
            // 
            // btnImages
            // 
            this.btnImages.BackColor = System.Drawing.SystemColors.Control;
            this.btnImages.Location = new System.Drawing.Point(3, 252);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(245, 23);
            this.btnImages.TabIndex = 0;
            this.btnImages.Text = "Import Images";
            this.btnImages.UseVisualStyleBackColor = false;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(586, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(527, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTutorialToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // startTutorialToolStripMenuItem
            // 
            this.startTutorialToolStripMenuItem.Name = "startTutorialToolStripMenuItem";
            this.startTutorialToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.startTutorialToolStripMenuItem.Text = "Start Tutorial";
            // 
            // GL_Monitor
            // 
            this.GL_Monitor.BackColor = System.Drawing.Color.Black;
            this.GL_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GL_Monitor.Location = new System.Drawing.Point(586, 87);
            this.GL_Monitor.Name = "GL_Monitor";
            this.GL_Monitor.Size = new System.Drawing.Size(527, 557);
            this.GL_Monitor.TabIndex = 5;
            this.GL_Monitor.VSync = false;
            this.GL_Monitor.Load += new System.EventHandler(this.GL_Monitor_Load);
            this.GL_Monitor.Paint += new System.Windows.Forms.PaintEventHandler(this.GL_Monitor_Paint);
            // 
            // Draw_Timer
            // 
            this.Draw_Timer.Enabled = true;
            this.Draw_Timer.Interval = 25;
            this.Draw_Timer.Tick += new System.EventHandler(this.Draw_Timer_Tick);
            // 
            // pnl4
            // 
            this.pnl4.Controls.Add(this.btnLoadSTL);
            this.pnl4.Controls.Add(this.lblIFU);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl4.Location = new System.Drawing.Point(586, 25);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(527, 62);
            this.pnl4.TabIndex = 1;
            // 
            // btnLoadSTL
            // 
            this.btnLoadSTL.Location = new System.Drawing.Point(446, 39);
            this.btnLoadSTL.Name = "btnLoadSTL";
            this.btnLoadSTL.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSTL.TabIndex = 1;
            this.btnLoadSTL.Text = "Load STL";
            this.btnLoadSTL.UseVisualStyleBackColor = true;
            this.btnLoadSTL.Click += new System.EventHandler(this.btnLoadSTL_Click);
            // 
            // lblIFU
            // 
            this.lblIFU.AutoSize = true;
            this.lblIFU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIFU.Location = new System.Drawing.Point(2, 0);
            this.lblIFU.Name = "lblIFU";
            this.lblIFU.Size = new System.Drawing.Size(157, 20);
            this.lblIFU.TabIndex = 0;
            this.lblIFU.Text = "Please choose folder";
            // 
            // Measurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1364, 644);
            this.Controls.Add(this.GL_Monitor);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Measurer";
            this.Text = "Measurer";
            this.Load += new System.EventHandler(this.Measurer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPMeasurer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBFemur)).EndInit();
            this.tPNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBNormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPMeasurer;
        private System.Windows.Forms.TabPage tPNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBEvaluator;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem startTutorialToolStripMenuItem;
        private OpenTK.GLControl GL_Monitor;
        private System.Windows.Forms.Timer DrawTimer_Tick;
        private System.Windows.Forms.Timer Draw_Timer;
        private System.Windows.Forms.CheckBox cBOkay;
        private System.Windows.Forms.CheckBox cBHard;
        private System.Windows.Forms.CheckBox cBEasy;
        private System.Windows.Forms.PictureBox pBFemur;
        private System.Windows.Forms.PictureBox pBNormal;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Label lblIFU;
        private System.Windows.Forms.Button btnLoadSTL;
    }
}

