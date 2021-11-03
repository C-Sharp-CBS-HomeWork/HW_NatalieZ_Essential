using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class Form1 : Form
    {
        DateTime day;
        enum Colors
        { 
            Red,
            Green,
            Yellow
        }

        public enum Post
        { 
            Manager = 36,
            Developer = 40,
            QA = 50,
            Director = 30
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            day = new DateTime(DateTime.Today.Year, dtBirthday.Value.Month, dtBirthday.Value.Day);
            lblDays.Text = (day > DateTime.Today ? day - DateTime.Today : (day.AddYears(1) - DateTime.Today)).Days.ToString();
            
            cmbColors.DataSource = Enum.GetValues(typeof(Colors));
            cmbPost.DataSource = Enum.GetValues(typeof(Post));
        }

        private void dtBirthday_ValueChanged(object sender, EventArgs e)
        {
            day = new DateTime(DateTime.Today.Year, dtBirthday.Value.Month, dtBirthday.Value.Day);
            lblDays.Text = (day > DateTime.Today ? day - DateTime.Today : (day.AddYears(1) - DateTime.Today)).Days.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblResultText.Text = txtText.Text;
            lblResultText.ForeColor = Color.FromName(cmbColors.SelectedItem.ToString());
        }

        private void PrintSting(string str, int color)
        {
            lblResultText.Text = str;
            Colors selectedColor = (Colors)color;
            Color foreColor;
            switch (selectedColor)
            {
                case Colors.Green:
                    foreColor = Color.Green;
                    break;
                case Colors.Red:
                    foreColor = Color.Red;
                    break;
                case Colors.Yellow:
                    foreColor = Color.Yellow;
                    break;
                default:
                    foreColor = Color.Black;
                    break;
            }
            lblResultText.ForeColor = foreColor;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            PrintSting(txtText.Text, (int)cmbColors.SelectedItem);
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            Post post = (Post)cmbPost.SelectedItem;
            if (Accountant.AskForBonus((Post)cmbPost.SelectedItem, (int)numHours.Value))
            {
                lblBonus.Text = "YES";
                lblBonus.ForeColor = Color.Green;
            }
            else
            {
                lblBonus.Text = "NO";
                lblBonus.ForeColor = Color.Red;
            }
        }
    }
}
