﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Address
    {
        private string index, country, city, street, house, apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public Address()
        { 
        
        }

    }
}
