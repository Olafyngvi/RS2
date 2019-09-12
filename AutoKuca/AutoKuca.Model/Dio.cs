using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class Dio
    {
        public int DioId { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Sifra { get; set; }
        public int Stanje { get; set; }
        public int KategorijaId { get; set; }
        public string Kategorija { get; set; }
        public int ModelId { get; set; }
        public string Model { get; set; }
    }
}
