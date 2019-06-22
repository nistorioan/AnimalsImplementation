using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("We have created a new Dog for our farm");
        }

        public override void Eats()
        {
            Console.WriteLine("The dog eats meat and bones");
        }

        public override void Sleep()
        {
            Console.WriteLine("The dog sleeps in his dog house or outside");
        }

        public override void Sound()
        {
            Console.WriteLine("Bark Bark");
        }

        public override void Trick()
        {
            Console.WriteLine("Jump Jump");
        }
    }
}
