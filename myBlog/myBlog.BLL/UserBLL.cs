using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myBlog.DAL;
using myBlog.Entity;

namespace myBlog.BLL
{
    public class UserBLL
    {
        private readonly UserDAL dal = new UserDAL();

        public User GetUserInfo(string userCD)
        {
            User u = dal.GetUserInfo(userCD);
            if (u != null)
                return u;
            else
                return new User();
        }
    }
}
