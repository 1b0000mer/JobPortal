using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class JobCatalogBUL
    {
        static JobCatalogDAL db;
        static JobCatalogBUL()
        {
            db = new JobCatalogDAL();

        }
        public static List<JobCatalog> getlist()
        {
            return db.getlist();
        }
        public static void Add(JobCatalog add)
        {
            db.Add(add);
        }
        public static void Edit(JobCatalog add)
        {
            db.Edit(add);
        }
        public static void Delete(JobCatalog add)
        {
            db.Delete(add);
        }
    }
}
