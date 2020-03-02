using System;

namespace FelineProjecr
{
    class Cheeto : Feline, IClimb
    {
        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing");
        }
    }
}
