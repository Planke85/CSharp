using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  * * *");
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("  *   *");

            Console.ReadLine();
        }
    }
}
