﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MembersIacv.Models;

namespace MembersIacv.Controllers
{
    public class MemberController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Member
        public ActionResult Index()
        {
            var memberViewModels = db.MemberViewModels.Include(m => m.EcclesiasticalFunction).Include(m => m.MartialStatus).Include(m => m.State);
            return View(memberViewModels.ToList());
        }

        // GET: Member/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberViewModel memberViewModel = db.MemberViewModels.Find(id);
            if (memberViewModel == null)
            {
                return HttpNotFound();
            }
            return View(memberViewModel);
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            ViewBag.EcclesiasticalFunctionId = new SelectList(db.EcclesiasticalFunctions, "EcclesiasticalFunctionId", "Description");
            ViewBag.MartialStatusId = new SelectList(db.MartialStatus, "MartialStatusId", "Description");
            ViewBag.StateId = new SelectList(db.States, "StateId", "Description");
            return View();
        }

        // POST: Member/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,BirthDay,NaturalOf,MartialStatusId,Spouse,MarriageDate,Father,Mother,HomePhone,Mobile,Email,Address,District,Ciy,StateId,Zip,Profession,Education,Workplace,WorkPhone,Cpf,Rg,Nationality,BloodType,BaptismDate,EcclesiasticalFunctionId")] MemberViewModel memberViewModel)
        {
            if (ModelState.IsValid)
            {
                db.MemberViewModels.Add(memberViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EcclesiasticalFunctionId = new SelectList(db.EcclesiasticalFunctions, "EcclesiasticalFunctionId", "Description", memberViewModel.EcclesiasticalFunctionId);
            ViewBag.MartialStatusId = new SelectList(db.MartialStatus, "MartialStatusId", "Description", memberViewModel.MartialStatusId);
            ViewBag.StateId = new SelectList(db.States, "StateId", "Description", memberViewModel.StateId);
            return View(memberViewModel);
        }

        // GET: Member/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberViewModel memberViewModel = db.MemberViewModels.Find(id);
            if (memberViewModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.EcclesiasticalFunctionId = new SelectList(db.EcclesiasticalFunctions, "EcclesiasticalFunctionId", "Description", memberViewModel.EcclesiasticalFunctionId);
            ViewBag.MartialStatusId = new SelectList(db.MartialStatus, "MartialStatusId", "Description", memberViewModel.MartialStatusId);
            ViewBag.StateId = new SelectList(db.States, "StateId", "Description", memberViewModel.StateId);
            return View(memberViewModel);
        }

        // POST: Member/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,BirthDay,NaturalOf,MartialStatusId,Spouse,MarriageDate,Father,Mother,HomePhone,Mobile,Email,Address,District,Ciy,StateId,Zip,Profession,Education,Workplace,WorkPhone,Cpf,Rg,Nationality,BloodType,BaptismDate,EcclesiasticalFunctionId")] MemberViewModel memberViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(memberViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EcclesiasticalFunctionId = new SelectList(db.EcclesiasticalFunctions, "EcclesiasticalFunctionId", "Description", memberViewModel.EcclesiasticalFunctionId);
            ViewBag.MartialStatusId = new SelectList(db.MartialStatus, "MartialStatusId", "Description", memberViewModel.MartialStatusId);
            ViewBag.StateId = new SelectList(db.States, "StateId", "Description", memberViewModel.StateId);
            return View(memberViewModel);
        }

        // GET: Member/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberViewModel memberViewModel = db.MemberViewModels.Find(id);
            if (memberViewModel == null)
            {
                return HttpNotFound();
            }
            return View(memberViewModel);
        }

        // POST: Member/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MemberViewModel memberViewModel = db.MemberViewModels.Find(id);
            db.MemberViewModels.Remove(memberViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
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
