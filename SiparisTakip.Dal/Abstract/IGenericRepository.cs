using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract
{
    public interface IGenericRepository<T> where T: class
    {
        T Add(T entity);
        T Get(int id);
        List<T> GetAll(); //Hepsini listele
        List<T> GetAll(Expression<Func<T, bool>> predicate); //ne verirsem onu listele linq sorgusu gibi düşün.
        bool Remove(int id); //id'ye göre sil true veya false döndür.
        bool Remove(T entity);
        T Update(T entity);
      //  int Dispose(); //Nesneyi öldürmek için kullanılır

    }
}
