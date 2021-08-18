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
            Console.WriteLine("You are at the door. It's locked you need a key");
            Console.WriteLine("Please enter a key");
            int choice = int.Parse(Console.ReadLine());
            Keys selectedKey = (Keys)choice;
            if (selectedKey == Keys.BronzeKey)
            {
                Console.WriteLine("The door is unlocked you are free to go");
            }
           
            else if (selectedKey != Keys.BronzeKey)
            {
                Console.WriteLine("the door is still locked try another key");
            }
         {

            }

        }

        public void AttemptCode()
        {

        }

    }
}
