using SiparisTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Interfaces //Stokla alakalı kodlar burda yazılır
{
    public interface IStokService :IGenericService<Stok>
    {
        List<Stok> StokListele(int stokGrubuId);

    }
}
