using System;
using System.Diagnostics;
using System.Threading;

namespace TrailsOfFate
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Room game = new Room();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            game.Start();
            stopwatch.Stop();
            if (stopwatch.Elapsed.TotalSeconds < 20)
            {
                Console.WriteLine($"That was fast, I did not expect that from you! It took you {stopwatch.Elapsed.TotalSeconds} seconds to finish the game.");
            }
            else if (stopwatch.Elapsed.TotalSeconds >= 20 || stopwatch.Elapsed.TotalSeconds <= 40)
            {
                Console.WriteLine($"You did alright! It took you {stopwatch.Elapsed.TotalSeconds} seconds to finish the game.");
            }
            else
            {
                Console.WriteLine($" You are not smart, are you? It took you {stopwatch.Elapsed.TotalSeconds} seconds to finish the game.");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
            
            }
               


        }



}
