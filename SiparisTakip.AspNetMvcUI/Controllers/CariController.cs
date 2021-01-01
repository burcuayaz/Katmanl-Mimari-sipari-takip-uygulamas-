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
    public class CariController : Controller
    {
        ICariService cariService = new CariManager(new EfCariRepository());
        public ActionResult Index()
        {
            return View(cariService.GetAll(x => x.CariID >0));
        }
    }
}