using System;

namespace FelineProjecr
{
    abstract class Feline
    {
        public void Talk()
        {
            Console.WriteLine($"{this.GetType().Name} is talking");
        }

        public void Run()
        {
            Console.WriteLine($"{this.GetType().Name} is running");
        }

        public void Eat()
        {
            Console.WriteLine($"{this.GetType().Name} is eating");
        }

        public void Jump()
        {
            Console.WriteLine($"{this.GetType().Name} is jumping");
        }

        public void Sleep ()
        {
            Console.WriteLine($"{this.GetType().Name} is sleeping");
        }

        public void Hunt()
        {
            Console.WriteLine($"{this.GetType().Name} is hunting");
        }
    }
}
