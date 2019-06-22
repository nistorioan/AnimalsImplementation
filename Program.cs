using System;

namespace ProjectClassAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Class Animals Project");

            Zoo myZoo = new Zoo();
            Menu(myZoo);

            Bird bird = new Bird();
            bird.Eats();
            bird.Sleep();
            bird.Sound();
            bird.Trick();
            Console.WriteLine();

            Horse horse = new Horse();
            horse.Eats();
            horse.Sleep();
            horse.Sound();
            horse.Trick();
            Console.WriteLine();

            Sheep sheep = new Sheep();
            sheep.Eats();
            sheep.Sleep();
            sheep.Sound();
            Console.WriteLine();
        }

        public static void Menu(Zoo myZoo)
        {
            Console.WriteLine("###########################################################");
            Console.WriteLine("###             Welcome to the main menu                ###");
            Console.WriteLine("###########################################################");
            Console.WriteLine("###                Select an option:                    ###");
            Console.WriteLine("###########################################################");
            Console.WriteLine();
            Console.WriteLine("### C: Listen the sounds " + myZoo.Name);
            Console.WriteLine("### D: Display the names ");
            Console.WriteLine("### E: Display all the names ");
            Console.WriteLine("### ESC: Exit ");

            ConsoleKeyInfo choosenOption = Console.ReadKey();
            Console.ReadLine();

            switch (choosenOption.Key)
            {
                case ConsoleKey.C:
                    Console.WriteLine();
                    Console.WriteLine("### Sounds from the Zoo ##");
                    Console.WriteLine(myZoo.Sounds());
                    Console.WriteLine();
                    break;

                case ConsoleKey.D:
                    Console.WriteLine();
                    Console.WriteLine("### Names of the animals from the Zoo ");
                    Console.Write(myZoo.Animal.Where(x => Age == 2).FirstOrDefault().Name+ " ##");
                    Console.WriteLine();
                    break;

                case ConsoleKey.E:
                    Console.WriteLine();
                    Console.WriteLine("### All the names ##");
                    foreach(var animal in myZoo.Animal)
                    {
                        Console.WriteLine(animal.Name);
                    }
                    Console.WriteLine();
                    break;

                case ConsoleKey.Escape:
                    System.Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("### No Way ##");
                    break;
            }

            Console.WriteLine("### Press any key to return to the Menu ##");
            Console.ReadKey();
            Console.Clear();
            Menu(myZoo);
        }
    }
}
