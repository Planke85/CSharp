using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple console calculator");

            Console.WriteLine("Please enter first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter second number:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Please enter Operation:");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Modulus");
            string calculatorOperation = Console.ReadLine();

            bool successConvertNum1 = int.TryParse(firstNumber, out int num1);
            bool successConvertNum2 = int.TryParse(secondNumber, out int num2);
            bool successConvertOperation = int.TryParse(calculatorOperation, out int operation);

            if (successConvertNum1 && successConvertNum2 && successConvertOperation)
            { 
                
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Result {num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result {num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result {num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"Result {num1} / {num2} = {num1 / num2}");
                        break;
                    case 5:
                        Console.WriteLine($"Result {num1} % {num2} = {num1 % num2}");
                        break;
                    default:
                        Console.WriteLine("Wrong operation, please try again!");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Wrong inputs, try again!");
            }
        }
    }
}
