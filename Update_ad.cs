using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    public class Update_ad
    {
        AdsRepo adsRepo = new AdsRepo();
        Ad ad = adsRepo.GetById(adId);
        ad.Category = ad.Category - 20;

        adsRepo.Update(ad);

        //we may include redirect
    }
}
