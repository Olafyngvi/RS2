using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Telefon { get; set; }
        public int GradId { get; set; }
    }
}
