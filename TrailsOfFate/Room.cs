

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastel;
using Figgle;

namespace TrailsOfFate
{
        public enum Keys { DiamondKey =1, GoldKey, SilverKey, BronzeKey, WoodenKey }
    public class Room
    {
        
        private EscapeRoom WaxFigure;
        private EscapeRoom BucketOfBlood;
        protected RustySafe SafeBox;
        public static Door ExitDoor;

        public Room()
        {
            WaxFigure = new EscapeRoom("Wax Figure", "You see a creepy wax figure -HINT=");
            BucketOfBlood = new EscapeRoom("Bucket of blood", "Unless you want drink it there is no use for it");
            ExitDoor = new Door(Keys.BronzeKey);
            SafeBox = new RustySafe("inheritance");

        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "Trials of Fate";
            Console.WriteLine(FiggleFonts.SBlood.Render("     Welcome"));
            Console.WriteLine(FiggleFonts.SBlood.Render("          to"));
            Console.WriteLine(FiggleFonts.SBlood.Render("TRIALS OF FATE"));
            Console.WriteLine("Press any key to start the game");
            Console.ReadKey();
            Console.Clear();



            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Where you want go? \n" +
                    "1. Bathroom\n" +
                    "2. North East Corner\n" +
                    "3. By the window");
            
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        BucketOfBlood.DisplayInfo();
                        Console.WriteLine("\n\nPress enter to continue the game\n\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        WaxFigure.DisplayInfo();
                        Console.WriteLine("\n\nPress enter to continue the game\n\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        SafeBox.BreakTheCode();
                        Console.ReadKey();
                        isRunning = false;
                        break;

                    default:
                        break;
                }

            }
            Console.WriteLine("Press any key to exit the game...");
            Console.ReadKey();
        }


    }
}
