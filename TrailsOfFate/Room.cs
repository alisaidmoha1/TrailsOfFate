

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
            Console.Title = "Hunted House";
            



            bool isRunning = true;

            while (isRunning)
            {
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
