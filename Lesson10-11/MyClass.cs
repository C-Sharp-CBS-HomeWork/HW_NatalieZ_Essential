using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_11
{
    public static class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
