using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class InfoUserBUL
    {
        static InfoUserDAL db;
        static InfoUserBUL()
        {
            db = new InfoUserDAL();

        }
        public static List<InfoUser> getlist()
        {
            return db.getlist();
        }
        public static List<InfoUser> Search(string search)
        {
            return db.Search(search);
        }
        public static void Add(InfoUser add)
        {
            db.Add(add);
        }
        public static void Edit(InfoUser add)
        {
            db.Edit(add);
        }
    }
}
