using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            DetaljiNarudzbe = new HashSet<DetaljiNarudzbe>();
        }

        public int NarudzbaId { get; set; }
        public DateTime DatumNarudžbe { get; set; }
        public bool Zavrsena { get; set; }
        public int KlijentId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual ICollection<DetaljiNarudzbe> DetaljiNarudzbe { get; set; }
    }
}
