using SiparisTakip.Dal.Abstract;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll
{
    public class CariManager : GenericManager<Cari>, ICariService
    {
        ICariRepository cariRepository;

        public CariManager(ICariRepository cariRepository):base(cariRepository)
        {
            this.cariRepository = cariRepository;
        }

        public List<Cari> CariHesapEkstresi(int cariId)
        {
            return cariRepository.CariHesapEkstresi(cariId);
        }
    }
}
