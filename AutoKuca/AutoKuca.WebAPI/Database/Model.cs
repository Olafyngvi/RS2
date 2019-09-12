using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Model
    {
        public Model()
        {
            Dio = new HashSet<Dio>();
            Vozila = new HashSet<Vozila>();
        }

        public int ModelId { get; set; }
        public string Naziv { get; set; }
        public int MarkaId { get; set; }

        public virtual Marka Marka { get; set; }
        public virtual ICollection<Dio> Dio { get; set; }
        public virtual ICollection<Vozila> Vozila { get; set; }
    }
}
