using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Donkey : Animal
    {
        public Donkey()
        {
            Console.WriteLine("We have created a new Donkey for our farm");
        }

        public override void Eats()
        {
            Console.WriteLine("The donkey eats grass");
        }

        public override void Sleep()
        {
            Console.WriteLine("The donkey sleeps in the barn");
        }

        public override void Sound()
        {
            Console.WriteLine("Ihaaa Ihaaaaa Ihaaa");
        }

        public override void Trick()
        {
            Console.WriteLine("Jumpy Jumpies");
        }
    }
}
