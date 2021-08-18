using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailsOfFate
{
    public class RustySafeObject
    {
        private string Name;
        private string Description;
        private ConsoleColor KeyColor;

        public RustySafeObject(string name, string description, ConsoleColor keyColor) {

            Name = name;
            Description = description;
            KeyColor = keyColor;
        
        }

    }
}
