using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebQLQuanAn.Models;

namespace WebQLQuanAn.Controllers
{
    public class HomeController : Controller
    {
        private DB db = new DB();
        public ActionResult Index()
        {
            if (System.Web.HttpContext.Current.Session["Fullname"].Equals(""))
            {
                return Redirect("~/Home/Login");
            } else
            {
                return View();
            }
            
        }

        public ActionResult Login()
        {
            ViewBag.Error = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection field)
        {
            string strerror = "";
            string user = field["user"];
            string password = field["password"];
            var userModel = (from t in db.TAIKHOANs
                             join n in db.NHANVIENs
                             on t.MaTK equals n.MaTK
                             where t.TenTK == user
                             select new
                             {
                                 n.TenNV , t.TenTK , t.MK
                             }).FirstOrDefault();

            //var users = db.TAIKHOANs
            //        .Where(m => m.TenTK == user).FirstOrDefault();
            if (userModel == null)
            {
                strerror = "Tên đăng nhập không tồn tại!!!";
            } else
            {
                if (userModel.MK.Equals(password))
                {
                    Session["user"] = userModel.TenTK;
                    Session["Fullname"] = userModel.TenNV;
                    return RedirectToAction("Index", "Home");
                } else
                {
                    strerror = "Mật khẩu không đúng!!!";
                }
            }

            ViewBag.Error = strerror;
            return View();

        }

        public ActionResult Logout()
        {
            Session["user"] = "";
            Session["Fullname"] = "";
            return RedirectToAction("Login");
        }

    }
}