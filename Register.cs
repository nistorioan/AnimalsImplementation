using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    public class Register
    {
        Animal animal = new Animal();
        Animal.DisplayName = displayName;

        AnimalRepo animalRepo = new AnimalRepo();
        animalRepo.Add(animal);
    }
}
