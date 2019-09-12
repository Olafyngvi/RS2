using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Marka
    {
        public Marka()
        {
            Model = new HashSet<Model>();
        }

        public int MarkaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Model> Model { get; set; }
    }
}
