using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
   public interface IUpitiVozilaService
    {
        List<UpitiVozila> Get(UpitiVozilaSearchRequest search);
        UpitiVozila GetById(int id);
        UpitiVozila Insert(UpitiVozilaUpsertRequest request);

        void Delete(int id);
    }
}
