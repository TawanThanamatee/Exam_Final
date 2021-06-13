using System;

namespace No._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float Max = 0;
            float Min = 0;
            float Mean = 0;
            float Number = 0;
            string Input;
            string Find;

            Input = Console.ReadLine();
            if (Input != "End")
            {
                Max = float.Parse(Input);
                Min = float.Parse(Input);
                Mean += float.Parse(Input);
            }
            while (Input != "End")
            {
                Input = Console.ReadLine();
                if (Input != "End")
                {
                    if (float.Parse(Input) > Max)
                    {
                        Max = float.Parse(Input);
                    }
                    if (float.Parse(Input) < Min)
                    {
                        Min = float.Parse(Input);
                    }
                    Mean += float.Parse(Input);
                    Number++;
                }
            }
            Find = Console.ReadLine();
            while (Find != "FindMax " || Find != " FindMin " || Find != "FindMean")
            {
                if (Find == "FindMax")
                {
                    Console.Write(Max);
                }
                else
                if (Find == "FindMin")
                {
                    Console.Write(Min);
                }
                else
                if (Find == "FindMean")
                {
                    Console.Write(Mean / Number);
                }
                else
                {
                    Console.Write("Invalid mode");
                }
                Console.ReadLine();
            }
        }
    }
}
