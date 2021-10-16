using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    abstract class AbstractHandler
    {
        protected string _name;

        public string Name { get { return _name; } }

        public AbstractHandler(string name)
        {
            _name = name;
        }

        public abstract string Open();

        public abstract string Create();

        public abstract string Change();

        public abstract string Save();
        public abstract string Delete();
    }
}
