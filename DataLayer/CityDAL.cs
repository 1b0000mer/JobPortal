using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class CityDAL
    {
        public List<City> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.Cities.ToList();

        }

        public void Add(City add)
        {
            JobsEntities db = new JobsEntities();
            db.Cities.Add(add);
            db.SaveChanges();
        }

        public void Edit(City add)
        {
            JobsEntities db = new JobsEntities();
            db.Cities.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(City add)
        {
            JobsEntities db = new JobsEntities();
            db.Cities.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
