using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Shanbe", "Yekshanbe", "Doshanbe", "Seshanbe", "Chaharshanbe", "Panjshanbe", "Jome" };

            int number;
            do
            {
                Console.Write("Enter a number: ");
                number = Int32.Parse(Console.ReadLine());
                if (number >= 1 && number <= 7)
                    Console.WriteLine(days[number - 1]);

                else
                    Console.WriteLine("END!");
                

            } while (number >= 1 && number <= 7);

            Console.ReadKey();
        }
    }
}
