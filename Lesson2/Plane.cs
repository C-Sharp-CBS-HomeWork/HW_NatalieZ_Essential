using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Plane : Vehicle
    {
        private int _hight, _passangers;

        public int Hight
         {
            get { return _hight; }
        }

        public int Passangers
        {
            get { return _passangers; }
        }

        public Plane() : base()
        {

        }

        public Plane(int price, int speed, int year, int hight, int passangers) : base(price, speed, year)
        {
            _passangers = passangers; _hight = hight;
        }

        public override string ToString()
        {
            return $"Plain: speed: {Speed}, hight: {Hight}, passangers: {Passangers}, year: {Year}, price: {Price} ";
        }
    }
}
