using System;
using System.Collections.Generic;

namespace AutoKuca.WebAPI.Database
{
    public partial class Dio
    {
        public Dio()
        {
            DetaljiNarudzbe = new HashSet<DetaljiNarudzbe>();
        }

        public int DioId { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Sifra { get; set; }
        public int Stanje { get; set; }
        public bool IsDeleted { get; set; }
        public int KategorijaId { get; set; }
        public int ModelId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<DetaljiNarudzbe> DetaljiNarudzbe { get; set; }
    }
}
