using System;

namespace Round_3_02_May2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string virus = Console.ReadLine();
            int persons = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < persons; i++)
            {
                string testVirus = Console.ReadLine();
                int counter = 0;
                int count = 0;

                if(virus[counter] == testVirus[count])
                {
                    while (count < testVirus.Length)
                    {
                        if (virus[counter] == testVirus[count])
                        {
                            counter++;
                            count++;
                        }
                        else
                        {
                            counter++;
                        }

                    }
                    if(count== testVirus.Length)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NEGATIVE");
                }
                
               
            }

        }

        private static bool findReport(string virus, string persons, int index)
        {

            if (index >= 4)
            {
                return true;
            }
            if (virus[index] == persons[index])
            {
                index = index + 2;
                findReport(virus, persons, index);
            }

            return false;
        }
    }
}
