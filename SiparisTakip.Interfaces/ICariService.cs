using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces
{
    public interface ICariService : IGenericService<Cari>
    {
        List<Cari> CariHesapEkstresi(int cariId);
    }
}
