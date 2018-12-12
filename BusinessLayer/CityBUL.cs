using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class CityBUL
    {
        static CityDAL db;
        static CityBUL()
        {
            db = new CityDAL();

        }
        public static List<City> getlist()
        {
            return db.getlist();
        }
        public static void Add(City add)
        {
            db.Add(add);
        }
        public static void Edit(City add)
        {
            db.Edit(add);
        }
        public static void Delete(City add)
        {
            db.Delete(add);
        }
    }
}
