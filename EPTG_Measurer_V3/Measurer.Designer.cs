
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pBFemur = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPRidge = new System.Windows.Forms.TabPage();
            this.pBRidge = new System.Windows.Forms.PictureBox();
            this.tPTransition = new System.Windows.Forms.TabPage();
            this.pBTransition = new System.Windows.Forms.PictureBox();
            this.tPNormal = new System.Windows.Forms.TabPage();
            this.pBNormal = new System.Windows.Forms.PictureBox();
            this.btnLoadSTL = new System.Windows.Forms.Button();
            this.Draw_Timer = new System.Windows.Forms.Timer(this.components);
            this.btnImages = new System.Windows.Forms.Button();
            this.lblImages = new System.Windows.Forms.Label();
            this.tBEvaluator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.cBEasy = new System.Windows.Forms.CheckBox();
            this.cBHard = new System.Windows.Forms.CheckBox();
            this.cBOkay = new System.Windows.Forms.CheckBox();
            this.cBScreenshots = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnNotTransition = new System.Windows.Forms.Button();
            this.lblIFU = new System.Windows.Forms.Label();
            this.GL_Monitor = new OpenTK.GLControl();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFemur)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tPRidge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBRidge)).BeginInit();
            this.tPTransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBTransition)).BeginInit();
            this.tPNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBNormal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pBFemur);
            this.pnlContainer.Controls.Add(this.tabControl1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(545, 935);
            this.pnlContainer.TabIndex = 1;
            // 
            // pBFemur
            // 
            this.pBFemur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBFemur.Location = new System.Drawing.Point(0, 0);
            this.pBFemur.Name = "pBFemur";
            this.pBFemur.Size = new System.Drawing.Size(545, 518);
            this.pBFemur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBFemur.TabIndex = 0;
            this.pBFemur.TabStop = false;
            this.pBFemur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBFemur_MouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPRidge);
            this.tabControl1.Controls.Add(this.tPTransition);
            this.tabControl1.Controls.Add(this.tPNormal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 518);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 417);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tPRidge
            // 
            this.tPRidge.Controls.Add(this.pBRidge);
            this.tPRidge.Location = new System.Drawing.Point(4, 22);
            this.tPRidge.Name = "tPRidge";
            this.tPRidge.Padding = new System.Windows.Forms.Padding(3);
            this.tPRidge.Size = new System.Drawing.Size(537, 391);
            this.tPRidge.TabIndex = 0;
            this.tPRidge.Text = "Ridge";
            this.tPRidge.UseVisualStyleBackColor = true;
            // 
            // pBRidge
            // 
            this.pBRidge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBRidge.Location = new System.Drawing.Point(3, 3);
            this.pBRidge.Name = "pBRidge";
            this.pBRidge.Size = new System.Drawing.Size(531, 385);
            this.pBRidge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBRidge.TabIndex = 1;
            this.pBRidge.TabStop = false;
            // 
            // tPTransition
            // 
            this.tPTransition.Controls.Add(this.pBTransition);
            this.tPTransition.Location = new System.Drawing.Point(4, 22);
            this.tPTransition.Name = "tPTransition";
            this.tPTransition.Padding = new System.Windows.Forms.Padding(3);
            this.tPTransition.Size = new System.Drawing.Size(537, 391);
            this.tPTransition.TabIndex = 1;
            this.tPTransition.Text = "Transition";
            this.tPTransition.UseVisualStyleBackColor = true;
            // 
            // pBTransition
            // 
            this.pBTransition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBTransition.Location = new System.Drawing.Point(3, 3);
            this.pBTransition.Name = "pBTransition";
            this.pBTransition.Size = new System.Drawing.Size(531, 385);
            this.pBTransition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBTransition.TabIndex = 2;
            this.pBTransition.TabStop = false;
            // 
            // tPNormal
            // 
            this.tPNormal.Controls.Add(this.pBNormal);
            this.tPNormal.Location = new System.Drawing.Point(4, 22);
            this.tPNormal.Name = "tPNormal";
            this.tPNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tPNormal.Size = new System.Drawing.Size(537, 391);
            this.tPNormal.TabIndex = 2;
            this.tPNormal.Text = "Normal";
            this.tPNormal.UseVisualStyleBackColor = true;
            // 
            // pBNormal
            // 
            this.pBNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBNormal.Location = new System.Drawing.Point(3, 3);
            this.pBNormal.Name = "pBNormal";
            this.pBNormal.Size = new System.Drawing.Size(531, 385);
            this.pBNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBNormal.TabIndex = 0;
            this.pBNormal.TabStop = false;
            // 
            // btnLoadSTL
            // 
            this.btnLoadSTL.Location = new System.Drawing.Point(155, 181);
            this.btnLoadSTL.Name = "btnLoadSTL";
            this.btnLoadSTL.Size = new System.Drawing.Size(84, 48);
            this.btnLoadSTL.TabIndex = 1;
            this.btnLoadSTL.Text = "Reset View";
            this.btnLoadSTL.UseVisualStyleBackColor = true;
            this.btnLoadSTL.Click += new System.EventHandler(this.btnResetView_Click);
            // 
            // Draw_Timer
            // 
            this.Draw_Timer.Enabled = true;
            this.Draw_Timer.Interval = 25;
            this.Draw_Timer.Tick += new System.EventHandler(this.Draw_Timer_Tick);
            // 
            // btnImages
            // 
            this.btnImages.BackColor = System.Drawing.SystemColors.Control;
            this.btnImages.Location = new System.Drawing.Point(3, 235);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(245, 40);
            this.btnImages.TabIndex = 0;
            this.btnImages.Text = "Import Images";
            this.btnImages.UseVisualStyleBackColor = false;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
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
            // tBEvaluator
            // 
            this.tBEvaluator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBEvaluator.Location = new System.Drawing.Point(6, 333);
            this.tBEvaluator.Name = "tBEvaluator";
            this.tBEvaluator.Size = new System.Drawing.Size(242, 20);
            this.tBEvaluator.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evaluator name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ease of Identification";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(9, 422);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 39);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
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
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 485);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(236, 156);
            this.txtComments.TabIndex = 10;
            // 
            // cBEasy
            // 
            this.cBEasy.Location = new System.Drawing.Point(9, 372);
            this.cBEasy.Name = "cBEasy";
            this.cBEasy.Size = new System.Drawing.Size(58, 39);
            this.cBEasy.TabIndex = 11;
            this.cBEasy.Text = "Easy";
            this.cBEasy.UseVisualStyleBackColor = true;
            this.cBEasy.Visible = false;
            this.cBEasy.CheckedChanged += new System.EventHandler(this.cBEasy_CheckedChanged);
            // 
            // cBHard
            // 
            this.cBHard.Location = new System.Drawing.Point(171, 372);
            this.cBHard.Name = "cBHard";
            this.cBHard.Size = new System.Drawing.Size(58, 39);
            this.cBHard.TabIndex = 12;
            this.cBHard.Text = "Hard";
            this.cBHard.UseVisualStyleBackColor = true;
            this.cBHard.Visible = false;
            this.cBHard.CheckedChanged += new System.EventHandler(this.cBHard_CheckedChanged);
            // 
            // cBOkay
            // 
            this.cBOkay.Location = new System.Drawing.Point(90, 372);
            this.cBOkay.Name = "cBOkay";
            this.cBOkay.Size = new System.Drawing.Size(51, 39);
            this.cBOkay.TabIndex = 13;
            this.cBOkay.Text = "Okay";
            this.cBOkay.UseVisualStyleBackColor = true;
            this.cBOkay.Visible = false;
            this.cBOkay.CheckedChanged += new System.EventHandler(this.cBOkay_CheckedChanged);
            // 
            // cBScreenshots
            // 
            this.cBScreenshots.AutoSize = true;
            this.cBScreenshots.Location = new System.Drawing.Point(12, 203);
            this.cBScreenshots.Name = "cBScreenshots";
            this.cBScreenshots.Size = new System.Drawing.Size(113, 17);
            this.cBScreenshots.TabIndex = 14;
            this.cBScreenshots.Text = "Take Screenshots";
            this.cBScreenshots.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.btnSkip);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.btnNotTransition);
            this.panel1.Controls.Add(this.btnLoadSTL);
            this.panel1.Controls.Add(this.lblIFU);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1498, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 935);
            this.panel1.TabIndex = 2;
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(93, 156);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(75, 23);
            this.btnSee.TabIndex = 19;
            this.btnSee.Text = "Identifier";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Visible = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(12, 156);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 18;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Visible = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(120, 278);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(126, 49);
            this.btnContinue.TabIndex = 17;
            this.btnContinue.Text = "Continue Measurements";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnNotTransition
            // 
            this.btnNotTransition.Location = new System.Drawing.Point(9, 89);
            this.btnNotTransition.Name = "btnNotTransition";
            this.btnNotTransition.Size = new System.Drawing.Size(230, 61);
            this.btnNotTransition.TabIndex = 16;
            this.btnNotTransition.Text = "No Tranistion Point";
            this.btnNotTransition.UseVisualStyleBackColor = true;
            this.btnNotTransition.Visible = false;
            this.btnNotTransition.Click += new System.EventHandler(this.btnNotTransition_Click);
            // 
            // lblIFU
            // 
            this.lblIFU.AutoSize = true;
            this.lblIFU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIFU.Location = new System.Drawing.Point(8, 15);
            this.lblIFU.Name = "lblIFU";
            this.lblIFU.Size = new System.Drawing.Size(157, 20);
            this.lblIFU.TabIndex = 15;
            this.lblIFU.Text = "Please choose folder";
            // 
            // GL_Monitor
            // 
            this.GL_Monitor.AutoSize = true;
            this.GL_Monitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GL_Monitor.BackColor = System.Drawing.Color.Black;
            this.GL_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GL_Monitor.Location = new System.Drawing.Point(545, 0);
            this.GL_Monitor.Name = "GL_Monitor";
            this.GL_Monitor.Size = new System.Drawing.Size(953, 935);
            this.GL_Monitor.TabIndex = 5;
            this.GL_Monitor.VSync = false;
            this.GL_Monitor.Load += new System.EventHandler(this.GL_Monitor_Load);
            this.GL_Monitor.Paint += new System.Windows.Forms.PaintEventHandler(this.GL_Monitor_Paint);
            // 
            // Measurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1749, 935);
            this.Controls.Add(this.GL_Monitor);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Measurer";
            this.Text = "Measurer";
            this.Load += new System.EventHandler(this.Measurer_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBFemur)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tPRidge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBRidge)).EndInit();
            this.tPTransition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBTransition)).EndInit();
            this.tPNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBNormal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer DrawTimer_Tick;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pBFemur;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPRidge;
        private System.Windows.Forms.PictureBox pBRidge;
        private System.Windows.Forms.TabPage tPTransition;
        private System.Windows.Forms.PictureBox pBTransition;
        private System.Windows.Forms.TabPage tPNormal;
        private System.Windows.Forms.PictureBox pBNormal;
        private System.Windows.Forms.Button btnLoadSTL;
        private System.Windows.Forms.Timer Draw_Timer;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.TextBox tBEvaluator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox cBEasy;
        private System.Windows.Forms.CheckBox cBHard;
        private System.Windows.Forms.CheckBox cBOkay;
        private System.Windows.Forms.CheckBox cBScreenshots;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIFU;
        private OpenTK.GLControl GL_Monitor;
        private System.Windows.Forms.Button btnNotTransition;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSee;
    }
}

