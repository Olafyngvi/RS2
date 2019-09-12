using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model
{
   public class Poslovnice
    {
        public int PoslovnicaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public bool Status { get; set; }
        public string StatusS { get; set; }
        public string Grad { get; set; }
        public int GradId { get; set; }
    }
}
