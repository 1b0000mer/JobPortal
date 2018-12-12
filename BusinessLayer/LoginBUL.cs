using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;
namespace BusinessLayer
{
    public class LoginBUL
    {
        static LoginDAL db;
        static LoginBUL()
        {
            db = new LoginDAL();
        }
        public static Admin Login(string user, string pass)
        {
            return db.Login(user,pass);
        }
    }
}
