using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Uposlenik
    {
        public int UposlenikId { get; set; }
        public DateTime DatumZaposljavanja { get; set; }
        public string Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Status { get; set; }
        public int VrstaId { get; set; }
        public int PoslovnicaId { get; set; }

        public virtual Poslovnica Poslovnica { get; set; }
        public virtual Korisnik UposlenikNavigation { get; set; }
        public virtual VrstaUposlenika Vrsta { get; set; }
    }
}
