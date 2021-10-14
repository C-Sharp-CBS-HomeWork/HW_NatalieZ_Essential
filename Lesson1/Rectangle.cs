using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Rectangle
    {
        #region Private variables
        private double _side1;
        private double _side2;

        #endregion

        #region Properties

        /// <summary>
        /// Should return firdt side of array
        /// <exception cref="ArgumentException">Thrown when value was smaller than 0</exception>
        /// </summary>
        public double Side1
        {
            get => _side1;
            set
            {
                if (value > 0)
                {
                    _side1 = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Should return second side of array
        /// <exception cref="ArgumentException">Thrown when value was smaller than 0</exception>
        /// </summary>
        public double Side2
        {
            get => _side2;
            set
            {
                if (value > 0)
                {
                    _side2 = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public double Area
        {
            get => _side1 * _side2;
        }

        public double Perimeter
        { 
            get => (_side1 + _side2)*2;
        }

        #endregion

        #region Constructors
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        #endregion

        public double AreaCalculator()
        {
            return Area;
        }

        public double PerimeterCalculator()
        {
            return Perimeter;
        }

    }
}
