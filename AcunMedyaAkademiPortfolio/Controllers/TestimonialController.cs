using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class TestimonialController : Controller
    {

        DbProductAcunMedyaEntities1 db=new DbProductAcunMedyaEntities1();
        public ActionResult Index()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p)
        {
            if (Request.Files.Count > 0) {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string fileExtension = Path.GetExtension(Request.Files[0].FileName);
                string filePath = "~/Images/" + fileName;
                Request.Files[0].SaveAs(Server.MapPath(filePath));                 
                p.TestimonialImg = "/Images/" + fileName;
            }
            db.TblTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial p)
        {
            var value = db.TblTestimonial.Find(p.TestimonialId);
            value.TestimonialDescription = p.TestimonialDescription;
            value.TestimonialImg = value.TestimonialImg;
            value.TestimonialName = p.TestimonialName;
            value.TestimonialTitle = p.TestimonialTitle;
            value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}