using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.Model.Requests
{
   public class SlikeUpsertRequest
    {
        public byte[] Slika { get; set; }
        public int? VoziloId { get; set; }
    }
}
