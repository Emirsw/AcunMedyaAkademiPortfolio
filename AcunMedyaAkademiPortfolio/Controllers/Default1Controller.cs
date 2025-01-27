using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;
using Newtonsoft.Json.Linq;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class Default1Controller : Controller
    {
        DbProductAcunMedyaEntities1 db = new DbProductAcunMedyaEntities1();
        // GET: Default1
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult Navbar()
        {
            return PartialView();
        }

        public PartialViewResult Slider()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }

        public PartialViewResult Counter()
        {
            var skillcount = db.TblSkill.ToList().Count();
            ViewBag.SkillCount = skillcount;
            return PartialView();
        }

        public PartialViewResult About()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult Skills()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult Services()
        {

            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult Projects()
        {

            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult Testimonial()
        {

            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult Banner()
        {
            return PartialView();
        }

        public PartialViewResult Contact()
        {
            return PartialView();
        }


        [HttpPost]
        public ActionResult Contact(TblContact contact)
        {

            contact.CreateDate = DateTime.Now;
            db.TblContact.Add(contact);
            db.SaveChanges();

            return RedirectToAction("Index"); 
        }


        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}