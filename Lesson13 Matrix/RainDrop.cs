using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13_Matrix
{
    public class RainDrop
    {
        //private char[] drops;
        private Random random = new Random();
        private int _length;
        private int _x;
        private int _maxY;
        private bool firstRun = true;
        private const int speed = 700;
        private int _delay;
        private char _char = '0';

        enum DropType 
        { 
            First = 0,
            Second,
            Other,
            Clear
        }

        //public char[] Drops { get => drops; set => drops = value; }
        public int Length { get => _length; }
        public int X { get => _x; }
        public int MaxY { get => _maxY; }
        public int Delay { get => _delay; }

        public RainDrop(int x, int length)
        {
            _length = length;
            _x = x;
            _maxY = Console.WindowHeight;
        }
        public RainDrop(int x, int length, int maxY)
        {
            _length = length;
            _x = x;
            _maxY = maxY;
        }
        public RainDrop(int x, int length, int maxY, int delay)
        {
            _length = length < 3 ? 3 : length;
            _x = x;
            _maxY = maxY;
            _delay = delay;
        }
        public RainDrop(int x, int length, int maxY, int delay, char symb)
        {
            _length = length < 3 ? 3 : length;
            _x = x;
            _maxY = maxY;
            _delay = delay;
            _char = symb;
        }

        public void Draw(int y)
        {
            
            if (y == MaxY-1)
            {
                firstRun = false;
            }
            Clearlast(y - Length);
            DrawFirst(y);
            DrawSecond(y-1);
            for (int i = 2; i < Length; i++)
            {
                DrawOther(y-i);
            }
            System.Threading.Thread.Sleep(speed);

        }

        public void Slide()
        {
            int y = 0;
            System.Threading.Thread.Sleep(Delay);
            object locker = new object();
            lock (locker)
            {
                while (true)
                {
                    if (y == MaxY)
                    {
                        y = 0;
                    }
                    Draw(y++);
                }
            }
        }

        private void DrawFirst(int y)
        {
            DrawOne(y, DropType.First);
        }

        private void DrawSecond(int y)
        {
            DrawOne(y, DropType.Second);
        }

        private void DrawOther(int y)
        {
            DrawOne(y, DropType.Other);
        }

        private void Clearlast(int y)
        {
            DrawOne(y, DropType.Clear);
        }

        private void DrawOne(int y, DropType dropType)
        {
            object locker = new object();
            char c = ' ';
                if (y < 0)
                {
                    if (firstRun)
                    {
                        return;
                    }
                    else
                    {
                        y += MaxY;
                    }
                }
            
                if (dropType == DropType.First)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (dropType == DropType.Second)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

               if (dropType == DropType.Clear)
                {
                    c = ' ';
                }
                else
                {
                    //Console.Write(GetChar());
                    c = _char;
                }
                Console.SetCursorPosition(X, y);
                Console.Write(c);

        }

        private char GetChar()
        {
            if (random.Next(10) % 10 == 0)
            {
                return (char)random.Next(48, 57);
            }
            else
            {
                return (char)random.Next(65, 90);
            }
        }
    }
}
