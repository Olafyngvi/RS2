﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoKuca.WebAPI.Controllers
{

    public class UposlenikController : BaseCRUDController<Model.Uposlenici, UposleniciSearchRequest, UposleniciUpsertRequest, UposleniciUpsertRequest>
    {

        public UposlenikController(ICRUDService<Uposlenici, UposleniciSearchRequest, UposleniciUpsertRequest, UposleniciUpsertRequest> service) : base(service)
        {
        }
    }
}