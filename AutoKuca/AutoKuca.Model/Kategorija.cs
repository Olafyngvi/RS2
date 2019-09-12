using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class Kategorija
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
    }
}
