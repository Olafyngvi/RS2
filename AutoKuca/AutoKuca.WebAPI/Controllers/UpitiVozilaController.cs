using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoKuca.WebAPI.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UpitiVozilaController : ControllerBase {

        private readonly IUpitiVozilaService _service;

        public UpitiVozilaController(IUpitiVozilaService service)
        {
            _service = service;
        }


        [HttpGet]
        public List<Model.UpitiVozila> Get([FromQuery]UpitiVozilaSearchRequest search)
        {
            var list = _service.Get(search);
            return (list);
        }

        [HttpGet("{id}")]
        public Model.UpitiVozila GetById(int id)
        {
            return _service.GetById(id);
        }

        [AllowAnonymous]
        [HttpPost]
        public Model.UpitiVozila Insert(UpitiVozilaUpsertRequest request)
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
    
