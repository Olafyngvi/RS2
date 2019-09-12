using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKuca.WinUI.Izvještaji
{
    public class DioIzvjestaj
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Sifra { get; set; }
        public string Model { get; set; }
        public int BrojProdanih { get; set; } = 0;
    }
}
