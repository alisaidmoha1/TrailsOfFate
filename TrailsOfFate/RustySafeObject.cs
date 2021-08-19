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
        

        public RustySafeObject(string name, string description) {

            Name = name;
            Description = description;
        }

        public void DisplayKeyInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
        }

    }
}
