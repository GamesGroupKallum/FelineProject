using System;

namespace FelineProjecr
{
    class WildCat : Feline, ISwim, IClimb
    {
        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is swimming");
        }
    }
}