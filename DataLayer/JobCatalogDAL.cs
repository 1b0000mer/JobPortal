using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class JobCatalogDAL
    {
        public List<JobCatalog> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.JobCatalogs.ToList();

        }
        public void Add(JobCatalog add)
        {
            JobsEntities db = new JobsEntities();
            db.JobCatalogs.Add(add);
            db.SaveChanges();
        }

        public void Edit(JobCatalog add)
        {
            JobsEntities db = new JobsEntities();
            db.JobCatalogs.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(JobCatalog add)
        {
            JobsEntities db = new JobsEntities();
            db.JobCatalogs.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
