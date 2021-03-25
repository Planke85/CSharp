using System;

namespace BasketballScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basketball Score Calculator");

            Console.WriteLine("Please enter two point score:");
            string twoPointScore = Console.ReadLine();

            Console.WriteLine("Please enter three point score:");
            string threePointScore = Console.ReadLine();

            bool convertTwoPoint = int.TryParse(twoPointScore, out int twoPoint);
            bool convertThreePoint = int.TryParse(threePointScore, out int threePoint);

            if(convertTwoPoint && convertThreePoint)
            {

                if(twoPoint < 0)
                {
                    Console.WriteLine("Two point number must have positive value!");
                }
                else if(threePoint < 0)
                {
                    Console.WriteLine("Three point number must have positive value!");
                }
                else
                {
                    Console.WriteLine($"Total score is: {(twoPoint * 2) + (threePoint * 3)} points.");
                }

            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }
    }
}
