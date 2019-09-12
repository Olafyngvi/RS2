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
    public class KlijentController : ControllerBase
    {

        private readonly IKlijentService _service;

        public KlijentController(IKlijentService service)
        {
            _service = service;
        }


        [HttpGet]
        public List<Klijenti> Get([FromQuery]KlijentSearchRequest search)
        {
            var list = _service.Get(search);
            return (list);
        }

        [HttpGet("{id}")]
        public Klijenti GetById(int id)
        {
            return _service.GetById(id);
        }

        [AllowAnonymous]
        [HttpPost]
        public Klijenti Insert(KlijentiUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [AllowAnonymous]
        [HttpPut("id")]
        public Klijenti Update(int id, [FromBody] KlijentiUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [AllowAnonymous]
        [HttpDelete("id")]
        public Klijenti Delete(int id)
        {
            return _service.Delete(id);
        }

   
    }
}