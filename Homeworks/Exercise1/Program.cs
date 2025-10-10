using System;

namespace Homeworks
{
    class Program
    {

        static void Main(string[] args)
        {
            double radius, Mohit, Masahat;
            Console.Write("Enter circle radius: ");
            radius = double.Parse(Console.ReadLine());

            Mohit = 2 * Math.PI * radius;
            Masahat = Math.PI * radius * radius;

            Console.WriteLine("Masahat is {0} and Mohit is {1}", Masahat, Mohit);
            Console.ReadKey();

        }
    }
}
