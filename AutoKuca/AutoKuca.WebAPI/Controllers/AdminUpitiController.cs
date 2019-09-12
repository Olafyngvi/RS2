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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUpitiController : ControllerBase

    {
        private readonly IAdminUpitiService _service;

        public AdminUpitiController(IAdminUpitiService service)
        {
            _service = service;
        }


        [HttpGet]
        public List<Model.UpitiAdmin> Get([FromQuery]UpitiVozilaSearchRequest search)
        {
            var list = _service.Get(search);
            return (list);
        }

        [HttpGet("{id}")]
        public Model.UpitiAdmin GetById(int id)
        {
            return _service.GetById(id);
        }

        [AllowAnonymous]
        [HttpPost]
        public Model.UpitiAdmin Insert(UpitiVozilaUpsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpDelete("id")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}