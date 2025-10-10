using System;

namespace Homeworks2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Please enter a number: ");
            a = Int32.Parse(Console.ReadLine());

            if (a < 10 && a % 2 == 0)
            {
                Console.WriteLine("\nTRUE!");
            }

            Console.ReadKey();
        }
    }
}
