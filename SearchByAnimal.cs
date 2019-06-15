using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    public class SearchByAnimal
    {
        AdsRepo adsRepo = new AdsRepo();
        List<Ad> foundAds = adsRepo.GetByAnimal(id);

        foreach(ad in foundAds)
        {
	        //use object to populate HTML
        }
    }
}
