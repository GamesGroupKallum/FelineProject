using System;

namespace FelineProjecr
{
    class Lion : Feline, IClimb, ICamo, ISwim
    {
        public void Socialise()
        {
            Console.WriteLine($"{this.GetType().Name} is socialising");
        }

        public void Camo()
        {
            Console.WriteLine($"{this.GetType().Name} is camouflaged");
        }

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
