using System;
using StudentApp.Model;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new[]
            {
                new Student("Risto", "CA", "G1"),
                new Student("Adis", "CA", "G1"),
                new Student("Darko", "Design", "G6"),
                new Student("Marko", "JS-Academy", "G1"),
                new Student("Petar", "Database Academy", "G4")
            };

            Console.WriteLine("Search:");
            string input = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Name == input)
                {
                    Console.WriteLine(student.GetInfo());
                    return;
                }
            }

            Console.WriteLine("Student not found");
        }
    }
}
