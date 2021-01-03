using SiparisTakip.Dal.Abstract;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfStokRepository : EfGenericRepository<Stok>, IStokRepository
    {
        public EfStokRepository(): base() // constructure metod
        {
           
        }
        public List<Stok> StokListele(int stokGrubuId)
        {
            return context.Stok.Where(x => x.StokGrubuID == stokGrubuId).ToList();
        }
    }
}
