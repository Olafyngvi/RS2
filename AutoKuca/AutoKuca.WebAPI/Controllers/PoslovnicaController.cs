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

    public class PoslovnicaController : BaseCRUDController<Model.Poslovnice, object, PoslovniceUpsertRequest, PoslovniceUpsertRequest>
    {
        public PoslovnicaController(ICRUDService<Poslovnice, object, PoslovniceUpsertRequest, PoslovniceUpsertRequest> service) : base(service)
        {
        }
    }
}