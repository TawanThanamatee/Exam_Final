using System;

namespace No._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Input Many City : ");
                int Many_City = int.Parse(Console.ReadLine());
                int Level = 0;
                string text;
                for (int i = 0; i < Many_City; i++)
                {
                    Level.ToString();
                    Many_City City_loop;
                    City_loop = (Many_City)i;
                    Console.WriteLine("{0} = {1}", City_loop, Level);
                }
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Input COVID-19");
                text = Console.ReadLine();
                if (text == "Outbreak")
                {
                    for (int i = 0; i < Many_City; i++)
                    {
                        Level.ToString();
                        Many_City City_loop;
                        City_loop = (Many_City)i;
                        Console.WriteLine("{0} = {1}", City_loop, Level - 2);
                    }
                }
                else if (text == "Vaccinate")
                {
                    for (int i = 0; i < Many_City; i++)
                    {
                        Level.ToString();
                        Many_City City_loop;
                        City_loop = (Many_City)i;
                        Console.WriteLine("{0} = {1}", City_loop, Level);
                    }
                }
                else if (text == "Lock down")
                {
                    for (int i = 0; i < Many_City; i++)
                    {
                        Level.ToString();
                        Many_City City_loop;
                        City_loop = (Many_City)i;
                        Console.WriteLine("{0} = {1}", City_loop, Level - 1);
                    }
                }
                else if(text == "Spread")
                {
                    for (int i = 0; i < Many_City; i++)
                    {
                        Level.ToString();
                        Many_City City_loop;
                        City_loop = (Many_City)i;
                        Console.WriteLine("{0} = {1}", City_loop, Level + 1);
                    }
                }
                else if(text == "End" || text == "end")
                {
                    check = true;
                }
                else
                    Console.WriteLine("Input try agian.");
            }
        }
        public enum Many_City
        {

            New_York,
            Los_Angeles,
            Chicago,
            Houston,
            Phoenix,
            Philadelphia,
            San_Antonio,
            San_Diego,
            Dallas,
            San_Jose,
            Detroit,
            San_Francisco
        }

    }
}
