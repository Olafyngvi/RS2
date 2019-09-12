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

    public class BrojVrataController : BaseController<Model.BrojVrata, object>
    {
        public BrojVrataController(IService<BrojVrata, object> service) : base(service)
        {
        }
    }
}