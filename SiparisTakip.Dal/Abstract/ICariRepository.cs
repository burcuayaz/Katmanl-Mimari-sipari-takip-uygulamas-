using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract
{
    public interface ICariRepository :IGenericRepository<Cari>
    {
        List<Cari> CariHesapEkstresi(int cariId);
    }
}
