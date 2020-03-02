using System;
using System.Collections.Generic;
using System.Text;

namespace FelineProjecr
{
    class CloudedLeopard: Feline, ICamo, IClimb, ISwim
    {
        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing.");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is swimming.");
        }

        public void Camo()
        {
            Console.WriteLine($"{this.GetType().Name} is camoflaged.");
        }
    }
}
