﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İdareDeskstop
{
    internal class Çağrılanİdareci
    {
        public string çağrılanidarecino { get; set; }
        public string idareciisimsoyisim { get; set; }
        public string çağıranidareciisim { get; set; }
        public string çağıranidarecisoyisim { get; set; }
        public string çağıranidarecigorev { get; set; }
        public string acıklama { get; set; }
        

        public Çağrılanİdareci()
        {
            
        }

        public Çağrılanİdareci(string çağrılanidareno, string idareciisimsoyisim, string çağıranidarecisoyisim, string çağıranidareciisim, string çağıranidarecigorev,string acıklama)
        {
            this.idareciisimsoyisim = idareciisimsoyisim;
            this.çağıranidareciisim = çağıranidareciisim;
            this.çağıranidarecisoyisim = çağıranidarecisoyisim;
            this.çağıranidarecigorev = çağıranidarecigorev;
            this.acıklama = acıklama;
            this.çağrılanidarecino = çağrılanidareno;
        }
    }
}
