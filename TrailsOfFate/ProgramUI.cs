using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailsOfFate
{
    class ProgramUI
    {
        public void Start()
        {

            Console.WriteLine("Where you want go? \n" +
                "1. Bathroom\n" +
                "2. North East Corner\n" +
                "3. By the window");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    //Bathroom - bucked of blood
                    break;
                case "2":
                    //North East corner - wax figure
                    break;
                case "3":
                    //by the window /// Rusty Safe
                    break;
                    default:
                    break;
            }

        }
    }
}
