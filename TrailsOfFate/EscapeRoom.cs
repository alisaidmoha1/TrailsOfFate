using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailsOfFate
{
    class EscapeRoom
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
            Console.WriteLine($"You inspect the {Name}.");
            Console.Write(Description);
        }
    }
}
