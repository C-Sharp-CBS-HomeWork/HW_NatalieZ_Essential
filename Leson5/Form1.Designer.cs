
namespace Lesson5
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numProdIndex = new System.Windows.Forms.NumericUpDown();
            this.btnFindByIndex = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFindProd = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProdStore = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupRemoveStore = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteStore = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numProducts = new System.Windows.Forms.NumericUpDown();
            this.btnCreateStore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProdIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupRemoveStore.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtProdStore);
            this.groupBox1.Controls.Add(this.txtProdName);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numProdIndex);
            this.groupBox4.Controls.Add(this.btnFindByIndex);
            this.groupBox4.Controls.Add(this.btnFind);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtFindProd);
            this.groupBox4.Location = new System.Drawing.Point(410, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find product";
            // 
            // numProdIndex
            // 
            this.numProdIndex.Location = new System.Drawing.Point(75, 74);
            this.numProdIndex.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numProdIndex.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numProdIndex.Name = "numProdIndex";
            this.numProdIndex.Size = new System.Drawing.Size(281, 31);
            this.numProdIndex.TabIndex = 5;
            // 
            // btnFindByIndex
            // 
            this.btnFindByIndex.Location = new System.Drawing.Point(205, 122);
            this.btnFindByIndex.Name = "btnFindByIndex";
            this.btnFindByIndex.Size = new System.Drawing.Size(151, 34);
            this.btnFindByIndex.TabIndex = 4;
            this.btnFindByIndex.Text = "Find by index";
            this.btnFindByIndex.UseVisualStyleBackColor = true;
            this.btnFindByIndex.Click += new System.EventHandler(this.btnFindByIndex_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 122);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(151, 34);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find by name";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // txtFindProd
            // 
            this.txtFindProd.Location = new System.Drawing.Point(75, 30);
            this.txtFindProd.Name = "txtFindProd";
            this.txtFindProd.Size = new System.Drawing.Size(281, 31);
            this.txtFindProd.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete random product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProdStore
            // 
            this.txtProdStore.Location = new System.Drawing.Point(83, 105);
            this.txtProdStore.Name = "txtProdStore";
            this.txtProdStore.Size = new System.Drawing.Size(321, 31);
            this.txtProdStore.TabIndex = 2;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(83, 29);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(321, 31);
            this.txtProdName.TabIndex = 2;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrice.Location = new System.Drawing.Point(83, 68);
            this.numPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(153, 31);
            this.numPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInformation);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(10, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // lblInformation
            // 
            this.lblInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformation.Location = new System.Drawing.Point(3, 27);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(771, 50);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtProducts);
            this.groupBox3.Location = new System.Drawing.Point(12, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 451);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All products in the store";
            // 
            // txtProducts
            // 
            this.txtProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProducts.Location = new System.Drawing.Point(3, 27);
            this.txtProducts.Multiline = true;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.ReadOnly = true;
            this.txtProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProducts.Size = new System.Drawing.Size(769, 421);
            this.txtProducts.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupRemoveStore);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(10, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(777, 224);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Store Administration";
            // 
            // groupRemoveStore
            // 
            this.groupRemoveStore.Controls.Add(this.label6);
            this.groupRemoveStore.Controls.Add(this.btnDeleteStore);
            this.groupRemoveStore.ForeColor = System.Drawing.Color.Red;
            this.groupRemoveStore.Location = new System.Drawing.Point(15, 129);
            this.groupRemoveStore.Name = "groupRemoveStore";
            this.groupRemoveStore.Size = new System.Drawing.Size(758, 80);
            this.groupRemoveStore.TabIndex = 4;
            this.groupRemoveStore.TabStop = false;
            this.groupRemoveStore.Text = "Remove store";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Click \"Delete store\" button to remove the store with all the products.";
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStore.Location = new System.Drawing.Point(565, 30);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Size = new System.Drawing.Size(168, 34);
            this.btnDeleteStore.TabIndex = 1;
            this.btnDeleteStore.Text = "Delete store";
            this.btnDeleteStore.UseVisualStyleBackColor = true;
            this.btnDeleteStore.Click += new System.EventHandler(this.btnDeleteStore_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.numProducts);
            this.groupBox6.Controls.Add(this.btnCreateStore);
            this.groupBox6.ForeColor = System.Drawing.Color.Green;
            this.groupBox6.Location = new System.Drawing.Point(15, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(759, 82);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Store creation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Create store for products. Number of products:";
            // 
            // numProducts
            // 
            this.numProducts.Location = new System.Drawing.Point(399, 35);
            this.numProducts.Name = "numProducts";
            this.numProducts.Size = new System.Drawing.Size(104, 31);
            this.numProducts.TabIndex = 0;
            this.numProducts.ValueChanged += new System.EventHandler(this.numProducts_ValueChanged);
            // 
            // btnCreateStore
            // 
            this.btnCreateStore.ForeColor = System.Drawing.Color.Black;
            this.btnCreateStore.Location = new System.Drawing.Point(518, 32);
            this.btnCreateStore.Name = "btnCreateStore";
            this.btnCreateStore.Size = new System.Drawing.Size(219, 34);
            this.btnCreateStore.TabIndex = 1;
            this.btnCreateStore.Text = "Create store";
            this.btnCreateStore.UseVisualStyleBackColor = true;
            this.btnCreateStore.Click += new System.EventHandler(this.btnCreateStore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 995);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProdIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupRemoveStore.ResumeLayout(false);
            this.groupRemoveStore.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProdStore;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFindProd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateStore;
        private System.Windows.Forms.NumericUpDown numProducts;
        private System.Windows.Forms.GroupBox groupRemoveStore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteStore;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.NumericUpDown numProdIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFindByIndex;
    }
}

