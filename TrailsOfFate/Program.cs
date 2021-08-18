using System;

namespace TrailsOfFate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello Welcome to the our hunted house!");
                ProgramUI game = new ProgramUI();
                game.Start();
           
        }
    }
}
