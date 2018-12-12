using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class EducationDAL
    {
        public List<Education> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.Educations.ToList();
        }
        public void Update(Education update)
        {
            JobsEntities db = new JobsEntities();
            db.Educations.Add(update);
            db.SaveChanges();
        }
    }
}
