using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter time number:");
            string timeNumber = Console.ReadLine();

            bool convertTimeNum = double.TryParse(timeNumber, out double timeNum);

            if (convertTimeNum && timeNum > 0)
            {
                Console.WriteLine("Please select one value:");
                Console.WriteLine("Press 1 if you convert minutes to seconds");
                Console.WriteLine("Press 2 if you convert seconds to minutes");
                string convertTime = Console.ReadLine();

                switch (convertTime)
                {
                    case "1":
                        double seconds = timeNum * 60;
                        Console.WriteLine($"Result is {seconds} seconds.");
                        break;

                    case "2":
                        double minutes = timeNum / 60;
                        Console.WriteLine($"Result is {minutes} minutes.");
                        break;
                    default:
                        Console.WriteLine("Bad convert type!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }      
        }
    }
}
