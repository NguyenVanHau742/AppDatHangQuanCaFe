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
    public class SanPhamController : Controller
    {
        private DB db = new DB();

        // GET: SanPham
        public ActionResult Danhsachsanpham(string sortOrder, string searchString, int? page, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //var sANPHAMs = db.SANPHAMs.Include(s => s.LOAISP);
            //return View(sANPHAMs.ToList());

            var sanpham = db.SANPHAMs.Include(sp => sp.LOAISP);

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
                sanpham = sanpham.Where(s => s.TenSP.Contains(searchString));
            }
            
            switch (sortOrder)
            {
                case "name_desc":
                    sanpham = sanpham.OrderByDescending(s => s.TenSP);
                    break;

                default:
                    sanpham = sanpham.OrderBy(s => s.TenSP);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(sanpham.ToPagedList(pageNumber, pageSize));
        }

        // GET: SanPham/Details/5
        public ActionResult Thongtinsanpham(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: SanPham/Create
        public ActionResult Themsanpham()
        {
            ViewBag.MaLoaiSP = new SelectList(db.LOAISPs, "MaLoai", "TenLoai");
            return View();
        }

        // POST: SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Themsanpham([Bind(Include = "MaSP,TenSP,DonGia,DonVi,MoTa,HinhAnh,MaLoaiSP")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.SANPHAMs.Add(sANPHAM);
                db.SaveChanges();
                return RedirectToAction("Danhsachsanpham");
            }

            ViewBag.MaLoaiSP = new SelectList(db.LOAISPs, "MaLoai", "TenLoai", sANPHAM.MaLoaiSP);
            return View(sANPHAM);
        }

        // GET: SanPham/Edit/5
        public ActionResult Suathongtinsanpham(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiSP = new SelectList(db.LOAISPs, "MaLoai", "TenLoai", sANPHAM.MaLoaiSP);
            return View(sANPHAM);
        }

        // POST: SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suathongtinsanpham([Bind(Include = "MaSP,TenSP,DonGia,DonVi,MoTa,HinhAnh,MaLoaiSP")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sANPHAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Danhsachsanpham");
            }
            ViewBag.MaLoaiSP = new SelectList(db.LOAISPs, "MaLoai", "TenLoai", sANPHAM.MaLoaiSP);
            return View(sANPHAM);
        }

        // GET: SanPham/Delete/5
        public ActionResult Xoasanpham(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Xoasanpham")]
        [ValidateAntiForgeryToken]
        public ActionResult Xoasanpham(int id)
        {
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(sANPHAM);
            db.SaveChanges();
            return RedirectToAction("Danhsachsanpham");
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
