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

    public class VrstaUposlenikaController : BaseController<Model.VrsteUposlenika, object>
    {
        public VrstaUposlenikaController(IService<VrsteUposlenika, object> service) : base(service)
        {
        }
    }
}