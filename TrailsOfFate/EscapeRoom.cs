using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrailsOfFate.Room;

namespace TrailsOfFate
{
    public class EscapeRoom
    {
        
        public string Name;
        public string Description;

        public EscapeRoom(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"You inspect the {Name}.\n");
            Console.Write(Description);
        }

        
    }
}
