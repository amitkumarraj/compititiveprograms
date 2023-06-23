using System;

namespace DateTimeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime utcDate = DateTime.UtcNow;
            var localTime = new DateTimeOffset(utcDate, TimeSpan.FromHours(0)).ToLocalTime().DateTime;


            Console.WriteLine("Hello World!");
        }
    }
}
