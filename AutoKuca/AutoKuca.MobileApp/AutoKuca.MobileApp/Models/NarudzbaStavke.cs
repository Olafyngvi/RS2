using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.MobileApp.Models
{
    public class NarudzbaStavke
    {
        public int DetaljiNarudzbeId { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public int NarudzbaId { get; set; }
        public int DioId { get; set; }
        public string Dio { get; set; }
        public string Model { get; set; }
        public byte[] Slika { get; set; }
    }
}
