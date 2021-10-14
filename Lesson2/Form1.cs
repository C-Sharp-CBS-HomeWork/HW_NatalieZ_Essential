using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenDocument_Click(object sender, EventArgs e)
        {
            switch (txtAccessKey.Text.ToLower())
            {
                case "pro":
                    lblInfo.Text = new ProDocumentWorker().OpenDocument();
                    break;
                case "exp":
                    lblInfo.Text = new ExpertDocumentWorker().OpenDocument();
                    break;
                default:
                    lblInfo.Text = new DocumentWorker().OpenDocument();
                    break;
            }
        }

        private void btnEditDocument_Click(object sender, EventArgs e)
        {
            switch (txtAccessKey.Text.ToLower())
            {
                case "pro":
                    lblInfo.Text = new ProDocumentWorker().EditDocument();
                    break;
                case "exp":
                    lblInfo.Text = new ExpertDocumentWorker().EditDocument();
                    break;
                default:
                    lblInfo.Text = new DocumentWorker().EditDocument();
                    break;
            }
        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            switch (txtAccessKey.Text.ToLower())
            {
                case "pro":
                    lblInfo.Text = new ProDocumentWorker().SaveDocument();
                    break;
                case "exp":
                    lblInfo.Text = new ExpertDocumentWorker().SaveDocument();
                    break;
                default:
                    lblInfo.Text = new DocumentWorker().SaveDocument();
                    break;
            }
        }
    }
}
