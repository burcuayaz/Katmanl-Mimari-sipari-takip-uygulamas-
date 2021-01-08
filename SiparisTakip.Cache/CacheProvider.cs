using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Cache
{
    public abstract class CacheProvider
    {
        public static int CacheDuration = 60;//Bellekte ne kadar kalacağını belirler
        public static CacheProvider Instance; //CacheProviderdan bir nesne türettiğimizde Instance içinde tutulur.
        public abstract void Set(string key, object value); //set methodunu cache değer atamak için kullanacağız.
        public abstract object Get(string key);//Keyi göndereceğiz o bize object döndürecek
        public abstract void Remove(string key);//keşten silme gerçekleştirecek
        public abstract bool IsExist(string key); //ilgili arguman keyde var mı yok mu diye kontrol eder

    }
}
