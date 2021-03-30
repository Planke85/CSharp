using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Aleksandar", "Goran", "Vlatko", "Risto", "Adis" };

            Console.WriteLine("Please select Group / Press 1 or 2");
            string selectGroup = Console.ReadLine();

            if(selectGroup == "1")
            {
                Console.WriteLine("G1 Students: ");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if(selectGroup == "2")
            {
                Console.WriteLine("G2 Students: ");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
        }
    }
}
