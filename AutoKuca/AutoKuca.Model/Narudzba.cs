using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class Narudzba
    {
        public int NarudzbaId { get; set; }
        public DateTime DatumNarudžbe { get; set; }
        public bool Zavrsena { get; set; }
        public int KlijentId { get; set; }
    }
}
