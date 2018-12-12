using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;
namespace BusinessLayer
{
    public class CompanyInfoBUL
    {
        static CompanyInfoDAL db;
        static CompanyInfoBUL()
        {
            db = new CompanyInfoDAL();
            
        }
        public static List<CompanyInfo>getlist()
        {
            return db.getlist();
        }
        public static List<CompanyInfo>search(string search)
        {
            return db.search(search);
        }
        public static void Add(CompanyInfo add)
        {
            db.Add(add);
        }
        public static void Edit(CompanyInfo add)
        {
            db.Edit(add);
        }
    }
}
