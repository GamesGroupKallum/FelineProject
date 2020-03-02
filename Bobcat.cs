using System;

namespace FelineProjecr
{
    class Bobcat : Feline, IClimb, ISwim
    {
        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing");
        }
    }
}
