
namespace Lesson2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccessKey = new System.Windows.Forms.TextBox();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.btnSaveDocument = new System.Windows.Forms.Button();
            this.btnEditDocument = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.btnEditDocument);
            this.groupBox1.Controls.Add(this.btnSaveDocument);
            this.groupBox1.Controls.Add(this.btnOpenDocument);
            this.groupBox1.Controls.Add(this.txtAccessKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task4 - Documents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter access key: ";
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.Location = new System.Drawing.Point(184, 36);
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.Size = new System.Drawing.Size(166, 31);
            this.txtAccessKey.TabIndex = 1;
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.Location = new System.Drawing.Point(377, 30);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(171, 41);
            this.btnOpenDocument.TabIndex = 2;
            this.btnOpenDocument.Text = "Open document";
            this.btnOpenDocument.UseVisualStyleBackColor = true;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // btnSaveDocument
            // 
            this.btnSaveDocument.Location = new System.Drawing.Point(731, 30);
            this.btnSaveDocument.Name = "btnSaveDocument";
            this.btnSaveDocument.Size = new System.Drawing.Size(171, 41);
            this.btnSaveDocument.TabIndex = 2;
            this.btnSaveDocument.Text = "Save document";
            this.btnSaveDocument.UseVisualStyleBackColor = true;
            this.btnSaveDocument.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // btnEditDocument
            // 
            this.btnEditDocument.Location = new System.Drawing.Point(554, 30);
            this.btnEditDocument.Name = "btnEditDocument";
            this.btnEditDocument.Size = new System.Drawing.Size(171, 41);
            this.btnEditDocument.TabIndex = 2;
            this.btnEditDocument.Text = "Edit document";
            this.btnEditDocument.UseVisualStyleBackColor = true;
            this.btnEditDocument.Click += new System.EventHandler(this.btnEditDocument_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(33, 87);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(106, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnEditDocument;
        private System.Windows.Forms.Button btnSaveDocument;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.TextBox txtAccessKey;
        private System.Windows.Forms.Label label1;
    }
}

