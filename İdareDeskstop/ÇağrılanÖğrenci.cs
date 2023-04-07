using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İdareDeskstop
{
    internal class ÇağrılanÖğrenci
    {

        public string sınıf { get; set; }
        public string isimSoyisim { get; set; }
        public string çağıranİdareciİsim { get; set; }
        public string çağıranİdareciSoyisim { get; set; }
        public string çağıranİdareciGorev { get; set; }

        public ÇağrılanÖğrenci()
        {
            
        }

        public ÇağrılanÖğrenci(string sınıf, string isimSoyisim, string çağıranİdareciİsim, string çağıranİdareciSoyisim, string çağıranİdareciGorev)
        {
            this.sınıf = sınıf;
            this.isimSoyisim = isimSoyisim;
            this.çağıranİdareciİsim = çağıranİdareciİsim;
            this.çağıranİdareciSoyisim = çağıranİdareciSoyisim;
            this.çağıranİdareciGorev = çağıranİdareciGorev;
        }
    }
}
