
namespace Lesson6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMusik = new System.Windows.Forms.TabPage();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMelody = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tabCalc = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabMusik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMusik);
            this.tabControl1.Controls.Add(this.tabCalc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMusik
            // 
            this.tabMusik.Controls.Add(this.lblStatus);
            this.tabMusik.Controls.Add(this.btnPrepare);
            this.tabMusik.Controls.Add(this.pictureBox1);
            this.tabMusik.Controls.Add(this.lblMelody);
            this.tabMusik.Controls.Add(this.label1);
            this.tabMusik.Controls.Add(this.btnPlay);
            this.tabMusik.Location = new System.Drawing.Point(4, 34);
            this.tabMusik.Name = "tabMusik";
            this.tabMusik.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusik.Size = new System.Drawing.Size(798, 647);
            this.tabMusik.TabIndex = 1;
            this.tabMusik.Text = "Musik Notes";
            this.tabMusik.UseVisualStyleBackColor = true;
            // 
            // btnPrepare
            // 
            this.btnPrepare.Location = new System.Drawing.Point(61, 540);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(242, 34);
            this.btnPrepare.TabIndex = 6;
            this.btnPrepare.Text = "Prepare melody";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lesson6.Properties.Resources.Belochka;
            this.pictureBox1.Location = new System.Drawing.Point(11, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 450);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblMelody
            // 
            this.lblMelody.Location = new System.Drawing.Point(87, 8);
            this.lblMelody.Name = "lblMelody";
            this.lblMelody.Size = new System.Drawing.Size(693, 68);
            this.lblMelody.TabIndex = 2;
            this.lblMelody.Text = " ";
            this.lblMelody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Melody";
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(496, 540);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(242, 34);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play melody";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tabCalc
            // 
            this.tabCalc.Location = new System.Drawing.Point(4, 34);
            this.tabCalc.Name = "tabCalc";
            this.tabCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalc.Size = new System.Drawing.Size(798, 648);
            this.tabCalc.TabIndex = 0;
            this.tabCalc.Text = "Calculator";
            this.tabCalc.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(3, 583);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(792, 59);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Prepare a melody, please. (It can take long time to create a melody, but you can " +
    "play it then plenty times.)";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMusik.ResumeLayout(false);
            this.tabMusik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCalc;
        private System.Windows.Forms.TabPage tabMusik;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblMelody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Label lblStatus;
    }
}

