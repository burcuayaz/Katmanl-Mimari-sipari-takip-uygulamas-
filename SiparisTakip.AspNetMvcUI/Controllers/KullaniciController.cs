using SiparisTakip.AspNetMvcUI.Models;
using SiparisTakip.Bll;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMvcUI.Controllers
{
    public class KullaniciController : Controller
    {
        IKullaniciService KullaniciService = new KullaniciManager(new EfKullaniciRepository());
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(ViewKullanici kullanici)
        {
            try
            {
                if (ModelState.IsValid)  //Eğer bütün şartlarsağlanmışsa
                {
                   var kul= KullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);
                    if (kul != null)
                    {
                        Session["Kullanici"] = kul;
                        return RedirectToAction("Index", "Anasayfa"); //başarılı şekilde giriş yapıldıysa anasayfaya at
                    }
                }
                else
                {
                    return View(kullanici);
                }

            }
            catch (Exception error)
            {

                ModelState.AddModelError("", error.Message);
                return View(kullanici); //Başarılı şekilde giriş yapılmışsa kullanıcıyı geri döndür
            }
            return View(kullanici); //Hiçbişey Yapılmamışsa
        }

        public ActionResult Listele()
        {
            return View();
        }
        public ActionResult ListelePartial()
        {
            return View(KullaniciService.GetAll());
        }

        public ActionResult Kaydet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(Kullanici kullanici)
        {
            return View(KullaniciService.Add(kullanici));
        }
        public ActionResult Detay(int id)
        {
            return View(KullaniciService.Get(id));
        }
        public ActionResult Duzenle(int id)
        {
            return View(KullaniciService.Get(id));
        }
        [HttpPost]
        public ActionResult Duzenle(Kullanici kullanici)
        {
            return View(KullaniciService.Update(kullanici));
        }
        [HttpPost]
        public ActionResult Sil(int id)
        {
            KullaniciService.Remove(id);
            return View("Listele");
        }
    }
}