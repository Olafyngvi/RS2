using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.WebAPI.Database;
using AutoKuca.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoKuca.WebAPI.Services;

namespace AutoKuca.WebAPI.Controllers
{
    public class KategorijaController : BaseCRUDController<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest>
    {
        public KategorijaController(ICRUDService<Model.Kategorija, object, KategorijaUpsertRequest, KategorijaUpsertRequest> service) : base(service)
        {
        }
    }
}