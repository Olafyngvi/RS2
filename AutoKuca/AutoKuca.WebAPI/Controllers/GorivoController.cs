using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{

    public class GorivoController : BaseController<Model.Goriva, object>
    {
        public GorivoController(Services.IService<Model.Goriva, object> service) : base(service)
        {

        }
    }
}