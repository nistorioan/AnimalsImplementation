using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Pony : Animal
    {
        public Pony()
        {
            Console.WriteLine("We have created a new Pony for our farm");
        }

        public override void Eats()
        {
            Console.WriteLine("The Pony eats grass and carots");
        }

        public override void Sleep()
        {
            Console.WriteLine("The Pony sleeps in the barn");
        }

        public override void Sound()
        {
            Console.WriteLine("Ihaa Ihaaa");
        }

        public override void Trick()
        {
            Console.WriteLine("Jumpy Jump");
        }
    }
}
