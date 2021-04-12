using System;
using DogApp.Model;

namespace DogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter dog name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter race");
            string race = Console.ReadLine();
            Console.WriteLine("Please enter color");
            string color = Console.ReadLine();

            Dog dog = new Dog(name, race, color);

            Console.WriteLine("Please enter a number between 1-3");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(dog.Eat());
                    break;
                case "2":
                    Console.WriteLine(dog.Play());
                    break;
                case "3":
                    Console.WriteLine(dog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }

            Dog dog2 = new Dog();
            Console.WriteLine("Please enter dog name");
            dog2.Name = Console.ReadLine();
            Console.WriteLine("Please enter race");
            dog2.Race = Console.ReadLine();
            Console.WriteLine("Please enter color");
            dog2.Color = Console.ReadLine();

            Console.WriteLine("Please enter a number between 1-3");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(dog.Eat());
                    break;
                case "2":
                    Console.WriteLine(dog.Play());
                    break;
                case "3":
                    Console.WriteLine(dog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
    }
}
