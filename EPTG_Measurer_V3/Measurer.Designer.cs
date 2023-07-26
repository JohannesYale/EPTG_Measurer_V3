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
            this.pBFemur = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBScreenshots = new System.Windows.Forms.CheckBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tPMaxCurv = new System.Windows.Forms.TabPage();
            this.pBMaxCurv = new System.Windows.Forms.PictureBox();
            this.pBMinCurv = new System.Windows.Forms.PictureBox();
            this.tpMinCurv = new System.Windows.Forms.TabPage();
            this.tBISupport = new System.Windows.Forms.TabControl();
            this.tPNormal = new System.Windows.Forms.TabPage();
            this.pBNormal = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBFemur)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tPMaxCurv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMaxCurv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMinCurv)).BeginInit();
            this.tpMinCurv.SuspendLayout();
            this.tBISupport.SuspendLayout();
            this.tPNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBNormal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBFemur
            // 
            this.pBFemur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBFemur.Location = new System.Drawing.Point(0, 0);
            this.pBFemur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBFemur.Name = "pBFemur";
            this.pBFemur.Size = new System.Drawing.Size(643, 536);
            this.pBFemur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBFemur.TabIndex = 0;
            this.pBFemur.TabStop = false;
            this.pBFemur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBFemur_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cBScreenshots);
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
            this.panel1.Location = new System.Drawing.Point(1502, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1172);
            this.panel1.TabIndex = 2;
            // 
            // cBScreenshots
            // 
            this.cBScreenshots.AutoSize = true;
            this.cBScreenshots.Location = new System.Drawing.Point(16, 250);
            this.cBScreenshots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBScreenshots.Name = "cBScreenshots";
            this.cBScreenshots.Size = new System.Drawing.Size(139, 20);
            this.cBScreenshots.TabIndex = 14;
            this.cBScreenshots.Text = "Take Screenshots";
            this.cBScreenshots.UseVisualStyleBackColor = true;
            // 
            // cBOkay
            // 
            this.cBOkay.Location = new System.Drawing.Point(120, 458);
            this.cBOkay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBOkay.Name = "cBOkay";
            this.cBOkay.Size = new System.Drawing.Size(68, 48);
            this.cBOkay.TabIndex = 13;
            this.cBOkay.Text = "Okay";
            this.cBOkay.UseVisualStyleBackColor = true;
            this.cBOkay.Visible = false;
            this.cBOkay.CheckedChanged += new System.EventHandler(this.cBOkay_CheckedChanged);
            // 
            // cBHard
            // 
            this.cBHard.Location = new System.Drawing.Point(228, 455);
            this.cBHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBHard.Name = "cBHard";
            this.cBHard.Size = new System.Drawing.Size(65, 50);
            this.cBHard.TabIndex = 12;
            this.cBHard.Text = "Hard";
            this.cBHard.UseVisualStyleBackColor = true;
            this.cBHard.Visible = false;
            this.cBHard.CheckedChanged += new System.EventHandler(this.cBHard_CheckedChanged);
            // 
            // cBEasy
            // 
            this.cBEasy.Location = new System.Drawing.Point(12, 466);
            this.cBEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBEasy.Name = "cBEasy";
            this.cBEasy.Size = new System.Drawing.Size(77, 31);
            this.cBEasy.TabIndex = 11;
            this.cBEasy.Text = "Easy";
            this.cBEasy.UseVisualStyleBackColor = true;
            this.cBEasy.Visible = false;
            this.cBEasy.CheckedChanged += new System.EventHandler(this.cBEasy_CheckedChanged);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(16, 597);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(313, 191);
            this.txtComments.TabIndex = 10;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(12, 576);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(71, 16);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Comments";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(228, 539);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 539);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 539);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(100, 28);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 450);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ease of Identification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evaluator name";
            // 
            // tBEvaluator
            // 
            this.tBEvaluator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBEvaluator.Location = new System.Drawing.Point(8, 385);
            this.tBEvaluator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBEvaluator.Name = "tBEvaluator";
            this.tBEvaluator.Size = new System.Drawing.Size(321, 22);
            this.tBEvaluator.TabIndex = 2;
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Location = new System.Drawing.Point(4, 342);
            this.lblImages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(134, 16);
            this.lblImages.TabIndex = 1;
            this.lblImages.Text = "Image 0 out of 0 done";
            // 
            // btnImages
            // 
            this.btnImages.BackColor = System.Drawing.SystemColors.Control;
            this.btnImages.Location = new System.Drawing.Point(4, 310);
            this.btnImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(327, 28);
            this.btnImages.TabIndex = 0;
            this.btnImages.Text = "Import Images";
            this.btnImages.UseVisualStyleBackColor = false;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2304, 39);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 36);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // startTutorialToolStripMenuItem
            // 
            this.startTutorialToolStripMenuItem.Name = "startTutorialToolStripMenuItem";
            this.startTutorialToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.startTutorialToolStripMenuItem.Text = "Start Tutorial";
            this.startTutorialToolStripMenuItem.Click += new System.EventHandler(this.startTutorialToolStripMenuItem_Click);
            // 
            // GL_Monitor
            // 
            this.GL_Monitor.BackColor = System.Drawing.Color.Black;
            this.GL_Monitor.Location = new System.Drawing.Point(650, 107);
            this.GL_Monitor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GL_Monitor.Name = "GL_Monitor";
            this.GL_Monitor.Size = new System.Drawing.Size(844, 1096);
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
            this.pnl4.Location = new System.Drawing.Point(650, 31);
            this.pnl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(844, 77);
            this.pnl4.TabIndex = 1;
            // 
            // btnLoadSTL
            // 
            this.btnLoadSTL.Location = new System.Drawing.Point(2096, 41);
            this.btnLoadSTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadSTL.Name = "btnLoadSTL";
            this.btnLoadSTL.Size = new System.Drawing.Size(100, 28);
            this.btnLoadSTL.TabIndex = 1;
            this.btnLoadSTL.Text = "Reset View";
            this.btnLoadSTL.UseVisualStyleBackColor = true;
            this.btnLoadSTL.Click += new System.EventHandler(this.btnResetView_Click);
            // 
            // lblIFU
            // 
            this.lblIFU.AutoSize = true;
            this.lblIFU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIFU.Location = new System.Drawing.Point(3, 0);
            this.lblIFU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIFU.Name = "lblIFU";
            this.lblIFU.Size = new System.Drawing.Size(194, 25);
            this.lblIFU.TabIndex = 0;
            this.lblIFU.Text = "Please choose folder";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pBFemur);
            this.panel2.Location = new System.Drawing.Point(5, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 536);
            this.panel2.TabIndex = 2;
            // 
            // tPMaxCurv
            // 
            this.tPMaxCurv.Controls.Add(this.pBMaxCurv);
            this.tPMaxCurv.Location = new System.Drawing.Point(4, 25);
            this.tPMaxCurv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPMaxCurv.Name = "tPMaxCurv";
            this.tPMaxCurv.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPMaxCurv.Size = new System.Drawing.Size(633, 611);
            this.tPMaxCurv.TabIndex = 1;
            this.tPMaxCurv.Text = "Transition";
            this.tPMaxCurv.UseVisualStyleBackColor = true;
            // 
            // pBMaxCurv
            // 
            this.pBMaxCurv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBMaxCurv.Location = new System.Drawing.Point(4, 4);
            this.pBMaxCurv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBMaxCurv.Name = "pBMaxCurv";
            this.pBMaxCurv.Size = new System.Drawing.Size(625, 603);
            this.pBMaxCurv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBMaxCurv.TabIndex = 0;
            this.pBMaxCurv.TabStop = false;
            // 
            // pBMinCurv
            // 
            this.pBMinCurv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBMinCurv.Location = new System.Drawing.Point(4, 4);
            this.pBMinCurv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBMinCurv.Name = "pBMinCurv";
            this.pBMinCurv.Size = new System.Drawing.Size(625, 603);
            this.pBMinCurv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBMinCurv.TabIndex = 0;
            this.pBMinCurv.TabStop = false;
            // 
            // tpMinCurv
            // 
            this.tpMinCurv.Controls.Add(this.pBMinCurv);
            this.tpMinCurv.Location = new System.Drawing.Point(4, 25);
            this.tpMinCurv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpMinCurv.Name = "tpMinCurv";
            this.tpMinCurv.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpMinCurv.Size = new System.Drawing.Size(633, 611);
            this.tpMinCurv.TabIndex = 0;
            this.tpMinCurv.Text = "Ridges";
            this.tpMinCurv.UseVisualStyleBackColor = true;
            // 
            // tBISupport
            // 
            this.tBISupport.Controls.Add(this.tpMinCurv);
            this.tBISupport.Controls.Add(this.tPMaxCurv);
            this.tBISupport.Controls.Add(this.tPNormal);
            this.tBISupport.Dock = System.Windows.Forms.DockStyle.Left;
            this.tBISupport.Location = new System.Drawing.Point(0, 0);
            this.tBISupport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBISupport.Name = "tBISupport";
            this.tBISupport.SelectedIndex = 0;
            this.tBISupport.Size = new System.Drawing.Size(641, 640);
            this.tBISupport.TabIndex = 0;
            this.tBISupport.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tPNormal
            // 
            this.tPNormal.Controls.Add(this.pBNormal);
            this.tPNormal.Location = new System.Drawing.Point(4, 25);
            this.tPNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPNormal.Name = "tPNormal";
            this.tPNormal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPNormal.Size = new System.Drawing.Size(633, 611);
            this.tPNormal.TabIndex = 2;
            this.tPNormal.Text = "Normal";
            this.tPNormal.UseVisualStyleBackColor = true;
            // 
            // pBNormal
            // 
            this.pBNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBNormal.Location = new System.Drawing.Point(4, 4);
            this.pBNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBNormal.Name = "pBNormal";
            this.pBNormal.Size = new System.Drawing.Size(625, 603);
            this.pBNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBNormal.TabIndex = 1;
            this.pBNormal.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tBISupport);
            this.panel3.Location = new System.Drawing.Point(5, 563);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 640);
            this.panel3.TabIndex = 6;
            // 
            // Measurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1843, 1195);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GL_Monitor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Measurer";
            this.Text = "Measurer";
            this.Load += new System.EventHandler(this.Measurer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBFemur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tPMaxCurv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBMaxCurv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMinCurv)).EndInit();
            this.tpMinCurv.ResumeLayout(false);
            this.tBISupport.ResumeLayout(false);
            this.tPNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBNormal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Label lblIFU;
        private System.Windows.Forms.Button btnLoadSTL;
        private System.Windows.Forms.CheckBox cBScreenshots;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tPMaxCurv;
        private System.Windows.Forms.PictureBox pBMinCurv;
        private System.Windows.Forms.TabPage tpMinCurv;
        private System.Windows.Forms.PictureBox pBMaxCurv;
        private System.Windows.Forms.TabControl tBISupport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tPNormal;
        private System.Windows.Forms.PictureBox pBNormal;
    }
}

