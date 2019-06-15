using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    public class Ad_details
    {
        AdsRepo adsRepo = new AdsRepo();
        Ad ad = adsRepo.GetById(adId);
    }
}
