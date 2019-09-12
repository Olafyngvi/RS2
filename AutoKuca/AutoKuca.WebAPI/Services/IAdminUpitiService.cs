using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
   public interface IAdminUpitiService
    {
        List<UpitiAdmin> Get(UpitiVozilaSearchRequest search);
        UpitiAdmin GetById(int id);
        UpitiAdmin Insert(UpitiVozilaUpsertRequest request);

        void Delete(int id);
    }
}
