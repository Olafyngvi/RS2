using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class ModeliUpsertRequest
    {
        [Required(ErrorMessage = "Naziv je obavezno polje !")]
        [MinLength(1, ErrorMessage = "Naziv mora sadržavati više od 4 karaktera !")]
        public string Naziv { get; set; }
        public int MarkaId { get; set; }
    }
}
