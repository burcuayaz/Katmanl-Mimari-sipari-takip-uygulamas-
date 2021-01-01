using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract //Spesifik sorgular burda yazılacak...
{
    public interface IStokRepository:IGenericRepository<Stok>
    {
        List<Stok> StokListele(int stokGrubuId);
    }
}
