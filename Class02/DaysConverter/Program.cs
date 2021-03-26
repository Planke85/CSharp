using System;

namespace DaysConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of days:");
            string numberOfDays = Console.ReadLine();

            bool convertNumOfDays = int.TryParse(numberOfDays, out int daysNumber);

            if (convertNumOfDays)
            {
                int year = daysNumber / 365;
                int day = daysNumber % 365;
                int weeks = day / 7;
                day = day % 7;

                if(year == weeks && year == day)
                {
                    Console.WriteLine("You've entered a special number of days!");
                }
                else
                {
                    Console.WriteLine($"Years: {year}, Weeks: {weeks}, Days: {day}");
                }
                
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }

        }
    }
}
