using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter second number:");
            string secondNumber = Console.ReadLine();

            bool convertNum1 = int.TryParse(firstNumber, out int num1);
            bool convertNum2 = int.TryParse(secondNumber, out int num2);

            if(convertNum1 && convertNum2)
            {
                int swapNum1 = num2;
                int swapNum2 = num1;

                Console.WriteLine($"Before swapping num1 = {num1} num2 = {num2}, after swapping num1 = {swapNum1} num2 = {swapNum2}");
            }
            else
            {
                Console.WriteLine("Wrong inputs, please enter valid numbers!");
            }
        }
    }
}
