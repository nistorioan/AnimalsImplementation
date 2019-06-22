using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    class Animal
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }

        public Animal()
        {
            Console.WriteLine("An animal has been created");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("An animal is sleeping");
        }

        public virtual void Sound()
        {
            Console.WriteLine("An animal is making a sound");
        }

        public virtual void Eats()
        {
            Console.WriteLine("An animal is eating");
        }

        public virtual void Trick()
        {
            Console.WriteLine("An animal is making a trick");
        }
    }
}
