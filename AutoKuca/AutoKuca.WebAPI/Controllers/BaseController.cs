﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,TSearch> : ControllerBase
    {
        private readonly IService<T,TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }



        [HttpGet]
        [AllowAnonymous]
        public List<T> Get([FromQuery]TSearch search)
        {
           
                var list = _service.Get(search);
                return (list);

        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}