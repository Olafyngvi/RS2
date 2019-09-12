using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class VozilaSearchRequest
    {
        public int MarkaId { get; set; }
        public int TipVozilaId { get; set; }
        public int TransmisijaId { get; set; }
        public int Godina { get; set; }
        public bool pocetna { get; set; }
        public bool preporuka { get; set; }
        public bool preporukaTip { get; set; }
        public int voziloId { get; set; }

        public int Sortiraj { get; set; }
    }
}
