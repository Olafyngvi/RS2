using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Dio = new HashSet<Dio>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Dio> Dio { get; set; }
    }
}
