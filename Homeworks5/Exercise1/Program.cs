using System;

namespace Exercise1
{
    class Program
    {
        public static void Mohit(double a, double b, double c)
        {
            double m = a + b + c;
            Console.WriteLine("Mohit = " + m);
        }
        public static double Masahat(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 sides of triangle:");
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("\n********************");
            Mohit(a, b, c);
            Console.WriteLine("Masahat = " + Masahat(a, b, c));

            Console.ReadKey();
        }
    }
}
