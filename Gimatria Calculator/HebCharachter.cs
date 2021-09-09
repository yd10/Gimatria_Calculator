using System;
using System.Collections.Generic;
using System.Text;

namespace Gimatria
{
   public class HebCharachter 
    {
        public HebCharachter(int misparGadol, int misparKatan)
        {
            this.MisparGadol = misparGadol;
            this.MisparKatan = misparKatan;
        }

        // typical way of Gimatria (Mispar Gadol)
        public int MisparGadol { get; set; }

        // Reduced value, Mispar Katan, alef equals 1, yud equals 10, kuf equals 100) would all have a numerical value of 1
        public int MisparKatan { get; set; }
    }

}
