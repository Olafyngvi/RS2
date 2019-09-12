using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoKuca.MobileApp.Models
{
    public class Narudzba
    {
        public Narudzba()
        {
            this.narudzbaStavke = new List<NarudzbaStavke>();
        }
        public int NarudzbaId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumNarudžbe { get; set; }
        public bool Zavrsena { get; set; }
        public int KlijentId { get; set; }
        public  List<NarudzbaStavke> narudzbaStavke { get; set; }
    }
}
