using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using myBlog.Models;

namespace myBlog.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser {UserName="zheng",Password="1" },
                new SysUser {UserName="chen",Password="2" }
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRole = new List<SysRole>
            {
                new SysRole {RoleName="Admin",RoleDesc="这是一个管理员" },
                new SysRole {RoleName="Guest",RoleDesc="这是一个来宾账户" }
            };
            sysRole.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();
        }
    }
}