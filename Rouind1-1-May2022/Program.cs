using System;
using System.Linq;

namespace Rouind1_1_May2022
{
    class Program
    {
        static void Main(string[] args)
        {

            string time1 = Console.ReadLine();
            string time2 = Console.ReadLine();
            int[] t1 = time1.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] t2 = time2.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            TimeSpan startTime = new TimeSpan(t1[0], t1[1], 0);
            TimeSpan travelTime = new TimeSpan(t2[0], t2[1], 0);
            var totalTime = startTime.Add(travelTime);
            Console.WriteLine($"{totalTime.Hours} {totalTime.Minutes}");


            //int[] startTime = time1.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            //int[] travelTime = time2.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            //int sumHour = 0, sumMin = 0;
            //if ((startTime[0] + travelTime[0]) > 23)
            //{
            //    sumHour = (startTime[0] + travelTime[0]) - 24;
            //}
            //else
            //{
            //    sumHour = (startTime[0] + travelTime[0]);
            //}

            //if ((startTime[1] + travelTime[1]) > 59)
            //{
            //    sumMin = (startTime[1] + travelTime[1]) - 60;
            //    sumHour++;
            //}
            //else
            //{
            //    sumMin = (startTime[1] + travelTime[1]);
            //}
            //Console.WriteLine($"{sumHour} {sumMin}");

            //////Approch 1
            ////DateTime currentDate = DateTime.Now;
            //var startTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, Convert.ToInt32(time1.Split(" ")[0].ToString()), Convert.ToInt32(time1.Split(" ")[1]), 0);
            //var totalTime = startTime.AddHours(Convert.ToInt32(time2.Split(string.Empty)[0].ToString())).AddMinutes(Convert.ToInt32(time2.Split(string.Empty)[1]));
            //Console.WriteLine($"{totalTime.Hour} {totalTime.Minute}");

        }
    }
}
