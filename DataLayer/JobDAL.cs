using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class JobDAL
    {
        public List<Job> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.Jobs.ToList();
        }
        public void Add(Job add)
        {
            JobsEntities db = new JobsEntities();
            db.Jobs.Add(add);
            db.SaveChanges();
        }

        public void Edit(Job add)
        {
            JobsEntities db = new JobsEntities();
            db.Jobs.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Job add)
        {
            JobsEntities db = new JobsEntities();
            db.Jobs.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
