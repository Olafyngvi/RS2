using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class KontaktUpit
    {
        public int KontaktUpitiId { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Poruka { get; set; }

        public DateTime DatumVrijeme { get; set; }
        public bool? Pregledano { get; set; }
    }
}
