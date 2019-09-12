using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class PodaciUvoza
    {
        public int VozilaPoslovniceId { get; set; }
        public DateTime DatumUvoza { get; set; }
        public int VoziloId { get; set; }

        public string Sifra { get; set; }
        public int PoslovnicaId { get; set; }

       public string Poslovnica { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }

    }
}
