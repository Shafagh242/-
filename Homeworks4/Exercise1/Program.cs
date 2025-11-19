using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            int evenCount = 0;
            int oddCount = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            Console.WriteLine("\nNumber of even numbers: " + evenCount);
            Console.WriteLine("\nNumber of odd numbers: " + oddCount);

            Console.ReadKey();
        }
    }
}
