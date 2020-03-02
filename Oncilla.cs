using System;

namespace FelineProjecr
{
    class Oncilla : Feline, ICamo, ISwim
    {
        public void Camo()
        {
            Console.WriteLine($"{this.GetType().Name} is camouflaged");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.GetType().Name} is swimming");
        }
    }
}