using System;

namespace AverageNumber
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

            bool successConvertNum1 = int.TryParse(firstNumber, out int num1);
            bool successConvertNum2 = int.TryParse(secondNumber, out int num2);
            bool successConvertNum3 = int.TryParse(thirdNumber, out int num3);
            bool successConvertNum4 = int.TryParse(fourthNumber, out int num4);

            if(successConvertNum1 && successConvertNum2 && successConvertNum3 && successConvertNum4)
            {
                int result = num1 + num2 + num3 + num4;
                int avgNumber = result / 4;
                Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is {avgNumber}");
            }
            else
            {
                Console.WriteLine("Wrong inputs, please enter valid numbers!");
            }
        }
    }
}
