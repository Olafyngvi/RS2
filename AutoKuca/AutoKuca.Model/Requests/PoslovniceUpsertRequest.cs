using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
   public class PoslovniceUpsertRequest
    {
        [Required(ErrorMessage = "Naziv je obavezno polje !")]
        [MinLength(4, ErrorMessage = "Naziv mora sadržavati više od 4 karaktera !")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Adresa je obavezno polje !")]
        [MinLength(4, ErrorMessage = "Adresa mora sadržavati više od 4 karaktera !")]
        public string Adresa { get; set; }
        [Required]
        public string Telefon { get; set; }
        public bool Status { get; set; }
        public int GradId { get; set; }
    }
}
