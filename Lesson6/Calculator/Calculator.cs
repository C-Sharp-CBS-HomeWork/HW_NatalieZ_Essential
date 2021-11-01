using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Calculator
{
    public static class Calculator
    {
        static public double Add(double a, double b)
        {
            return a + b;
        }

        static public double Sub(double a, double b)
        {
            return a - b;
        }

        static public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException("Argument 'b' must not be equal to 0");
            }
            return a / b;
        }

        static public double Mult(double a, double b)
        {
            return a * b;
        }

    }
}
