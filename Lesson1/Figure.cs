using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Figure
    {
        private Point[] _points;
        private string _name;

        /// <summary>
        /// 
        /// <exception cref="ArgumentException">Thrown when in parameters less than 3 or more than 5 points</exception>
        /// </summary>
        /// <param name="points">Array of Points of Figure</param>
        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException();
            }
            else
            {
                _points = points;
                switch (points.Length.ToString())
                {
                    case "3":
                        _name = "Triangle";
                        break;
                    case "4":
                        _name = "Quadrangle";
                        break;
                    case "5":
                        _name = "Pentagon";
                        break;
                }
            }
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X),2) + Math.Pow((A.Y - B.Y), 2));
        }

        public double PerimeterCalculator()
        {
            double result = 0;
            for (int i = 0; i < _points.Length; i++)
            {
                int j = i+1 == _points.Length?0:(i + 1);

                result += LengthSide(_points[i], _points[j]);
            }
            return Math.Round(result, 2);
        }

        public override string ToString()
        {
            return $"Figure: {_name}, Priemeter: {PerimeterCalculator()}";
        }

        public string GetPointsInfo()
        {
            string result = "Points:";

            for (int i = 0; i < _points.Length; i++)
            {
                result += $" {_points[i].Name}({_points[i].X},{_points[i].Y})";
            }
            return result;
        }
    }
}
