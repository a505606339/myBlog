using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myBlog.Entity;

namespace myBlog.DAL
{
    public class UserDAL
    {
        private myblogContext db = new myblogContext();

        public User GetUserInfo(string userCD)
        {
            return db.users.Where(u => u.CD == userCD).FirstOrDefault();
        }
    }
}
