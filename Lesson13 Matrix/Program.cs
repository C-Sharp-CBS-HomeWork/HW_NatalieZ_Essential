using System;
using System.Threading;

namespace Lesson13_Matrix
{
    class Program
    {
        static Random random = new Random();
        static int width = Console.WindowWidth;
        static int height = Console.WindowHeight;
        static int length = random.Next(10);

        static void Main(string[] args)
        {
            int count = 3;
            Console.CursorVisible = false;
            //RainDrop[] rainDrops = new RainDrop[width];
            RainDrop[] rainDrops = new RainDrop[3];
            //Thread[] threads = new Thread[width];
            Thread[] threads = new Thread[3];

            //            for (int i = 10; i < 50; i=i+10)
            //            {
            //                rainDrops[i] = new RainDrop(i, random.Next(10), height, random.Next(1000, 10000) );
            //                threads[i] = new Thread(rainDrops[i].Slide);
            //                threads[i].Start();
            //;            }


            //for (int i = 0; i < count; i++)
            //{
            //    //rainDrops[i] = new RainDrop(i * 10 + 5, random.Next(10), height, random.Next(0, 10000));
            //    rainDrops[i] = new RainDrop(i * 10 + 5, random.Next(3, 10), height);
            //}
            //for (int i = 0; i < count; i++)
            //{
            //    threads[i] = new Thread(rainDrops[i].Slide);
            //}
            //for (int i = 0; i < count; i++)
            //{
            //    threads[i].Start();

            //}


            RainDrop rainDrop1 = new RainDrop(10, random.Next(3, 10), height, random.Next(1000, 10000), '0');
            Thread thread1 = new Thread(rainDrop1.Slide);

            RainDrop rainDrop2 = new RainDrop(20, random.Next(3, 10), height, random.Next(1000, 10000), '1');
            Thread thread2 = new Thread(rainDrop2.Slide);
            RainDrop rainDrop3 = new RainDrop(30, random.Next(3, 10), height, random.Next(1000, 10000), '2');
            thread1.Start();
            thread2.Start();

            rainDrop3.Slide();
        }

    }
}
