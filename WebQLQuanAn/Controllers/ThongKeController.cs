using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebQLQuanAn.Models;

namespace WebQLQuanAn.Controllers
{
    public class ThongKeController : Controller
    {
        private DB db = new DB();

        // GET: ThongKe
        public ActionResult Index()
        {
            var hOADONs = db.HOADONs.Include(h => h.BAN).Include(h => h.GIAMGIA).Include(h => h.KHACHHANG).Include(h => h.NHANVIEN);
            int sohd = db.HOADONs.Count();
            //ViewBag.sohoadon = sohd;
            ViewData["sohoadon"] = sohd;
            return View(hOADONs.ToList());
        }

        [HttpPost]
        public ActionResult Index(DateTime start, DateTime end)
        {
            var hoaDon = db.LayDS(start, end).ToList();
            int sohd = hoaDon.Count();
            //ViewBag.sohoadon = sohd;
            ViewData["sohoadon"] = sohd;
            return View(hoaDon);
        }


    }
}
