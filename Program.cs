﻿using System;

namespace ProjectClassAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Project Class Animals");

            Bird bird = new Bird();
            bird.eats();
            bird.sleep();
            Console.WriteLine();

            Horse horse = new Horse();
            horse.eats();
            horse.sleep();
            Console.WriteLine(); 
        }
    }
}