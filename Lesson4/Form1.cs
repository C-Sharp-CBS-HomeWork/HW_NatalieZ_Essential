using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lesson4
{
    public partial class Form1 : Form
    {
        private enum DocumentTypes
        { 
            xml = 1,
            txt = 2,
            doc = 3
        }

        private Random random = new Random();
        private AbstractHandler document;
        private Task2___Player.Player player;
        private bool playerIsActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Task2___Player.Player();
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtDocName.Text.Length == 0)
            {
                lblInformation.Text = "Enter name of document plese!";
                lblInformation.ForeColor = Color.Red;
            }
            else
            {
                int type = random.Next(1, 4);
                switch (type)
                {
                    case (int)DocumentTypes.xml:
                        document = new XMLHandler(txtDocName.Text);
                        break;
                    case (int)DocumentTypes.txt:
                        document = new TXTHandler(txtDocName.Text);
                        break;
                    case (int)DocumentTypes.doc:
                        document = new DOCHandler(txtDocName.Text);
                        break;
                }
                lblInformation.Text = document.Create();
                lblInformation.ForeColor = Color.Green;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (CheckDocumentExist(document))
            {
                lblInformation.ForeColor = Color.Green;
                lblInformation.Text = document.Open();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CheckDocumentExist(document))
            {
                lblInformation.ForeColor = Color.Green;
                lblInformation.Text = document.Delete();
                document = null;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (CheckDocumentExist(document))
            {
                lblInformation.ForeColor = Color.Green;
                lblInformation.Text = document.Change();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDocumentExist(document))
            {
                lblInformation.ForeColor = Color.Green;
                lblInformation.Text = document.Save();
            }
        }


        private bool CheckDocumentExist(AbstractHandler doc)
        {
            if (document == null)
            {
                lblInformation.Text = "Document is not created yet!";
                lblInformation.ForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblInfo.Text = player.Play();
            if (!player.Recording)
            { 
                playerIsActive = true;
                if (backgroundWorker1.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync();
                }
            
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
                for (int i = 1; i <= 1000; i++)
                {
                    if (backgroundWorker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                    if (playerIsActive)
                    {
                        // Perform a time consuming operation and report progress.
                        int perc = (i * 100) / 1000;
                        backgroundWorker.ReportProgress(perc);
                        System.Threading.Thread.Sleep(5);
                    }
                    else
                    {
                        i--;
                    }
                   }
                }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled == true)
            {
                progressBar1.Value = 0;
                lblInfo.Text = player.Stop();
            }
            else if (e.Error != null)
            {
                lblInfo.Text = "Error: " + e.Error.Message;
            }
            else
            {
                progressBar1.Value = 0;
                lblInfo.Text = player.Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!player.NotStarted && backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.ReportProgress(0);
                backgroundWorker1.CancelAsync();
          }
            playerIsActive = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            lblInfo.Text = player.Record();
            if (!player.Playing)
            { 
                 playerIsActive = true;
                if (backgroundWorker1.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            lblInfo.Text = player.Pause();
            playerIsActive = false;
        }
    }
}
