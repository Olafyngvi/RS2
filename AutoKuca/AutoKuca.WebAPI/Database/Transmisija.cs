using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Transmisija
    {
        public Transmisija()
        {
            Vozila = new HashSet<Vozila>();
        }

        public int TransmisijaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
