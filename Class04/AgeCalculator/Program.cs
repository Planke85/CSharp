using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your date of birth in format: dd/mm/yyy !");
            string dateOfBirth = Console.ReadLine();
            if (AgeCalculator(dateOfBirth) != 0)
            {
                Console.WriteLine($"You are {AgeCalculator(dateOfBirth)} years old");
            }
        }

        static int AgeCalculator(string birthDate)
        {
            bool convertDate = DateTime.TryParse(birthDate, out DateTime dateBirth);

            if (convertDate)
            {
                int month = dateBirth.Month;
                int day = dateBirth.Day;
                int todayMonth = DateTime.Now.Month;
                int todayDay = DateTime.Now.Day;

                int age = (DateTime.Now.Year - dateBirth.Year) - 1;
                if (todayMonth > month)
                {
                    age++;
                }
                else if (todayMonth == month && todayDay > day)
                {
                    age++;
                }
                return age;
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
            return 0;

        }
    }
}
