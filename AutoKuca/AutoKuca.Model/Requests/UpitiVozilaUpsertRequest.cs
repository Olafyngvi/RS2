using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
   public class UpitiVozilaUpsertRequest
    {
        [Required(ErrorMessage = "Ime i prezime je obavezno polje !")]
        [MinLength(5, ErrorMessage = "Ime i prezime mora sadržavati više od 5 karaktera !")]
        public string ImePrezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string SifraAutomobila { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public bool? Pregledano { get; set; }
        public string Poruka { get; set; }
    }
}
