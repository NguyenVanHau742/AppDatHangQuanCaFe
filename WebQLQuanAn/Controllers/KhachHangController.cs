using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebQLQuanAn.Models;
using PagedList;

namespace WebQLQuanAn.Controllers
{
    public class KhachHangController : Controller
    {
        private DB db = new DB();

        // GET: KhachHang
        public ActionResult Danhsachkhachhang(string sortOrder, string searchString, int? page, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            var khachhang = from kh in db.KHACHHANGs
                           select kh;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                khachhang = khachhang.Where(s => s.TenKH.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    khachhang = khachhang.OrderByDescending(s => s.TenKH);
                    break;

                default:
                    khachhang = khachhang.OrderBy(s => s.TenKH);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(khachhang.ToPagedList(pageNumber, pageSize));
            //return View(db.KHACHHANGs.ToList());
        }

        // GET: KhachHang/Details/5
        public ActionResult Thongtinkhachhang(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            if (kHACHHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHACHHANG);
        }

        // GET: KhachHang/Create
        public ActionResult Themkhachhang()
        {
            return View();
        }

        // POST: KhachHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Themkhachhang([Bind(Include = "MaKH,TenKH,SDT")] KHACHHANG kHACHHANG)
        {
            if (ModelState.IsValid)
            {
                db.KHACHHANGs.Add(kHACHHANG);
                db.SaveChanges();
                return RedirectToAction("Danhsachkhachhang");
            }

            return View(kHACHHANG);
        }

        // GET: KhachHang/Edit/5
        public ActionResult Suathongtinkhachhang(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            if (kHACHHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHACHHANG);
        }

        // POST: KhachHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suathongtinkhachhang([Bind(Include = "MaKH,TenKH,SDT")] KHACHHANG kHACHHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kHACHHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Danhsachkhachhang");
            }
            return View(kHACHHANG);
        }

        // GET: KhachHang/Delete/5
        public ActionResult Xoakhachhang(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            if (kHACHHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHACHHANG);
        }

        // POST: KhachHang/Delete/5
        [HttpPost, ActionName("Xoakhachhang")]
        [ValidateAntiForgeryToken]
        public ActionResult Xoakhachhang(int id)
        {
            KHACHHANG kHACHHANG = db.KHACHHANGs.Find(id);
            db.KHACHHANGs.Remove(kHACHHANG);
            db.SaveChanges();
            return RedirectToAction("Danhsachkhachhang");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
