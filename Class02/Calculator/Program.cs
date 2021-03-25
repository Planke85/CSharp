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

            Console.WriteLine("Please enter Operation ( + , - , * , / , % ):");
            string operation = Console.ReadLine();

            bool successConvertNum1 = int.TryParse(firstNumber, out int num1);
            bool successConvertNum2 = int.TryParse(secondNumber, out int num2);

            if (successConvertNum1 && successConvertNum2)
            { 
                
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result {num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Result {num1} - {num2} = {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Result {num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"Result {num1} / {num2} = {num1 / num2}");
                        break;
                    case "%":
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
