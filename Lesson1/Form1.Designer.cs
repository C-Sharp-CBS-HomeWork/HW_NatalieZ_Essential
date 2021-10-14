
namespace Lesson1
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
            this.lblFullAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSide2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numSide1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcRectangle = new System.Windows.Forms.Button();
            this.lblAreaM = new System.Windows.Forms.Label();
            this.lblAreaP = new System.Windows.Forms.Label();
            this.lblPerimeterP = new System.Windows.Forms.Label();
            this.lblPerimeterM = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSide1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFullAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task1 - Address";
            // 
            // lblFullAddress
            // 
            this.lblFullAddress.AutoSize = true;
            this.lblFullAddress.Location = new System.Drawing.Point(14, 55);
            this.lblFullAddress.Name = "lblFullAddress";
            this.lblFullAddress.Size = new System.Drawing.Size(69, 15);
            this.lblFullAddress.TabIndex = 2;
            this.lblFullAddress.Text = "Full address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(69, 28);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(25, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "      ";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(14, 28);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(49, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAreaP);
            this.groupBox2.Controls.Add(this.lblPerimeterM);
            this.groupBox2.Controls.Add(this.lblPerimeterP);
            this.groupBox2.Controls.Add(this.lblAreaM);
            this.groupBox2.Controls.Add(this.btnCalcRectangle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numSide1);
            this.groupBox2.Controls.Add(this.numSide2);
            this.groupBox2.Location = new System.Drawing.Point(7, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tas1 - Rectangle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Side1";
            // 
            // numSide2
            // 
            this.numSide2.DecimalPlaces = 2;
            this.numSide2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSide2.Location = new System.Drawing.Point(52, 51);
            this.numSide2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSide2.Name = "numSide2";
            this.numSide2.Size = new System.Drawing.Size(67, 23);
            this.numSide2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area (Method)";
            // 
            // numSide1
            // 
            this.numSide1.DecimalPlaces = 2;
            this.numSide1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSide1.Location = new System.Drawing.Point(52, 22);
            this.numSide1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSide1.Name = "numSide1";
            this.numSide1.Size = new System.Drawing.Size(67, 23);
            this.numSide1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Area (property)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Perimeter (Method)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Perimeter (Property)";
            // 
            // btnCalcRectangle
            // 
            this.btnCalcRectangle.Location = new System.Drawing.Point(130, 22);
            this.btnCalcRectangle.Name = "btnCalcRectangle";
            this.btnCalcRectangle.Size = new System.Drawing.Size(79, 51);
            this.btnCalcRectangle.TabIndex = 3;
            this.btnCalcRectangle.Text = "Calculate";
            this.btnCalcRectangle.UseVisualStyleBackColor = true;
            this.btnCalcRectangle.Click += new System.EventHandler(this.btnCalcRectangle_Click);
            // 
            // lblAreaM
            // 
            this.lblAreaM.AutoSize = true;
            this.lblAreaM.Location = new System.Drawing.Point(311, 24);
            this.lblAreaM.Name = "lblAreaM";
            this.lblAreaM.Size = new System.Drawing.Size(10, 15);
            this.lblAreaM.TabIndex = 4;
            this.lblAreaM.Text = " ";
            // 
            // lblAreaP
            // 
            this.lblAreaP.AutoSize = true;
            this.lblAreaP.Location = new System.Drawing.Point(311, 53);
            this.lblAreaP.Name = "lblAreaP";
            this.lblAreaP.Size = new System.Drawing.Size(10, 15);
            this.lblAreaP.TabIndex = 4;
            this.lblAreaP.Text = " ";
            // 
            // lblPerimeterP
            // 
            this.lblPerimeterP.AutoSize = true;
            this.lblPerimeterP.Location = new System.Drawing.Point(591, 51);
            this.lblPerimeterP.Name = "lblPerimeterP";
            this.lblPerimeterP.Size = new System.Drawing.Size(10, 15);
            this.lblPerimeterP.TabIndex = 4;
            this.lblPerimeterP.Text = " ";
            // 
            // lblPerimeterM
            // 
            this.lblPerimeterM.AutoSize = true;
            this.lblPerimeterM.Location = new System.Drawing.Point(591, 24);
            this.lblPerimeterM.Name = "lblPerimeterM";
            this.lblPerimeterM.Size = new System.Drawing.Size(10, 15);
            this.lblPerimeterM.TabIndex = 4;
            this.lblPerimeterM.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSide1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lblFullAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSide2;
        private System.Windows.Forms.Label lblAreaP;
        private System.Windows.Forms.Label lblPerimeterM;
        private System.Windows.Forms.Label lblPerimeterP;
        private System.Windows.Forms.Label lblAreaM;
        private System.Windows.Forms.Button btnCalcRectangle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSide1;
    }
}

