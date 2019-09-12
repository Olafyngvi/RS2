using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
    public class Slike
    {
        public int SlikaId { get; set; }
        public byte[] Slika { get; set; }
        public int VoziloId { get; set; }
    }
}
