using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Controllers;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
    public class DetaljiNarudzbeService : BaseCRUDService<Model.DetaljiNarudzbe, DetaljiNarudzbaSearchRequest, Database.DetaljiNarudzbe,DetaljiNarudzbeUpsertRequest,DetaljiNarudzbeUpsertRequest>
    {
        public DetaljiNarudzbeService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.DetaljiNarudzbe> Get(DetaljiNarudzbaSearchRequest search)
        {
            List<Model.DetaljiNarudzbe> lista = new List<Model.DetaljiNarudzbe>();
            var query = _db.DetaljiNarudzbe.Include(x=>x.Dio).AsQueryable();
            if (search.NarudzbaId != 0)
            {
                query = query.Where(x => x.NarudzbaId == search.NarudzbaId);
            }
            if (search.DioId != 0)
            {
                query = query.Where(x => x.DioId == search.DioId);
            }
            foreach(var x in query)
            {
                lista.Add(new Model.DetaljiNarudzbe
                {
                    DetaljiNarudzbeId = x.DetaljiNarudzbeId,
                    Kolicina = x.Kolicina,
                    Cijena = x.Cijena,
                    NarudzbaId = x.NarudzbaId,
                    DioId = x.DioId,
                    Dio = x.Dio.Naziv
                });
            }
            return _mapper.Map<List<Model.DetaljiNarudzbe>>(lista);
        }
    }
}
