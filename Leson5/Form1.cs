using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson5.Task4_Store;

namespace Lesson5
{
    public partial class Form1 : Form
    {
        private Store store;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int i = random.Next(0, store.Articles.Length);
            store.DeleteProduct(i);
            lblInformation.Text = "Product deleted!";
            txtProducts.Text = store.GetInfo();
        }

        private void btnCreateStore_Click(object sender, EventArgs e)
        {
            if (store == null)
            {
                if ((int)numProducts.Value == 0)
                {
                    lblInformation.Text = "It's not possible to create empty store. Please, enter number of products.";
                }
                else
                { 
                    store = new Store((int)numProducts.Value);
                    lblInformation.Text = $"Store is created for {numProducts.Value} products.";
                    txtProducts.Text = store.GetInfo();
                }
            }
            else
            {
                lblInformation.Text = "Store is already created. If you want to create new one, you need to delete existing store.";
            }


        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            if (store == null)
            {
                lblInformation.Text = "There is no store to delete.";
            }
            else
            {
                if (MessageBox.Show("Do you really want to delete this store?", "Store deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    store = null;
                    txtProducts.Text = string.Empty;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool priceChecked = true;
            if (txtProdName.Text.Length == 0)
            {
                lblInformation.Text = "Please enter product name!";
                return;
            }
            if (numPrice.Value == 0)
            {
                priceChecked = MessageBox.Show("Do you really want to create a product with zero price?", "Product creation", MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
            if (priceChecked)
            { 
                if (store == null)
                {
                    store = new Store(new Article(txtProdName.Text, (double)numPrice.Value, txtProdStore.Text));
                }
                else
                {
                    store.AddProduct(new Article(txtProdName.Text, (double)numPrice.Value, txtProdStore.Text));
                }
                lblInformation.Text = "Product added!";
                txtProducts.Text = store.GetInfo();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindProd.Text.Length > 0)
            {
                Article temp = store.GetArticle(txtFindProd.Text);
                if (temp == null)
                {
                    lblInformation.Text = $"There is not any product with name '{txtFindProd.Text}'.";
                }
                else
                { 
                     lblInformation.Text = temp.ToString();
                }
            }
            else
            {
                lblInformation.Text = "Please enter name of product to find!";
            }
        }

        private void btnFindByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                Article temp = store.GetArticle((int)numProdIndex.Value);
                if (temp == null)
                {
                    lblInformation.Text = "There is not product information with such index!";
                }
                else
                { 
                    lblInformation.Text = temp.ToString();
                }
            }
            catch (IndexOutOfRangeException)
            {
                lblInformation.Text = "There is not a product with such index!";
            }
        }

        private void numProducts_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
