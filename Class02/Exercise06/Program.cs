using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string inputNumber1 = Console.ReadLine();

            Console.WriteLine("Please enter second number:");
            string inputNumber2 = Console.ReadLine();

            bool successConvertNum1 = int.TryParse(inputNumber1, out int num1);
            bool successConvertNum2 = int.TryParse(inputNumber2, out int num2);

            if(successConvertNum1 && successConvertNum2)
            {

                if(num1 > num2)
                {
                    Console.WriteLine(num1 % 2 == 0 ? 
                        $"Number one ({num1}) is greater than number two ({num2}) and the number is even" : 
                        $"Number one ({num1}) is greater than number two ({num2}) and the number is odd");
                }
                else if(num2 > num1)
                {
                    Console.WriteLine(num2 % 2 == 0 ? 
                        $"Number two ({num2}) is greater than number one ({num1}) and the number is even" : 
                        $"Number two ({num2}) is greater than number one ({num1}) and the number is odd");
                }
                else
                {
                    Console.WriteLine(num1 % 2 == 0 ?
                        $"Number one ({num1}) and number two ({num2}) are the same and both are even" :
                        $"Number one ({num1}) and number two ({num2}) are the same and both are odd");
                }
                
            }
            else
            {
                Console.WriteLine("Wrong inputs, try again!");
            }

        }
    }
}
