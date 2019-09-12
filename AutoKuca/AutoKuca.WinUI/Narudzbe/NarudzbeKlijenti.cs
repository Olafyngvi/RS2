using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKuca.WinUI.Narudzbe
{
    public class NarudzbeKlijenti
    {
        public int NarudzbaId { get; set; }
        public DateTime DatumNarudžbe { get; set; }
        public bool Zavrsena { get; set; }

        public string Klijent { get; set; }
    }
}
