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
    public class BanController : Controller
    {
        private DB db = new DB();

        // GET: Ban
        public ActionResult Danhsachban(string sortOrder, string searchString, int? page, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";


            var ban = from b in db.BANs
                      select b;

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
                ban = ban.Where(b => b.TenBan.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    ban = ban.OrderByDescending(b => b.TenBan);
                    break;

                default:
                    ban = ban.OrderBy(b => b.TenBan);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(ban.ToPagedList(pageNumber, pageSize));
            //return View(db.BANs.ToList());
        }

        // GET: Ban/Details/5
        public ActionResult Thongtinban(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BAN bAN = db.BANs.Find(id);
            if (bAN == null)
            {
                return HttpNotFound();
            }
            return View(bAN);
        }

        // GET: Ban/Create
        public ActionResult Themban()
        {
            return View();
        }

        // POST: Ban/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Themban([Bind(Include = "MaBan,TenBan,LoaiBan,TrangThai")] BAN bAN)
        {
            if (ModelState.IsValid)
            {
                db.BANs.Add(bAN);
                db.SaveChanges();
                return RedirectToAction("Danhsachban");
            }

            return View(bAN);
        }

        // GET: Ban/Edit/5
        public ActionResult Suaban(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BAN bAN = db.BANs.Find(id);
            if (bAN == null)
            {
                return HttpNotFound();
            }
            return View(bAN);
        }

        // POST: Ban/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suaban([Bind(Include = "MaBan,TenBan,LoaiBan,TrangThai")] BAN bAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Danhsachban");
            }
            return View(bAN);
        }

        // GET: Ban/Delete/5
        public ActionResult Xoaban(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BAN bAN = db.BANs.Find(id);
            if (bAN == null)
            {
                return HttpNotFound();
            }
            return View(bAN);
        }

        // POST: Ban/Delete/5
        [HttpPost, ActionName("Xoaban")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BAN bAN = db.BANs.Find(id);
            db.BANs.Remove(bAN);
            db.SaveChanges();
            return RedirectToAction("Danhsachban");
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
