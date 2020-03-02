using System;
using System.Collections.Generic;
using System.Text;

namespace FelineProjecr
{
    class Caracal: Feline, IClimb
    {
        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing");
        }
    }
}
