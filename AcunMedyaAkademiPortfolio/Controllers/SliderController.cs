using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class SliderController : Controller
    {
        DbProductAcunMedyaEntities1 db = new DbProductAcunMedyaEntities1();
        // GET: Slider
        public ActionResult Index()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSlider(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSlider(int id)
        {
            var value = db.TblFeature.Find(id);
            db.TblFeature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSlider(TblFeature p)
        {
            var value = db.TblFeature.Find(p.FeatureId);
            value.FeatureTitle = p.FeatureTitle;
            value.FeatureDesc = p.FeatureDesc;
            value.FeatureImg = p.FeatureImg;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}