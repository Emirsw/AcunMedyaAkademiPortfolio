using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbProductAcunMedyaEntities1 db = new DbProductAcunMedyaEntities1();

        // GET: About
        public ActionResult Index(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Index(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutId);
            value.AboutDesc = p.AboutDesc;
            db.SaveChanges();
            return RedirectToAction("/Index/1");
        }

    }
}