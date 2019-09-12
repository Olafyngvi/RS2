using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class GradoviUpsertRequest
    {
        [Required(ErrorMessage = "Naziv je obavezno polje !")]
        [MinLength(3, ErrorMessage = "Naziv mora sadržavati više od 3 karaktera !")]
        public string Naziv { get; set; }
    }
}
