using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Gorivo
    {
        public Gorivo()
        {
            Vozila = new HashSet<Vozila>();
        }

        public int GorivoId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
