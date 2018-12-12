using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class JobBUL
    {
        static JobDAL db;
        static JobBUL()
        {
            db = new JobDAL();

        }
        public static List<Job> getlist()
        {
            return db.getlist();
        }
        public static void Add(Job add)
        {
            db.Add(add);
        }
        public static void Edit(Job add)
        {
            db.Edit(add);
        }
        public static void Delete(Job add)
        {
            db.Delete(add);
        }
    }
}
