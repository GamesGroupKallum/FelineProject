using System;
using System.Collections.Generic;
using System.Text;

namespace FelineProjecr
{
    class Ocelot: Feline, IClimb, ISwim
    {
        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing.");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is swimming.");
        }
    }
}
