using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataLayer
{
    public class CompanyInfoDAL
    {
        public List<CompanyInfo> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.CompanyInfoes.ToList();

        }
        public List<CompanyInfo> search(string search)
        {
            JobsEntities db = new JobsEntities();
            return db.CompanyInfoes.Where(p=>p.ComName.Contains(search)).ToList();
        }
        public void Add(CompanyInfo add )
        {
            JobsEntities db = new JobsEntities();
            db.CompanyInfoes.Add(add);
            db.SaveChanges();

        }
        public void Edit(CompanyInfo add)
        {
            JobsEntities db = new JobsEntities();
            db.CompanyInfoes.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }

}
