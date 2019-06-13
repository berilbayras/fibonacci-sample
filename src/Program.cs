using System;

namespace FibonacciSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number >= 0: ");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            int y = 1;

            if (inputNumber >= x)
            {
                for (int i = 0; i < inputNumber; i++)
                {
                    Console.WriteLine(x);

                    int z = x + y;

                    x = y;

                    y = z;
                }

                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
