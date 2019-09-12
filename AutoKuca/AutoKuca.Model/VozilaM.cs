using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class VozilaM
    {
        public int VoziloId { get; set; }


        public double Cijena { get; set; }

        public string SifraAutomobila { get; set; }

        public string Oprema { get; set; }
        public string OpremaOpis { get; set; }
        public string Transmisija { get; set; }

        public string BrojVrata { get; set; }

        public string TipVozila { get; set; }

        public string Model { get; set; }
        public string Marka { get; set; }
        public string Gorivo { get; set; }

        public string PoslovnicaNaziv { get; set; }
        public DateTime DatumUvoza {get;set;}

        public byte[] Slika { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public string Kilometraza { get; set; }
        public string Kubikaza { get; set; }
        public string SnagaMotora { get; set; }
        public bool Status { get; set; }
        public int BrojPregleda { get; set; }
        public int TransmisijaId { get; set; }
        public int BrojVrataId { get; set; }
        public int TipVozilaId { get; set; }
        public int OpremaId { get; set; }
        public int GorivoId { get; set; }
        public int ModelId { get; set; }
        public int PoslovnicaId { get; set; }
    }
}
