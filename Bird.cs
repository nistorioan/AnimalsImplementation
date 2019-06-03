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

        public override void eats()
        {
            //base.eats();
            Console.WriteLine("Our birds eats worms and seeds");
        }
        public override void sleep()
        {
            Console.WriteLine("A bird sleeps in a nest or on a branch");
        }
    }
}
