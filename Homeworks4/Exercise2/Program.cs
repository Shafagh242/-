using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");

                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            bool found = false;
            int position = -1;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] == 2)
                {
                    found = true;
                    position = i + 1;

                    break;
                }
            }
            Console.WriteLine("\n");
            if (found)
                Console.WriteLine("Number 2 found at position: " + position);
            else
                Console.WriteLine("Number 2 wasn't found.");
            Console.ReadKey();
              
        }           
                    

    }
}
