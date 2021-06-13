using System;

namespace No._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Many Number : ");
            int Many_Number = int.Parse(Console.ReadLine());

            int[] Many_Number_Array = new int[Many_Number];

            for (int i = 0; i < Many_Number; i++)
            {
                Console.Write("Number : ");
                Many_Number_Array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Many_Number; i++)
            {
                for (int j = i + 1; j < Many_Number; j++)
                {
                    if (Many_Number_Array[j] < Many_Number_Array[i])
                    {
                        int deposit = Many_Number_Array[i];
                        Many_Number_Array[i] = Many_Number_Array[j];
                        Many_Number_Array[j] = deposit;
                    }
                }
            }
            for (int i = 0; i < Many_Number; i++)
            {
                Console.Write("Answer : ");
                Console.Write(Many_Number_Array[i]);
                Console.Write(" ");
            }
        }
    }
}
