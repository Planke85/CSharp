using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first number:");
            string counter1 = Console.ReadLine();

            bool convertCounter1 = int.TryParse(counter1, out int num1);

            if (convertCounter1)
            {
                for (int i = 2; i <= num1; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }


            Console.Write("Please enter second number:");
            string counter2 = Console.ReadLine();

            bool convertCounter2 = int.TryParse(counter2, out int num2);

            if (convertCounter2)
            {
                for (int i = 1; i <= num2; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }
    }
}
