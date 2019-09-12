using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
  public  interface IKlijentService
    {
        List<Klijenti> Get(KlijentSearchRequest search);
        Klijenti GetById(int id);
        Klijenti Insert(KlijentiUpsertRequest request);

        Klijenti Update(int id, KlijentiUpsertRequest request);

        Klijenti Delete(int id);
    }
}
