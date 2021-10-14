using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Ship : Vehicle
    {
        private int _passangers;
        private string _port;

        public string Port
        {
            get { return _port; }
        }

        public int Passangers
        {
            get { return _passangers; }
        }

        public Ship() : base()
        {

        }

        public Ship(int price, int speed, int year, int passangers, string port) : base(price, speed, year)
        {
            _passangers = passangers; _port = port;
        }

        public override string ToString()
        {
            return $"Ship: speed: {Speed}, port: {Port}, passangers: {Passangers}, year: {Year}, price: {Price} ";
        }
    }
}
