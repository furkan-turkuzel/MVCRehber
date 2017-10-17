using BLL.Abstract;
using Entities.Entities;
using MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class KisiController : Controller
    {
        private IKisilerService _KisilerBLL;

        public KisiController(IKisilerService KisilerBLL)
        {
            _KisilerBLL = KisilerBLL;
        }

        [HttpGet]
        public ActionResult YeniKisi()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniKisi(KisiModelView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Kisiler kisi = model.kisiler;
                    _KisilerBLL.Add(kisi);
                }
                catch (Exception)
                {
                }
            }

            return Redirect("/Home/Index");
        }

        public ActionResult KisiDuzenle(int ID)
        {
            KisiModelView kisi = new KisiModelView();

            if (ID != 0)
            {
                kisi.kisiler = _KisilerBLL.Get(ID);
            }

            return View(kisi);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KisiDuzenle(KisiModelView model)
        {
            if (model.kisiler.ID != 0)
            {
                try
                {
                    Kisiler kisi = _KisilerBLL.Get(model.kisiler.ID);
                    kisi.Ad = model.kisiler.Ad;
                    kisi.Soyad = model.kisiler.Soyad;
                    kisi.Yas = model.kisiler.Yas;

                    _KisilerBLL.Update(kisi);
                }
                catch (Exception)
                {
                }
            }

            return Redirect("/Home/Index");
        }

        public ActionResult KisiSil(int ID)
        {
            KisiModelView kisi = new KisiModelView();

            if (ID != 0)
            {
                try
                {
                   kisi.kisiler = _KisilerBLL.Get(ID); 
                }
                catch (Exception)
                {
                }
            }
            return View(kisi);
        }


        [HttpPost]
        [ValidateAntiForgeryToken,ActionName("KisiSil")]
        public ActionResult SilelimMi(int ID)
        {
            if (ID != 0)
            {
                try
                {
                    Kisiler kisi = _KisilerBLL.Get(ID);
                    _KisilerBLL.Delete(kisi);
                    return Redirect("/Home/Index");
                }
                catch (Exception)
                {
                    ViewBag.Result = "Kişi silinemedi";
                    ViewBag.Status = "Danger";  
                }
            }
            return Redirect("/Kisi/KisiSil"); 
        }
    }
}