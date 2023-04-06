using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İdareDeskstop
{
    internal class İdareciler
    {

        public int idaresirano { get; set; }
        public string idareisim { get; set; }
        public string idaresoyisim { get; set; }
        public string görev { get; set; }
        public int idaredogumtarihi { get; set; }


        public İdareciler(int sirano, string isim, string soyisim, string görev,int idaredogumtarihi)
        {
            this.idaresirano = sirano;
            this.idareisim = isim;
            this.idaresoyisim = soyisim;
            this.görev = görev;
            this.idaredogumtarihi = idaredogumtarihi;
        }
    }
}
