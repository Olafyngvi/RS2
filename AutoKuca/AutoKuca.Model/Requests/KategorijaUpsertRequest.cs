using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class KategorijaUpsertRequest
    {
        [Required(ErrorMessage = "Naziv je obavezno polje !")]
        [MinLength(4, ErrorMessage = "Naziv mora sadržavati više od 4 karaktera !")]
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
    }
}
