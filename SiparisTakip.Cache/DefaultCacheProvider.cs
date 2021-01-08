using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Diagnostics;

namespace SiparisTakip.Cache
{
    public class DefaultCacheProvider : CacheProvider
    {
        ObjectCache _cache; //cache metodlarıyla işlem yapacağımız sınıf
        CacheItemPolicy _policy; //keşle ilgili özellikleri tutuyor.

        public DefaultCacheProvider()
        {
            Trace.WriteLine("Cache başlatıldı");//Loglama için kullanılır outputa çıktı verir.
          //  Debug.WriteLine("");//Loglama yapmak için debug da yapabiliriz.
            _cache = MemoryCache.Default;

            _policy = new CacheItemPolicy//bu kod bloğuna policy nitelikleri yazılır
            {
                Priority = CacheItemPriority.NotRemovable,   //Öncelik belirtir, notremovable ben silene kadar silinmesin demektir.
               // AbsoluteExpiration = DateTime.Now.AddHours(1),//oluştuktan bir saat sonra silinsin
               //RemovedCallback=new CacheEntryRemovedCallback(RemovedCallback)//cache yıkıldığında çalışır.
                RemovedCallback = RemovedCallback

            };
        }

        private void RemovedCallback(CacheEntryRemovedArguments arguments)
        {
            Trace.WriteLine("-------Cache Yıkıldı------");
            Trace.WriteLine("Key:" + arguments.CacheItem.Key);
            Trace.WriteLine("Value:" + arguments.CacheItem.Value);
            Trace.WriteLine("RemovedReason" + arguments.RemovedReason);
        }

     
        public override object Get(string key)
        {
            object item;
            try
            {
               item=  _cache.Get(key);

                if (item == null)
                {
                    Trace.WriteLine("Cache getirilemedi");
                    throw new Exception("Cache getirilemedi");
                }
            }
            catch (Exception error)
            {

                item = null;
                Trace.WriteLine("Cache get() Hata oluştu" +error.Message);
                throw new Exception("Cache get() Sırasında hata oluştu", error);
            }
            return item;
        }

        public override bool IsExist(string key)
        {
            throw new NotImplementedException();
        }

        public override void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public override void Set(string key, object value)
        {
            _cache.Set(key, value, _policy);
        }
    }
}
