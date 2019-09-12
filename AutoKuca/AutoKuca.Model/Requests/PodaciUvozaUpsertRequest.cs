using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model.Requests
{
   public  class PodaciUvozaUpsertRequest
    {
        public DateTime DatumUvoza { get; set; }
        public int VoziloId { get; set; }
        public int PoslovnicaId { get; set; }
    }
}
