using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        private int figureNumber = 0;
        private readonly Figure[] figures = { new Figure(new Point(-5, -5, "A"), new Point(0, 0, "B"), new Point(5, -5, "C")),
                                     new Figure(new Point(-5, -5, "A"), new Point(-4, 3, "B"), new Point(3, 2, "C"), new Point(5, -8, "D")),
                                     new Figure(new Point(-5, -5, "A"), new Point(-4, 0, "B"), new Point(0, 5, "C"), new Point(2, 2, "D"), new Point(5, -1, "E")),
                                   };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillAdressLables();
            PrintFigure(figures[figureNumber++]);

        }

        private void FillAdressLables()
        {
            Address address = new Address("1234", "Ukraine", "Kyiv", "Khreschatik", "1a", "345c");
            lblAddress.Text = address.ToString();
            lblFullAddress.Text = address.GetAddress();
        }

        private void btnCalcRectangle_Click(object sender, EventArgs e)
        {
            try
            { 
                Rectangle rectangle = new Rectangle((double)numSide1.Value, (double)numSide2.Value);
                lblAreaM.Text = rectangle.AreaCalculator().ToString();
                lblAreaP.Text = rectangle.Area.ToString();
                lblPerimeterM.Text = rectangle.PerimeterCalculator().ToString();
                lblPerimeterP.Text = rectangle.Perimeter.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Wrong value of sides. Only positive (>0) values are acceptable!");
            }
        }

        private void PrintFigure(Figure figure)
        {
            lblFigure.Text = figure.ToString();
            lblPoints.Text = figure.GetPointsInfo();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (figureNumber == figures.Length)
            {
                figureNumber = 0;
            }
            PrintFigure(figures[figureNumber++]);
        }
    }
}
