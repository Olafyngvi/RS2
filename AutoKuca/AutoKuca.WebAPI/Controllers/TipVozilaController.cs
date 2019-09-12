using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{

    public class TipVozilaController : BaseCRUDController<TipoviVozila, object, TipoviUpsertRequest, TipoviUpsertRequest>
    {
        public TipVozilaController(ICRUDService<TipoviVozila, object, TipoviUpsertRequest, TipoviUpsertRequest> service) : base(service)
        {
        }
    }
}