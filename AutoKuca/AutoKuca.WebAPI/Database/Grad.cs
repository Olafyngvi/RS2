using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Korisnik = new HashSet<Korisnik>();
            Poslovnica = new HashSet<Poslovnica>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnik> Korisnik { get; set; }
        public virtual ICollection<Poslovnica> Poslovnica { get; set; }
    }
}
