using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Point
    {
        private double _x, _y;
        private string _name;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }
        public string Name { get { return _name; } }

        public Point(double x, double y, string name)
        {
            _x = x; _y = y; _name = name;
        }
    }
}
