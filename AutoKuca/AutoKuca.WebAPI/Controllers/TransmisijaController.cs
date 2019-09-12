using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{

    public class TransmisijaController : BaseController<Model.Transmisija, object>
    {
        public TransmisijaController(IService<Transmisija, object> service) : base(service)
        {
        }
    }
}