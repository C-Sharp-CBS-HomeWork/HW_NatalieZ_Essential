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
    }
}
