using System;

namespace No._6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            while (check == false)
                {
                Console.WriteLine("Input : ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                if (input == 0)
                {
                    Console.WriteLine("Show all recent files.");
                }
                else if (input == 1)
                {
                    Console.WriteLine("Open new file.");

                }
                else if (input == 2)
                {
                    Console.WriteLine("Open recent file");
                }
                else if (input == 3)
                {
                    Console.WriteLine("End");
                    check = true;
                }
            }
        }
    }
}
