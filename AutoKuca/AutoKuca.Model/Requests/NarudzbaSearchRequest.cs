using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class NarudzbaSearchRequest
    {
        public DateTime DatumNarudžbe { get; set; }
        public bool Zavrsena { get; set; }
        public int KlijentId { get; set; }
    }
}
