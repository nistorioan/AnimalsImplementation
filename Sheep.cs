using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Sheep: Animal
    {
        public Sheep()
        {
            Console.WriteLine("We have created a new Sheep for our farm");
        }

        public override void eats()
        {
            Console.WriteLine("The sheep eats grass and feed");
        }

        public override void sleep()
        {
            Console.WriteLine("The sheep sleeps outside on the field");
        }
    }
}
