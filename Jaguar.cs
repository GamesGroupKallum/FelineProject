using System;

namespace FelineProjecr
{
    class Jaguar : Feline, ISwim
    {
        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing");
        }
    }
}
