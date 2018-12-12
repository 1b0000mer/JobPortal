using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataLayer
{
    public class SignInDAL
    {
        public void SignIn(string name,string pass, string email, string sdt)
        {
            JobsEntities db = new JobsEntities();
            db.sp_Signin(name, pass, sdt, email);
        }
    }
}
