using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Please enter a number: ");
            a = Int32.Parse(Console.ReadLine());

            if (a % 7 == 0)
                Console.WriteLine("\nYES!");
            else
                Console.WriteLine($"\nResult: {a * 3}");
            Console.ReadKey();
               

        }
    }
 
}
