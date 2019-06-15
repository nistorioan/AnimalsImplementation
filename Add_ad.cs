using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    public class Add_ad
    {
        Ad ad = new Ad();
        ad.Title = title;
        ad.Description = description;
        ad.Age = age;
        ad.AnimalId = currentAnimal;

        AdsRepo adsRepo = new AdsRepo()
        adsRepo.Add(ad);
    }
}
