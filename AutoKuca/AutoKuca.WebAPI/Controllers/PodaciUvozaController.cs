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

    public class PodaciUvozaController : BaseCRUDController<Model.PodaciUvoza, PodaciUvozaSearchRequest, PodaciUvozaUpsertRequest, PodaciUvozaUpsertRequest>
    {
        public PodaciUvozaController(ICRUDService<PodaciUvoza, PodaciUvozaSearchRequest, PodaciUvozaUpsertRequest, PodaciUvozaUpsertRequest> service) : base(service)
        {
        }
    }
}