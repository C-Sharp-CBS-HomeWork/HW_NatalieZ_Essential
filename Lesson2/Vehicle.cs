using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Vehicle
    {
        private int _price, _speed, _year;

        public int Price
        {
            get { return _price; }
        }
        public int Speed
        {
            get { return _speed; }
        }
        public int Year
        {
            get { return _year; }
        }

        public Vehicle(int price, int speed, int year)
        {
            _price = price; _speed = speed; _year = year;
        }

        public Vehicle()
        {
        }
    }
}
