using System;

public class Zoo : IZoo
{
    public List<Animal> Animal;
    public string Name { get; set; }

    public Zoo()
    {
        Animals = new List<Animal>();
        Animal.Add(new Pony() { Name = "Avalanche", Age = 10, Weight = 134.6F});
        Animal.Add(new Pony() { Name = "BigFat", Age = 9, Weight = 43.1F});
        Animal.Add(new Horse() { Name = "Black Beauty", Age = 7, Weight = 334.6F });
        Animal.Add(new Dog() { Name = "Rexy", Age = 6, Weight = 43.1F });
        Animal.Add(new Sheep() { Name = "Dolly", Age = 1, Weight = 13.6F });
        Animal.Add(new Bird() { Name = "Twetty", Age = 3, Weight = 3.1F });
    }
    public string Sounds()
    {
        string allSounds = "";
        foreach (var animal in Animal)
        {
            allSounds += animal.Sound() + ", ";
        }
        return allSounds;
    }
}