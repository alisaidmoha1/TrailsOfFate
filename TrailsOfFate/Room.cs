

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailsOfFate
{
    public class Room
    {
        private EscapeRoom RustySafe;
        private EscapeRoom WaxFigure;
        private EscapeRoom BucketOfBlood;

       
        public Room()
        {
            RustySafe = new EscapeRoom("Rusty Safe", "You found an old rusty safe, don't look under the safe there is no key");
            WaxFigure = new EscapeRoom("Wax Figure", "You see a creepy wax figure -HINT=");
             BucketOfBlood = new EscapeRoom("Bucket of blood", "Unless you want drink it there is no use for it");

        }


    }
}
