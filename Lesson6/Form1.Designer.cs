
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMelody = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tabCalc = new System.Windows.Forms.TabPage();
            this.btnMult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetNumbers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMusik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCalc.SuspendLayout();
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
            this.tabCalc.Controls.Add(this.btnMult);
            this.tabCalc.Controls.Add(this.button1);
            this.tabCalc.Controls.Add(this.btnSub);
            this.tabCalc.Controls.Add(this.btnAdd);
            this.tabCalc.Controls.Add(this.label3);
            this.tabCalc.Controls.Add(this.lblNumB);
            this.tabCalc.Controls.Add(this.lblResult);
            this.tabCalc.Controls.Add(this.label4);
            this.tabCalc.Controls.Add(this.lblNumA);
            this.tabCalc.Controls.Add(this.label2);
            this.tabCalc.Controls.Add(this.btnGetNumbers);
            this.tabCalc.Location = new System.Drawing.Point(4, 34);
            this.tabCalc.Name = "tabCalc";
            this.tabCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalc.Size = new System.Drawing.Size(798, 647);
            this.tabCalc.TabIndex = 0;
            this.tabCalc.Text = "Calculator";
            this.tabCalc.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(598, 155);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(171, 70);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "Multiply ( * )";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(405, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Devide ( / )";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(205, 155);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(173, 70);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Subtract ( - )";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(16, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 70);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add ( + )";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(405, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "B:";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumB.ForeColor = System.Drawing.Color.Green;
            this.lblNumB.Location = new System.Drawing.Point(461, 88);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(38, 45);
            this.lblNumB.TabIndex = 1;
            this.lblNumB.Text = "0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(331, 258);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(38, 45);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(205, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Result:";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumA.ForeColor = System.Drawing.Color.Green;
            this.lblNumA.Location = new System.Drawing.Point(74, 88);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(38, 45);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // btnGetNumbers
            // 
            this.btnGetNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGetNumbers.Location = new System.Drawing.Point(16, 19);
            this.btnGetNumbers.Name = "btnGetNumbers";
            this.btnGetNumbers.Size = new System.Drawing.Size(753, 66);
            this.btnGetNumbers.TabIndex = 0;
            this.btnGetNumbers.Text = "Get numbers";
            this.btnGetNumbers.UseVisualStyleBackColor = true;
            this.btnGetNumbers.Click += new System.EventHandler(this.btnGetNumbers_Click);
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
            this.tabCalc.ResumeLayout(false);
            this.tabCalc.PerformLayout();
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
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetNumbers;
    }
}

