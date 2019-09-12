using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Oprema
    {
        public Oprema()
        {
            Vozila = new HashSet<Vozila>();
        }

        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
