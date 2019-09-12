using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class SlikeVozila
    {
        public int SlikaId { get; set; }
        public byte[] Slika { get; set; }
        public int VoziloId { get; set; }

        public virtual Vozila Vozilo { get; set; }
    }
}
