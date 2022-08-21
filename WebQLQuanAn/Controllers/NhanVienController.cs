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
    public class NhanVienController : Controller
    {
        private DB db = new DB();

        // GET: NhanVien
        public ActionResult Danhsachnhanvien(string sortOrder,string searchString, int? page, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            //var nHANVIENs = db.NHANVIENs.Include(n => n.TAIKHOAN);
            //return View(nHANVIENs.ToList());
            var nhanvien = from nv in db.NHANVIENs
                           select nv;

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
                nhanvien = nhanvien.Where(s => s.TenNV.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    nhanvien = nhanvien.OrderByDescending(s => s.TenNV);
                    break;
                
                default:
                    nhanvien = nhanvien.OrderBy(s => s.TenNV);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(nhanvien.ToPagedList(pageNumber,pageSize));
        }

        // GET: NhanVien/Details/5
        public ActionResult Thongtinnhanvien(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // GET: NhanVien/Create
        public ActionResult Themnhanvien()
        {
            ViewBag.MaTK = new SelectList(db.TAIKHOANs, "MaTK", "TenTK");
            return View();
        }

        // POST: NhanVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Themnhanvien([Bind(Include = "MaNV,TenNV,DiaChi,NgaySinh,GioiTinh,SDT,MaTK,ChucVu")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.NHANVIENs.Add(nHANVIEN);
                db.SaveChanges();
                return RedirectToAction("Danhsachnhanvien");
            }

            ViewBag.MaTK = new SelectList(db.TAIKHOANs, "MaTK", "TenTK", nHANVIEN.MaTK);
            return View(nHANVIEN);
        }

        // GET: NhanVien/Edit/5
        public ActionResult Suathongtinnhanvien(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTK = new SelectList(db.TAIKHOANs, "MaTK", "TenTK", nHANVIEN.MaTK);
            return View(nHANVIEN);
        }

        // POST: NhanVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suathongtinnhanvien([Bind(Include = "MaNV,TenNV,DiaChi,NgaySinh,GioiTinh,SDT,MaTK,ChucVu")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHANVIEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Danhsachnhanvien");
            }
            ViewBag.MaTK = new SelectList(db.TAIKHOANs, "MaTK", "TenTK", nHANVIEN.MaTK);
            return View(nHANVIEN);
        }

        // GET: NhanVien/Delete/5
        public ActionResult Xoanhanvien(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // POST: NhanVien/Delete/5
        [HttpPost, ActionName("Xoanhanvien")]
        [ValidateAntiForgeryToken]
        public ActionResult Xoanhanvien(string id, FormCollection collection)
        {
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            db.NHANVIENs.Remove(nHANVIEN);
            db.SaveChanges();
            return RedirectToAction("Danhsachnhanvien");
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
