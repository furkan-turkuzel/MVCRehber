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
    public class AdresController : Controller
    {
        private IAdreslerService _AdreslerBLL;
        private IKisilerService _KisilerBLL;

        public AdresController(IAdreslerService AdreslerBLL, IKisilerService KisilerBLL)
        {
            _AdreslerBLL = AdreslerBLL;
            _KisilerBLL = KisilerBLL;
        }

        public ActionResult YeniAdres()
        {
            var kisiler = _KisilerBLL.GetAll();

            List<SelectListItem> kisilerList = (from k in kisiler
                                                select new SelectListItem
                                                {
                                                    Text = k.Ad + " " + k.Soyad,
                                                    Value = k.ID.ToString()
                                                }).ToList();

            ViewBag.kisiler = kisilerList;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniAdres(AdresModelView model)
        {
            model.adresler.Kisiler = _KisilerBLL.Get(model.adresler.Kisiler.ID);
            _AdreslerBLL.Add(model.adresler);
            return Redirect("/Home/Index");
        }

        public ActionResult AdresDuzenle(int ID)
        {
            AdresModelView model = new AdresModelView();

            if (ID != 0)
            {
                var kisiler = _KisilerBLL.GetAll();

                List<SelectListItem> kisilerList = (from k in kisiler
                                                    select new SelectListItem
                                                    {
                                                        Text = k.Ad + " " + k.Soyad,
                                                        Value = k.ID.ToString()
                                                    }).ToList();

                ViewBag.kisiler = kisilerList;
                model.adresler = _AdreslerBLL.Get(ID);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdresDuzenle(AdresModelView model)
        {
            if (model.adresler.ID != 0)
            {
                try
                {
                    Adresler adres = _AdreslerBLL.Get(model.adresler.ID);
                    Kisiler kisi = _KisilerBLL.Get(model.adresler.KisiID);
                    adres.AdresTanim = model.adresler.AdresTanim;
                    adres.Kisiler = kisi;

                    _AdreslerBLL.Update(adres);
                }
                catch (Exception)
                {
                }
            }
            return Redirect("/Home/Index");
        }

        public ActionResult AdresSil(int ID)
        {
            AdresModelView model = new AdresModelView();

            if (ID != 0)
            {
                model.adresler = _AdreslerBLL.Get(ID);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken,ActionName("AdresSil")]
        public ActionResult SilelimMi(int ID)
        {
            if (ID != 0)
            {
                Adresler adres = _AdreslerBLL.Get(ID);
                _AdreslerBLL.Delete(adres);
            }

            return Redirect("/Home/Index");
        }

    }
}