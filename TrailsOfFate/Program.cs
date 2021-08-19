using System;
using System.Diagnostics;
using System.Threading;

namespace TrailsOfFate
{
    public class Program
    {
        //static Timer timer = new Timer(1000);
        //static int i = 0;
        public static void Main(string[] args)
        { 
                Room game = new Room();
            //timer.Elapsed += timer_Elapsed;
            //timer.Start(); 
            Stopwatch stopwatch = new Stopwatch();
            //Thread.Sleep(5000);
            //stopwatch.ElapsedMilliseconds = 5000;
            bool KeepRunning = true;
                stopwatch.Start();
            while (KeepRunning)
            {
                game.Start();
                if (stopwatch.Elapsed.TotalMinutes <= 1)
                {
                    Console.WriteLine($"GAME OVER!!! Elapsed time is:{stopwatch.Elapsed.TotalMinutes}");
                    KeepRunning = false;
                    game.Start();
                    break;

                }
                else
                {
                    KeepRunning = true;
                    Console.WriteLine($"Elapsed time is:{stopwatch.Elapsed.TotalMinutes} minutes");
                    Console.ReadKey();
                }

                    stopwatch.Stop();

            }
            




        }

        //private static void timer_Elapsed (Object sender, ElapsedEventArgs e)
        //{
         //   i--;
            //Console.Clear();
            //Console.WriteLine("=================================================");
            //Console.WriteLine("                  DEFUSE THE BOMB");
            //Console.WriteLine("");
            //Console.WriteLine("                Time Remaining:  " + i.ToString());
            //Console.WriteLine("");
            //Console.WriteLine("=================================================");
        
    }
}
