using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İdareDeskstop
{
    internal class ÇağrılanÖğretmen
    {
        public string çağrılmano { get; set; }
        public string isimSoyisim { get; set; }
        public string çağıranİdareciİsim { get; set; }
        public string çağıranİdareciSoyisim { get; set; }
        public string çağıranİdareciGorev { get; set; }
        public string acıklama { get; set; }

        public ÇağrılanÖğretmen()
        {

        }

        public ÇağrılanÖğretmen(string çağrılmano, string isimSoyisim, string çağıranİdareciİsim, string çağıranİdareciSoyisim, string çağıranİdareciGorev, string acıklama)
        {
            this.çağrılmano = çağrılmano;
            this.isimSoyisim = isimSoyisim;
            this.çağıranİdareciİsim = çağıranİdareciİsim;
            this.çağıranİdareciSoyisim = çağıranİdareciSoyisim;
            this.çağıranİdareciGorev = çağıranİdareciGorev;
            this.acıklama = acıklama;
        }




    }
}
