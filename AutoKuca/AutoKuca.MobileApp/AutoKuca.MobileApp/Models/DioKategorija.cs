using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.MobileApp.Models
{
    public class DioKategorija
    {
        public int DioId { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Sifra { get; set; }
        public int KategorijaId { get; set; }
        public int ModelId { get; set; }
        public string Model { get; set; }
        public byte[] Slika { get; set; }
    }
}
