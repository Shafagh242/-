using System;

namespace Exercise2
{
    class Program
    {
        static int Multiply(int a, int b)
        {
            if (b == 0)
                return 0;
            return a + Multiply(a, b - 1);
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter first number: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Int32.Parse(Console.ReadLine());
            int result = Multiply(x, y);
            Console.WriteLine("\n\nResult= " + result);

            Console.ReadKey();
        }
    }
}
