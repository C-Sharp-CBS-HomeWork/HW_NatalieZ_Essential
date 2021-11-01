using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        struct Laptop
        {
            public string model;
            public string manufacture;
            public double price;

            public Laptop(string model, string manufact, double price)
            {
                this.model = model; this.manufacture = manufact; this.price = price; 
            }

            public string GetInfo()
            {
                return $"Model: {model}, Manufacture: {manufacture}, Price: {price}";
            }

        }

        struct Train
        {
            public string destination;
            public string number;
            public DateTime time;
        }

        Train[] trains = new Train[8];


        struct MyStruct
        {
            public string change;
        }
        class MyClass
        {
            public string change;
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Laptop laptop;
            laptop.model = "Lenovo T470s";
            laptop.manufacture = "IBM";
            laptop.price = 2350;

            lblInfo.Text += laptop.GetInfo();

            Laptop laptop1 = new Laptop("Creator Z16", "MSI", 2900);
            lblInfo1.Text += laptop1.GetInfo();

            MyClass myClass = new MyClass();
            MyStruct myStruct;
            
            myClass.change = "unchanged";
            myStruct.change = "unchanged";

            lblClass.Text += myClass.change + ", ";
            lblStruct.Text += myStruct.change + ", ";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            lblClass.Text += myClass.change;
            lblStruct.Text += myStruct.change;

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDestination.Text) || string.IsNullOrEmpty(txtTrainNum.Text))
            {
                MessageBox.Show("Fill all the fields, please.", "Empty fields");
                return;
            }
            int count = trains.Where(x => string.IsNullOrEmpty(x.destination)).Count();
            if (count == 0)
            {
                MessageBox.Show("All records are filed, not possible to add new one.");
                return;
            }
            for (int i = 0; i < trains.Length; i++)
            {
                if (string.IsNullOrEmpty(trains[i].destination))
                {
                    trains[i].destination = txtDestination.Text;
                    trains[i].number = txtTrainNum.Text;
                    trains[i].time = dtTime.Value;
                    break;
                }
            }
            trains = trains.Where(x => ( !string.IsNullOrEmpty(x.destination))).OrderBy(x => x.number).Concat(trains.Where(x => (string.IsNullOrEmpty(x.destination)))).ToArray();
            listBoxTrains.Items.Clear();
            for (int i = 0; i < trains.Length; i++)
            {
                if (!string.IsNullOrEmpty(trains[i].destination))
                {
                    listBoxTrains.Items.Insert(i, item: $"Train: {trains[i].number}, Destination: {trains[i].destination}, Time: {trains[i].time.TimeOfDay.ToString("hh\\:mm") }");
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool found = false;
            if(string.IsNullOrEmpty(txtFindNum.Text))
            {
                MessageBox.Show("Enter train number, please.", "Empty field");
                return;
            }
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].number == txtFindNum.Text)
                {
                    listBoxTrains.SelectedIndex = i;
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show($"Train number {txtFindNum.Text} is not found!");
            }
        }
    }
}
