using SiparisTakip.Dal.Abstract;
using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfKullaniciRepository : EfGenericRepository<Kullanici>, IKullaniciRepository
    {
        public EfKullaniciRepository():base()
        {
        }
        public Kullanici KullaniciGiris(string kullaniciAdi, string sifre)
        {
            //select * from Kullanici where kullanicikodu=x and sifre=y
            return context.Kullanici.Where(x => x.KullaniciKodu == kullaniciAdi && x.Sifre==sifre).SingleOrDefault();
        }
    }
}
