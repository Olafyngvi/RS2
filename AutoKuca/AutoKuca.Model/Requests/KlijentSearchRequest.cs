using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model.Requests
{
    public class KlijentSearchRequest
    {
        public string Param { get; set; }
        public string Korisnicko { get; set; }

        public string Password { get; set; }
    }
}
