using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class DioUpsertRequest
    {
        public int DioId { get; set; }
        [Required(ErrorMessage ="Naziv je obavezno polje !")]
        [StringLength(30,MinimumLength =3,ErrorMessage = "Naziv mora sadržavati barem 3 karaktera, ne više od 30 !")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Cijena je obavezno polje !")]
        [Range(1,3000,ErrorMessage ="Cijena mora biti u intervalu od 1 do 3000 !")]
        [DataType(DataType.Currency,ErrorMessage = "Cijena nije unešena u ispravnom formatu !")]
        public double Cijena { get; set; }
        [Required(ErrorMessage = "Šifra je obavezno polje !")]
        [StringLength(5,MinimumLength =4,ErrorMessage = "Šifra mora sadržavati od 4 do 5 karaktera !")]
        public string Sifra { get; set; }
        [Required(ErrorMessage = "Stanje je obavezno polje !")]
        [Range(1,100,ErrorMessage = "Stanje mora biti u intervalu od 1 do 100 !")]
        public int Stanje { get; set; }
        public int KategorijaId { get; set; }
        public int ModelId { get; set; }
    }
}
