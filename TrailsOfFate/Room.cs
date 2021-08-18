

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailsOfFate
{
    public class Room
    {
        public enum Keys { DiamondKey, GoldKey, SilverKey, BronzeKey, WoodenKey }
        public List<Keys> properKey = new List<Keys>();
        


        private EscapeRoom RustySafe;
        private EscapeRoom WaxFigure;
        private EscapeRoom BucketOfBlood;
        private Door ExitDoor;
    
      


        public Room()
        {
            RustySafe = new EscapeRoom("Rusty Safe", "You found an old rusty safe, there is something inside of it.\n" +
                "\n");
            WaxFigure = new EscapeRoom("Wax Figure", "You see a creepy wax figure -HINT=");
            BucketOfBlood = new EscapeRoom("Bucket of blood", "Unless you want drink it there is no use for it");
            ExitDoor = new Door(Keys.BronzeKey);

            

        }

        public void Start()
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
                        break;
                    case "2":
                        WaxFigure.DisplayInfo();
                        break;
                    case "3":
                        RustySafe.DisplayInfo();

                        Console.WriteLine("You have found 5 keys inside the rusty old safe. Choose wisely, and you just might make it out of here afterall.\n" +
                            "\n" +
                            "1. Diamond Key\n" +
                            "2. Gold Key\n" +
                            "3. Silver Key\n" +
                            "4. Bronze Key\n" +
                            "5. Wooden Key");
                        string keyChoice = Console.ReadLine();

                        Console.Clear();


                        switch (keyChoice)
                        {
                            case "1":
                                Console.WriteLine($"You have chosen the {Keys.DiamondKey}!\n" +
                                    $"This key is covered in diamonds.. blood diamonds");
                                break;
                            case "2":
                                Console.WriteLine($"You have chosen the {Keys.GoldKey}!\n" +
                                    $"All behold the GOLDEN KEY!");
                                break;
                            case "3":
                                Console.WriteLine($"You have chosen the {Keys.SilverKey}!\n" +
                                    $"This key kills vampires and werewolves.");
                                break;
                            case "4":
                                Console.WriteLine($"You have chosen the {Keys.BronzeKey}!\n" +
                                    $"This key won 3rd at the Tokyo olympics.");
                                   ExitDoor.FindKey();
                                break;
                            case "5":
                                Console.WriteLine($"You have chosen the {Keys.WoodenKey}!\n" +
                                    $"So humble. Indiana Jones would be proud of you! That key belongs in a mueseum you know.");
                                break;

                        }

                        break;
                    

                    default:
                        break;
                }
                Console.ReadKey();


            


        }

    }


    }
