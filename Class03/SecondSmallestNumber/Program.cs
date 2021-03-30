using System;

namespace SecondSmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[0];
            int counter = 0;

            while (true)
            {
                Console.Write("Press Y if you want enter number: ");
                string input = Console.ReadLine();

                if (input == "y" || input == "Y")
                {
                    Array.Resize(ref numbers, counter + 1);
                    Console.Write("Please enter new number: ");

                    string inputNumber = Console.ReadLine();

                    bool isValid = int.TryParse(inputNumber, out int num);

                    if (!isValid)
                    {
                        continue;
                    }
                    else
                    {
                        numbers[counter] = num;
                        counter++;
                    }

                }
                else
                {
                    Console.WriteLine("Numbers in array:");
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number);
                    }
                    
                    int smallest = int.MaxValue;
                    int secondSmallest = int.MaxValue;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] < smallest)
                        {
                            secondSmallest = smallest;
                            smallest = numbers[i];
                        }
                        else if(numbers[i] < secondSmallest && numbers[i] != smallest)
                        {
                            secondSmallest = numbers[i];
                        }
                    }

                    if(secondSmallest == int.MaxValue)
                    {
                        Console.WriteLine("There is no second smallest number!");
                    }
                    else
                    {
                        Console.WriteLine($"The second smallest number is: {secondSmallest}");
                    }
                    break;
                }
            }
        }
    }
}
