using System;

namespace No._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Number = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Number[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Number[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
