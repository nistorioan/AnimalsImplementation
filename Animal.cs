using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("An animal has been created");
        }

        public virtual void sleep()
        {
            Console.WriteLine("An animal is sleeping");
        }

        public virtual void eats()
        {
            Console.WriteLine("An animal is eating");
        }
    }
}
