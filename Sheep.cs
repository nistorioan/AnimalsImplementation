﻿using System;
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

        public override void Eats()
        {
            Console.WriteLine("The sheep eats grass and feed");
        }

        public override void Sleep()
        {
            Console.WriteLine("The sheep sleeps outside on the field");
        }

        public override void Sound()
        {
            Console.WriteLine("Beee Beheeee");
        }

        public override void Trick()
        {
            Console.WriteLine("Spin Spin around");
        }
    }
}
