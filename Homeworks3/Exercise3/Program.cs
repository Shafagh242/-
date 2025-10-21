using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, product = 1;
            do
            {
                Console.Write("Enter a number: ");
                a = Int32.Parse(Console.ReadLine());
                if (a != 0)
                {
                    product *= a;
                }
            }
            while (a != 0);
            Console.WriteLine("Answer = " + product);


            Console.ReadKey();
        }
    }
}
