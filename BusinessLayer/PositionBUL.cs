using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class PositionBUL
    {
        static PositionDAL db;
        static PositionBUL()
        {
            db = new PositionDAL();

        }
        public static List<Position> getlist()
        {
            return db.getlist();
        }
        public static void Add(Position add)
        {
            db.Add(add);
        }
        public static void Edit(Position add)
        {
            db.Edit(add);
        }
        public static void Delete(Position add)
        {
            db.Delete(add);
        }
    }
}
