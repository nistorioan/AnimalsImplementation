using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Horse:Animal
    {
        public Horse()
        {
            Console.WriteLine("We have created a new Horse for our farm");
        }

        public override void eats()
        {
            Console.WriteLine("The horse eats grass and feed");
        }

        public override void sleep()
        {
            Console.WriteLine("The horse sleeps standing in the barn");
        }
    }
}
