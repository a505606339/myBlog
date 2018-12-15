using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myBlog.BLL;
using myBlog.Entity;

namespace myBlog.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            UserBLL ubll = new UserBLL();
            User u = ubll.GetUserInfo("Lukaaa");
            return View(u);
            
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["inputEmail3"];
            string name = fc["inputPassword3"];
            
            ViewBag.LoginState = email + "登录后";
            return View();
        }

        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }
    }
}