using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Entity.PocoModels
{
    //Poco model veritabanında karşılığı olmayan bir model oluşturmaktır
    [NotMapped] // veritabanından bu sınıfı hariç tut demektir
    public class PocoKullanici/*: Kullanici*/
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public byte YetkiID { get; set; }
    }
}
