using System;

namespace FelineProjecr
{
    class SandCat : Feline, ICamo
    {
        public void Camo()
        {
            Console.WriteLine($"{this.GetType().Name} is camouflaged");
        }
    }
}