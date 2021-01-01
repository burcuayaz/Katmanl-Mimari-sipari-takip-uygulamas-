using SiparisTakip.Bll;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class StokController : Controller
    {
        IStokService stokService = new StokManager(new EfStokRepository());
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StokListesi()
        {
            var liste = stokService.GetAll();
            return View(liste);
        }
    }
}