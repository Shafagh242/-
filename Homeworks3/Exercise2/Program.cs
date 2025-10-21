using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] I = new char[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 6 || j == 2)
                        I[i, j] = '*';
                    else
                        I[i, j] = ' ';
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(I[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            char[,] H = new char[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0 || j == 4 || i == 3)
                        H[i, j] = '*';
                    else
                        H[i, j] = ' ';
                }

            }
           
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(H[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            char[,] E = new char[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 3 || i == 6 || j == 0)
                        E[i, j] = '*';
                    else
                        E[i, j] = ' ';
                }
            }

            
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(E[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
