using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter second number:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Please enter third number:");
            string thirdNumber = Console.ReadLine();

            Console.WriteLine("Please enter fourth number:");
            string fourthNumber = Console.ReadLine();

            bool convertNum1 = int.TryParse(firstNumber, out int num1);
            bool convertNum2 = int.TryParse(secondNumber, out int num2);
            bool convertNum3 = int.TryParse(thirdNumber, out int num3);
            bool convertNum4 = int.TryParse(fourthNumber, out int num4);

            if(convertNum1 && convertNum2 && convertNum3 && convertNum4)
            {

                if(num1 >= num2 && num1 >= num3 && num1 >= num4)
                {
                    Console.WriteLine($"The largest of {num1}, {num2}, {num3} and {num4} is: {num1}");
                }
                else if(num2 >= num1 && num2 >= num3 && num2 >= num4)
                {
                    Console.WriteLine($"The largest of {num1}, {num2}, {num3} and {num4} is: {num2}");
                }
                else if (num3 >= num1 && num3 >= num2 && num3 >= num4)
                {
                    Console.WriteLine($"The largest of {num1}, {num2}, {num3} and {num4} is: {num3}");
                }
                else
                {
                    Console.WriteLine($"The largest of {num1}, {num2}, {num3} and {num4} is: {num4}");
                }

            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }

        }
    }
}
