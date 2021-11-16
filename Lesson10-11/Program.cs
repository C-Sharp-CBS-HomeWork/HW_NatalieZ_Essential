using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson10_11
{   
         

    class Program
    {
        static void Main(string[] args)
        {Predicate<int> t;
            MyList<int> myList = new MyList<int>() { 1, 2, 3, 4 };
            int i =  myList.Count;

            int[] arr = new int[10] {1,2,3,4,5,3,7,8,2,10};
            int[] arr1 = new int[10];
            List<int> l = new List<int>() { 1, 2, 3, 4 };
            Dictionary<int, string> dict = new Dictionary<int, string>();
            MyList<int> l2 = new MyList<int>(arr);

            
            Console.WriteLine("List l");
            l.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List myList");
            myList.ForEach(x => Console.WriteLine(x));

            ////////////////////////
            l.CopyTo(1, arr, 5, 3);
            myList.CopyTo(1, arr1, 5, 3);

            t = Comp;
            bool flag = false;
            flag = l.Exists(x => x > 2);
            flag = l.Exists(t);
            flag = myList.Exists(x => x > 2);
            flag = myList.Exists(t);
            ///////////////

            int x = myList.Find(x=>x>6);
            Console.WriteLine($"myList.Find(x=>x>6) -> x={x}");

            MyList<int> res = l2.FindAll(x=>x>3);
            Console.WriteLine("List res");
            res.ForEach(x => Console.WriteLine(x));

            x = l2.FindIndex(x => x > 3);
            Console.WriteLine($"l2.FindIndex(x => x > 3)    x={x}");

            x = l2.FindIndex(4, x => x > 7);
            Console.WriteLine($"l2.FindIndex(4, x => x > 7)   x={x}");

            x = l2.FindIndex(1, 2, x => x > 3);
            Console.WriteLine($"l2.FindIndex(1, 2, x => x > 3);      x={x}");

            x = l2.FindLastIndex(x => x == 3);
            Console.WriteLine($"l2.FindLastIndex(x => x == 3)    x={x}");

            x = l2.FindLastIndex(4, x => x > 7);
            Console.WriteLine($"l2.FindIndex(4, x => x > 7)   x={x}");

            x = l2.FindLastIndex(1, 5, x => x == 3);
            Console.WriteLine($"l2.FindIndex(1, 5, x => x == 3);      x={x}");

            res = l2.GetRange(2,5);
            Console.WriteLine("List res");
            res.ForEach(x => Console.WriteLine(x));

            x = l2.IndexOf(5);
            Console.WriteLine($"l2.IndexOf(5));      x={x}");
            x = l2.IndexOf(5, 7);
            Console.WriteLine($"l2.IndexOf(5,7));      x={x}");
            x = l2.IndexOf(5,2,4);
            Console.WriteLine($"l2.IndexOf(5,2,4));      x={x}");

            myList.Add(10);
            Console.WriteLine("List myList");
            myList.ForEach(x => Console.WriteLine(x));

            myList.AddRange(l2);
            Console.WriteLine("List l2");
            myList.ForEach(x => Console.WriteLine(x));

            l2.AddRange(arr);
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));

            myList.Insert(1, 10);
            Console.WriteLine("List myList");
            myList.ForEach(x => Console.WriteLine(x));

            myList.InsertRange(1, l);
            Console.WriteLine("List myList");
            myList.ForEach(x => Console.WriteLine(x));

            l2.Clear();
            l2  = new MyList<int>(l);
            l2.InsertRange(3, arr);
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));


            l2.Remove(3);
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));

            l2.RemoveAt(5);
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));
            x = l2.RemoveAll(x=>x>4);
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"l2.RemoveAll(x=>x>4);      x={x}");

            l2.RemoveRange(2, 4);
            Console.WriteLine("List l2");
            l2.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("List myList");
            myList.ForEach(x => Console.WriteLine(x));
            myList.Reverse(3, 4);
            Console.WriteLine("List myList reverse");
            myList.ForEach(x => Console.WriteLine(x));
            myList.Reverse(0, myList.Count);
            Console.WriteLine("List myList reverse");
            myList.ForEach(x => Console.WriteLine(x));
            myList.Reverse();
            Console.WriteLine("List myList reverse");
            myList.ForEach(x => Console.WriteLine(x));
        }

        private static bool Comp(int x)
        {
            return x > 100;
        }
        private static int CompSort(int x, int y)
        {
            if (x == y) return 0;
            else if (x < y) return -1;
            else return 1;
        }
    }
}
