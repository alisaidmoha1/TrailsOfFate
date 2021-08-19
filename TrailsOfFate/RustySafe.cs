using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrailsOfFate.Room;

namespace TrailsOfFate
{
    public class RustySafe
    {
        private string Code;


        public RustySafe(String code)
        {
            Code = code;
        }

        public void BreakTheCode()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You found the Rusty Safe Box, but you need to solve this riddle.");
                Console.Write("\n\n Riddle me this: What's the object-oriented way to become wealthy?:   ");

                string userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == Code)
                {
                    Console.WriteLine("\n\nCongratulations you opened the Rusty Safe Box\n\n");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                    ExitDoor.FindKey();
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("\n\nThe anwser was wrong, nothing happend... Try again!\n\n");
                    Console.WriteLine("Press any key to continue\n\n");
                    Console.ReadKey();
                    isRunning = true;
                }

            }
            
            
        }
    }
}
