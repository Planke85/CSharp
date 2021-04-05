using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            string someText = "Hello from SEDC Codecademy 2021";

            Console.WriteLine($"Enter a number between 0 and {someText.Length}");
            string inputNumber = Console.ReadLine();

            bool convertNumber = int.TryParse(inputNumber, out int num);

            if (convertNumber && num < someText.Length && num > 0)
            {
                Console.WriteLine(Substrings(someText, num));
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }


            static string Substrings(string text, int number)
            {
                char[] array = text.ToCharArray();
                char[] newArray = new char[number];
                for (int i = 0; i < number; i++)
                {
                    newArray[i] = array[i];
                }
                string newStringArray = new string(newArray);
                return newStringArray;
            }
        } 
    }
}

