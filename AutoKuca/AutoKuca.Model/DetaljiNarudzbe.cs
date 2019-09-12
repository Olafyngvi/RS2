using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class DetaljiNarudzbe
    {
        public int DetaljiNarudzbeId { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public int NarudzbaId { get; set; }
        public int DioId { get; set; }
        public string Dio { get; set; }
    }
}
