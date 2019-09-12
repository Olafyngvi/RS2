using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
   public class VozilaUpsertRequest
    {
        [Required(ErrorMessage = "Datum proizvodnje je obavezno polje !")]
        [DataType(DataType.Date)]
        public DateTime DatumProizvodnje { get; set; }
        [Required(ErrorMessage = "Kilometraza je obavezno polje !")]
        [Range(1,1000000)]
        public string Kilometraza { get; set; }
        [Required(ErrorMessage = "Kubikaža je obavezno polje !")]
        [Range(1, 10000)]
        public string Kubikaza { get; set; }
        [Required(ErrorMessage = "Snaga motora je obavezno polje !")]
        [Range(1, 1000)]
        public string SnagaMotora { get; set; }
        [Required(ErrorMessage = "Cijena je obavezno polje !")]
        [Range(1, 150000, ErrorMessage = "Cijena mora biti u intervalu od 1 do 150 000 !")]
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

        public int PoslovnicaId { get; set; }
        public DateTime DatumUvoza { get; set; }



    }
}
