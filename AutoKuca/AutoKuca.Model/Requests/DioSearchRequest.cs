using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class DioSearchRequest
    {
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public int KategorijaId { get; set; }
        public int ModelId { get; set; }
    }
}
