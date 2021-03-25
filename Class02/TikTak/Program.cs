using System;

namespace TikTak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            string number = Console.ReadLine();

            bool convertNumber = int.TryParse(number, out int num);

            if (convertNumber)
            {

                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine($"Your number {num} is Tik-Tak");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine($"Your number {num} is Tik");
                }
                else if(num % 5 == 0)
                {
                    Console.WriteLine($"Your number {num} is Tak");
                }
                else
                {
                    Console.WriteLine("Bad Number!");
                }

            }
            else
            {
                Console.WriteLine("Wrong input, please try again!");
            }
            
        }
    }
}
