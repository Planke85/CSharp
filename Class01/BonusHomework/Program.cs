using System;

namespace BonusHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     *   ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    ***   ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   *****   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  *******   ");
            Console.Beep(500, 500);

            Console.WriteLine("---------------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   *   ");
            Console.WriteLine("   *   ");
            Console.WriteLine("  ***   ");
            Console.WriteLine(" * * *   ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   *   ");
            Console.WriteLine("   *   ");
            Console.WriteLine("  * *   ");
            Console.WriteLine(" *   *   ");
            Console.ResetColor();
        }
    }
}
