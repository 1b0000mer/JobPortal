using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class InfoUserDAL
    { 
        public List<InfoUser> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.InfoUsers.ToList();
        }
        public List<InfoUser> Search(string search)
        {
            JobsEntities db = new JobsEntities();
            return db.InfoUsers.Where(p => p.USERNAME.Contains(search)).ToList();
        }
        public void Add(InfoUser add)
        {
            JobsEntities db = new JobsEntities();
            db.InfoUsers.Add(add);
            db.SaveChanges();
        }
        public void Edit(InfoUser add)
        {
            JobsEntities db = new JobsEntities();
            db.InfoUsers.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
