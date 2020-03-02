using System;

namespace FelineProjecr
{
    abstract class Feline
    {
        void Talk()
        {
            Console.WriteLine($"{this.GetType().Name} is talking");
        }
        
        void Run()
        {
            Console.WriteLine($"{this.GetType().Name} is running");
        }

        void Eat()
        {
            Console.WriteLine($"{this.GetType().Name} is eating");
        }

        void Jump()
        {
            Console.WriteLine($"{this.GetType().Name} is jumping");
        }

        void Sleep ()
        {
            Console.WriteLine($"{this.GetType().Name} is sleeping");
        }

        void Hunt()
        {
            Console.WriteLine($"{this.GetType().Name} is hunting");
        }
    }
}
