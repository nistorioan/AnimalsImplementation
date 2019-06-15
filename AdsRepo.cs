using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassAnimals
{
    public class AdsRepo
    {
        private Database db;

        public AdsRepo()
        {
            this.db = new Database();
        }

        public AdsRepo(Database db)
        {
            this.db = db;
        }

        public void Add(Ad ad)
        {
            string query = "insert into...";
            db.ExecuteNonQuery(query);
        }

        public void Update(Ad ad)
        {
            string query = "update ...";
            db.ExecuteNonQuery(query);
        }

        public Ad GetById(string adId)
        {
            string query = "select ...";
            return GetSingleAdFrom(db.ExecuteQuery(query));
        }

        public List<Ad> GetByKeywords(string keywords)
        {
            string query = "select ...";
            return GetAdsFrom(db.ExecuteQuery(query));
        }

        public List<Ad> GetByUser(string userId)
        {
            string query = "select ...";
            return GetAdsFrom(db.ExecuteQuery(query));
        }

        public void DeleteById(string adId)
        {
            string query = "update ...";
            db.ExecuteNonQuery(query);
        }

        private Ad GetSingleAdFrom(Reader reader)
        {
            var ad = new Ad();

            reader.Read();
            ad.Id = reader.Id;
            ad.Title = reader.Title;
            ad.Description = reader.Description;
            ad.Age = reader.Age;

            return ad;
        }

        private List<Ad> GetAdsFrom(Reader reader)
        {
            var ads = new List<Ad>();

            while (reader.Read)
            {
                var ad = new Ad();
                ad.Id = reader.Id;
                ad.Title = reader.Title;
                ad.Description = reader.Description;
                ad.Age = reader.Age;

                ads.Add(ad);
            }

            return ads;
        }
    }
}
