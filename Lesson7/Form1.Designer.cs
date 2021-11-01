
namespace Lesson7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStruct = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblInfo1);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task0 Laptop";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(11, 37);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(63, 25);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Info1: ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(11, 78);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(63, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info2: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStruct);
            this.groupBox2.Controls.Add(this.lblClass);
            this.groupBox2.Location = new System.Drawing.Point(1, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task3 ClassStruct";
            // 
            // lblStruct
            // 
            this.lblStruct.AutoSize = true;
            this.lblStruct.Location = new System.Drawing.Point(12, 77);
            this.lblStruct.Name = "lblStruct";
            this.lblStruct.Size = new System.Drawing.Size(66, 25);
            this.lblStruct.TabIndex = 0;
            this.lblStruct.Text = "Struct: ";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 37);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(61, 25);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStruct;
        private System.Windows.Forms.Label lblClass;
    }
}

