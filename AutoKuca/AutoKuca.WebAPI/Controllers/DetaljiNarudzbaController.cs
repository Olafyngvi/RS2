using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class DetaljiNarudzbaController : BaseCRUDController<Model.DetaljiNarudzbe, DetaljiNarudzbaSearchRequest,DetaljiNarudzbeUpsertRequest,DetaljiNarudzbeUpsertRequest>
    {
        public DetaljiNarudzbaController(ICRUDService<DetaljiNarudzbe, DetaljiNarudzbaSearchRequest,DetaljiNarudzbeUpsertRequest,DetaljiNarudzbeUpsertRequest> service) : base(service)
        {
        }
    }
}