using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Narudzba = new HashSet<Narudzba>();
        }

        public int KlijentId { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public int BrojNarudzbi { get; set; }

        public virtual Korisnik KlijentNavigation { get; set; }
        public virtual ICollection<Narudzba> Narudzba { get; set; }
    }
}
