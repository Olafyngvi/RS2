using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class BrojVrata
    {
        public BrojVrata()
        {
            Vozila = new HashSet<Vozila>();
        }

        public int BrojVrataId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
