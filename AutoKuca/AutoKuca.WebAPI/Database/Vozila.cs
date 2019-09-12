using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Vozila
    {
        public Vozila()
        {
            SlikeVozila = new HashSet<SlikeVozila>();
            VozilaPoslovnice = new HashSet<VozilaPoslovnice>();
        }

        public int VoziloId { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public string Kilometraza { get; set; }
        public string Kubikaza { get; set; }
        public string SnagaMotora { get; set; }
        public double Cijena { get; set; }
        public bool Status { get; set; }
        public string SifraAutomobila { get; set; }
        public int BrojPregleda { get; set; }
        public int TransmisijaId { get; set; }
        public int BrojVrataId { get; set; }
        public int TipVozilaId { get; set; }
        public int OpremaId { get; set; }
        public int GorivoId { get; set; }
        public int ModelId { get; set; }

        public virtual BrojVrata BrojVrata { get; set; }
        public virtual Gorivo Gorivo { get; set; }
        public virtual Model Model { get; set; }
        public virtual Oprema Oprema { get; set; }
        public virtual TipVozila TipVozila { get; set; }
        public virtual Transmisija Transmisija { get; set; }
        public virtual ICollection<SlikeVozila> SlikeVozila { get; set; }
        public virtual ICollection<VozilaPoslovnice> VozilaPoslovnice { get; set; }
    }
}
