using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class UpitiVozila
    {
        public int UpitiVozilaId { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string SifraAutomobila { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public bool? Pregledano { get; set; }
        public string Poruka { get; set; }
    }
}
