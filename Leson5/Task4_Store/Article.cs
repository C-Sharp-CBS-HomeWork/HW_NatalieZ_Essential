using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Task4_Store
{
    class Article
    {
        private string _name, _storeName;
        private double _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Article(string name, double price)
        {
            _name = name; _price = price;
        }
        public Article(string name, double price, string storeName)
        {
            _name = name; _price = price; _storeName = storeName;
        }

        public override string ToString()
        {
            return $"Product: name: {Name}, price: {Price}, name of store: {StoreName}";
        }
    }
}
