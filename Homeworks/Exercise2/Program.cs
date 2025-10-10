using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, Fahrenheit;
            Console.Write("Enter a number: ");
            celsius = double.Parse(Console.ReadLine());

            Fahrenheit = (celsius * 9.5) + 32;
            Console.WriteLine("The temperture in fahrenheit is " + Fahrenheit);
            Console.ReadKey();

        }
    }
}
