using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            int arrayCounter = 0;

            while (true)
            {
                Console.Write("Press Y if you want enter name: ");
                string inputName = Console.ReadLine();
                
                if(inputName == "y" || inputName == "Y")
                {
                    Array.Resize(ref names, arrayCounter + 1);
                    Console.Write("Please enter new name: ");
                    names[arrayCounter] = Console.ReadLine();
                    arrayCounter++;
                }
                else
                {
                    Console.WriteLine("Names in array:");
                    foreach(string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }

            }
        }
    }
}
