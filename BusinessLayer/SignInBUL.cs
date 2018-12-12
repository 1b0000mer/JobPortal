using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;
namespace BusinessLayer
{
   public class SignInBUL
    {
        static SignInDAL db;
        static SignInBUL()
        {
            db = new SignInDAL();
        }
        public static void SignIn(string name, string pass, string phone,string email)
        {
            db.SignIn(name, pass, email, phone);
        }
    }
}
