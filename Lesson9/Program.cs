using System;

namespace Lesson9
{
    class Program
    {
        public delegate double Avarage(int a, int b, int c);
        public delegate double mathMethods(int a, int b);
        public delegate int myRandomInt();
        public delegate double AvarageOfArray(myRandomInt[] arr);

        static Random random = new Random();

        static void Main(string[] args)
        {
            #region task1
            Console.WriteLine(Environment.NewLine + "Task 1");
            int a = 10; int b = 11; int c = 5;
            Avarage avarage = delegate (int a, int b, int c) { return (double)(a + b + c) / 3; };
            double avr = avarage(a, b, c);
            Console.WriteLine($"({a} + {b} + {c}) / 3 = {Math.Round(avr,2)}");
            #endregion

            #region task2
            Console.WriteLine(Environment.NewLine + "Task 2");

            a = random.Next(-1000, 1000);
            b = random.Next(-1000, 1000);
            Console.WriteLine($"a = {a}; b =  {b} ");

            mathMethods Add = (int a, int b) => { return a + b; };
            mathMethods Sub = (int a, int b) => { return a - b; };
            mathMethods Mul = (int a, int b) => { return a * b; };
            mathMethods Div = (int a, int b) => { return b != 0 ? (double)a/b : double.NaN; };

            int selection;
            bool doOperation = true;
            while (doOperation)
            {
                Console.WriteLine("Select operation: 1 - Add; 2 - Sub; 3 - Mul, 4 - Div, 5 - New numbers, 6 - exit.");
                Console.Write("Do your choice: ");

                if (int.TryParse(Console.ReadLine(), out selection))
                {
                    if (selection == 6)
                    {
                        Console.WriteLine("Exit!"); 
                        doOperation = false; 
                    }
                    else
                    {
                        switch (selection)
                        {
                            case 1:
                                Console.WriteLine($"{a} + {b} = {Add(a, b)}");
                                break;
                            case 2:
                                Console.WriteLine($"{a} - {b} = {Sub(a, b)}");
                                break;
                            case 3:
                                Console.WriteLine($"{a} * {b} = {Mul(a, b)}");
                                break;
                            case 4:
                                Console.WriteLine($"{a} / {b} = {Math.Round(Div(a, b),2)}");
                                break;
                            case 5:
                                a = random.Next(-1000, 1000);
                                b = random.Next(-1000, 1000);
                                Console.WriteLine($"a = {a}; b =  {b} ");
                                break;
                            default:
                                Console.WriteLine("Wrong!");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

            }
            #endregion

            #region Task 3

            myRandomInt myRandomInt = () => random.Next(-100, 100);
            //myRandomInt myRandomInt = RandomIntValue;
            myRandomInt[] myRandomIntArray = new myRandomInt[5] { myRandomInt, myRandomInt, myRandomInt, myRandomInt, myRandomInt };
            AvarageOfArray avarageOfArray = (myRandomInt[] myRandomIntArray) =>
            { 
                double temp = 0;
                for (int i = 0; i < myRandomIntArray.Length; i++)
                {
                    int t = myRandomIntArray[i]();
                    Console.WriteLine(t);
                    temp += t;
                }
                Console.WriteLine($"Sum is {Math.Round(temp, 2)}");
                return (double)temp / myRandomIntArray.Length; 
            };

            double result = avarageOfArray(myRandomIntArray);
            Console.WriteLine($"(Avarage is {Math.Round(result, 2)}");
            #endregion

        }

        private static int RandomIntValue()
        { 
            return random.Next(-100, 100);
        }
    }
}
