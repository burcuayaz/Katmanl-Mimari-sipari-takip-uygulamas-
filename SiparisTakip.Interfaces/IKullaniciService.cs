using SiparisTakip.Entity.Models;
using SiparisTakip.Entity.PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    [ServiceContract] // Bu sınıf web servise çıkabilir izni verir
    public  interface IKullaniciService: IGenericService<Kullanici>
    {
        //Kullanıcıdan istenecek değerleri belirliyoruz
        [OperationContract] //burada da hangi sınıfın çıkacağını bilirttik
        PocoKullanici KullaniciGiris(string kullaniciAdi, string parola);
    }
}
