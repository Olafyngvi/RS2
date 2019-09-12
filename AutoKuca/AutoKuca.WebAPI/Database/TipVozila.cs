using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class TipVozila
    {
        public TipVozila()
        {
            Vozila = new HashSet<Vozila>();
        }

        public int TipVozilaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
