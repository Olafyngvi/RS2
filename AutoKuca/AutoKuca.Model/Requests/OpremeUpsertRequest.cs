using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
   public class OpremeUpsertRequest
    {
        [Required(ErrorMessage = "Naziv je obavezno polje !")]
        [MinLength(1, ErrorMessage = "Naziv mora sadržavati više od 1 karaktera !")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Opis je obavezno polje !")]
        [MinLength(20, ErrorMessage = "Opis mora sadržavati više od 20 karaktera !")]
        public string Opis { get; set; }
    }
}
