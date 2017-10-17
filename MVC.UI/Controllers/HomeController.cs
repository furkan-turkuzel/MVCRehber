using BLL.Abstract;
using BLL.Concrete;
using MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IKisilerService _KisilerService;
        private readonly IAdreslerService _AdreslerService;

        public HomeController(IKisilerService KisilerService, IAdreslerService AdreslerService)
        {
            _KisilerService = KisilerService;
            _AdreslerService = AdreslerService;
        }

        public ActionResult Index()
        {
            KisiAdresModelView model = new KisiAdresModelView
            {
                Kisiler = _KisilerService.GetAll().ToList(),
                Adresler =_AdreslerService.GetAll().ToList()
            };

            return View(model);
        }

     
    }
}