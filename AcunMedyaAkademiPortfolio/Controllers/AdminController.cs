using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class AdminController : Controller
    {
        DbProductAcunMedyaEntities1 db = new DbProductAcunMedyaEntities1();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.serviceCount = db.TblHobby.Count();
            ViewBag.categoryCount = db.TblProject.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.message = db.TblContact.Count();
            return View();
        }
    }
}