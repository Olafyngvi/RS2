using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class VozilaPoslovnice
    {
        public int VozilaPoslovniceId { get; set; }
        public DateTime DatumUvoza { get; set; }
        public int VoziloId { get; set; }
        public int PoslovnicaId { get; set; }

        public virtual Poslovnica Poslovnica { get; set; }
        public virtual Vozila Vozilo { get; set; }
    }
}
