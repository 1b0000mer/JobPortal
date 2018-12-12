using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataLayer
{
    public class PositionDAL
    {
        public List<Position> getlist()
        {
            JobsEntities db = new JobsEntities();
            return db.Positions.ToList();

        }
        public void Add(Position add)
        {
            JobsEntities db = new JobsEntities();
            db.Positions.Add(add);
            db.SaveChanges();
        }

        public void Edit(Position add)
        {
            JobsEntities db = new JobsEntities();
            db.Positions.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Position add)
        {
            JobsEntities db = new JobsEntities();
            db.Positions.Attach(add);
            db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
