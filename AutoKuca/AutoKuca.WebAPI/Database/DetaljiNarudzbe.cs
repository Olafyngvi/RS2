using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class DetaljiNarudzbe
    {
        public int DetaljiNarudzbeId { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public int NarudzbaId { get; set; }
        public int DioId { get; set; }

        public virtual Dio Dio { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}
