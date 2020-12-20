using SiparisTakip.Dal.Abstract;
using SiparisTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfStokRepository : EfGenericRepository<Stok>, IStokRepository
    {
        public List<Stok> StokListele()
        {
            throw new NotImplementedException();
        }
    }
}
