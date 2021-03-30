using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6]; 
            int sumEvanNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number: ");
                string inputNumber = Console.ReadLine();

                bool validParse = int.TryParse(inputNumber, out int number);

                if (!validParse)
                {
                    i--;
                    continue;
                }

                numbers[i] = number;
            }

            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumEvanNum += num;
                }
            }

            Console.WriteLine($"Sum even numbers in array is: {sumEvanNum}.");
        }
    }
}
