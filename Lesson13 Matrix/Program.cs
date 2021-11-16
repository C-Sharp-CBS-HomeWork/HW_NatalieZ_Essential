using System;
using System.Threading;

namespace Lesson13_Matrix
{
    class Program
    {
        static Random random = new Random();
        static int width = Console.WindowWidth;
        static int height = Console.WindowHeight;

        static void Main(string[] args)
        {
            int x = 0;
            Console.CursorVisible = false;
            int delay;
            RainDrop[] rainDrops = new RainDrop[width*2];
            Thread[] threads = new Thread[width*2];

            for (int i = 0; i < width*2; i+=2)
            {
                delay = random.Next(1000, 10000);
                rainDrops[i] = new RainDrop(x, random.Next(10), height, delay);
                threads[i] = new Thread(rainDrops[i].Slide);
                threads[i].Start();
                delay += rainDrops[i].Speed * 10 + 1000;
                rainDrops[i+1] = new RainDrop(x, random.Next(10), height, delay);
                threads[i+1] = new Thread(rainDrops[i+1].Slide);
                threads[i+1].Start();
                x++;
            }
        }

    }
}
