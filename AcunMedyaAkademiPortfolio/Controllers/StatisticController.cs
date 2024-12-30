using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbProductAcunMedyaEntities1 db=new DbProductAcunMedyaEntities1();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            return View();
        }
    }
}