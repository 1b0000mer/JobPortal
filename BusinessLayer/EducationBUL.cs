using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class EducationBUL
    {
        static EducationDAL db;
        static EducationBUL()
        {
            db = new EducationDAL();
        }
        public static List<Education> getlist()
        {
            return db.getlist();
        }
        public static void Update(Education update)
        {
            db.Update(update);
        }
    }
}
