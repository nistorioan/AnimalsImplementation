using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Bird:Animal
    {
        public Bird()
        {
            Console.WriteLine("A bird was created");
        }

        public override void Eats()
        {
            Console.WriteLine("Our birds eats worms and seeds");
        }

        public override void Sleep()
        {
            Console.WriteLine("A bird sleeps in a nest or on a branch");
        }

        public override void Sound()
        {
            Console.WriteLine("Cip Cip Cip");
        }

        public override void Trick()
        {
            Console.WriteLine("Roll Roll and Back");
        }
    }
}
