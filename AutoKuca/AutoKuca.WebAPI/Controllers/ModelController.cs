using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using AutoKuca.WebAPI.Services;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using Microsoft.AspNetCore.Authorization;

namespace AutoKuca.WebAPI.Controllers
{

    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : BaseCRUDController<Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest>
    {
        public ModelController(ICRUDService<Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest> service) : base(service)
        {
        }
    }
}