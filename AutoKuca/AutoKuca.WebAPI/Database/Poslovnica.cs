using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Poslovnica
    {
        public Poslovnica()
        {
            Uposlenik = new HashSet<Uposlenik>();
            VozilaPoslovnice = new HashSet<VozilaPoslovnice>();
        }

        public int PoslovnicaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public bool Status { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
        public virtual ICollection<VozilaPoslovnice> VozilaPoslovnice { get; set; }
    }
}
