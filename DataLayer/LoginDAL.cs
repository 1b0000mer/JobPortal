using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataLayer
{

    public class LoginDAL
    {
        public Admin Login(string username,string pass)
        {
            using (JobsEntities db= new JobsEntities())
            {
                Admin ad = db.sp_Login(username,pass).SingleOrDefault();
                return ad;
            }

          
        }
    }
}
