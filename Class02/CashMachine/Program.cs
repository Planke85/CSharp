using System;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cash Machine");

            int bankCash = 150;

            Console.WriteLine("How much money you want to reise?");
            string cashInput = Console.ReadLine();

            bool convertCashInput = int.TryParse(cashInput, out int cash);

            if (convertCashInput)
            {

                if(cash < 1)
                {
                    Console.WriteLine("Cash value must be greater than zero!");
                }
                else
                {

                    if(bankCash >= cash)
                    {
                        int resultCash = bankCash - cash;
                        Console.WriteLine($"On your account you have {resultCash}$");
                    }
                    else
                    {
                        Console.WriteLine("You don't have that much money, try with a smaller amount!");
                    }

                }

            }
            else
            {
                Console.WriteLine("Wrong input, please try again!");
            }
        }
    }
}
