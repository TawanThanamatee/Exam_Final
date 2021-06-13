using System;

namespace No._3
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static int Combination(int n, int r)
        {
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }

        static float Max(float a, float b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static float Max3(float a, float b, float c)
        {
            return Max(Max(a, b), c);
        }
        static float Min(float a, float b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static float Min3(float a, float b)
        {
            return Min(a, b);
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            float Num1, Num2;
            float RootNumber = 0;

            for (int i = 0; i < x; i++)
            {
                Num1 = float.Parse(Console.ReadLine());
                Num2 = float.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    RootNumber = Min3(Num1, Num2);
                }
                else
                {
                    RootNumber = Max3(Num1, Num2, RootNumber);
                }
                Console.WriteLine(RootNumber);
                Console.ReadLine();
            }
        }
    }
}
