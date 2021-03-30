using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number:");
            string number = Console.ReadLine();

            bool convertNumber = int.TryParse(number, out int num);

            if (!convertNumber)
            {
                Console.WriteLine("Wrong input, try again!");
                return;
            }

            int counter = 0;
            int i = 1;

            while (i <= num && counter < 100)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }

                i++;
            }

            if (counter == 100)
            {
                Console.WriteLine("The limit is reached and stop counting");
            }

        }
    }
}
