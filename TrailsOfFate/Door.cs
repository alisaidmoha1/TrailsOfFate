using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrailsOfFate.Room;

namespace TrailsOfFate
{
    public class Door
    {
        //private string Key;
        //private string Code

        public Keys Key { get; }

        public Door(Keys key)
        {
            Key = key;
            //Code = code;
        }
        public void FindKey()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("You have found 5 keys inside the rusty old safe. Choose wisely, and you just might make it out of here afterall\n\n");
                Console.WriteLine("You are at the door. It's locked you need a key, Enter a key \n" +
                                "1. Diamond Key\n" +
                                "2. Gold Key\n" +
                                "3. Silver Key\n" +
                                "4. Bronze Key\n" +
                                "5. Wooden Key");

                int choice = int.Parse(Console.ReadLine().Trim());
                Keys selectedKey = (Keys)choice;

                Console.Clear();


                switch (selectedKey)
                {
                    case Keys.DiamondKey:
                        Console.WriteLine($"You have chosen the {Keys.DiamondKey}!\n" +
                            $"This key is covered in diamonds.. blood diamonds\n");
                        ConsoleContinueMethod();
                        break;
                    case Keys.GoldKey:
                        Console.WriteLine($"You have chosen the {Keys.GoldKey}!\n" +
                            $"All behold the GOLDEN KEY!");
                        ConsoleContinueMethod();
                        break;
                    case Keys.SilverKey:
                        Console.WriteLine($"You have chosen the {Keys.SilverKey}!\n" +
                            $"This key kills vampires and werewolves.");
                        ConsoleContinueMethod();
                        break;
                    case Keys.BronzeKey:
                        Console.WriteLine($"You have chosen the {Keys.BronzeKey}!\n" +
                            $"Congrats on escaping! Thanks for playing");
                        isRunning = false;
                        Console.ReadKey(true);
                        break;
                    case Keys.WoodenKey:
                        Console.WriteLine($"You have chosen the {Keys.WoodenKey}!\n" +
                            $"So humble. Indiana Jones would be proud of you! That key belongs in a mueseum you know.");
                        ConsoleContinueMethod();
                        break;
                }

                

            }

        }

        public void ConsoleContinueMethod()
        {
            Console.WriteLine("\n\nPress any key to continue the game\n\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
