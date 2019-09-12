using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
   public class UpitiAdmin
    {
        public int KontaktUpitiId { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Poruka { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public bool? Pregledano { get; set; }
    }
}
