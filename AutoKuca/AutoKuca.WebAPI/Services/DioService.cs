using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
    public class DioService : BaseCRUDService<Model.Dio, DioSearchRequest, Database.Dio, DioUpsertRequest, DioUpsertRequest>
    {
        public DioService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Dio> Get(DioSearchRequest search)
        {
            List < Model.Dio >  lista = new List<Model.Dio>();
            var query = _db.Dio.Include(x=>x.Kategorija).Include(x=>x.Model).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv) || x.Sifra.Contains(search.Naziv));
            }
            if (search.ModelId != 0)
            {
                query = query.Where(x => x.ModelId == search.ModelId);
            }
            if (search.KategorijaId != 0)
            {
                query = query.Where(x => x.KategorijaId == search.KategorijaId);
            }
            foreach(var x in query)
            {
                lista.Add(new Model.Dio
                {
                    DioId=x.DioId,
                    Naziv=x.Naziv,
                    Cijena = x.Cijena,
                    Sifra = x.Sifra,
                    Stanje = x.Stanje,
                    Kategorija = x.Kategorija.Naziv,
                    KategorijaId=x.KategorijaId,
                    Model = x.Model.Naziv,
                    ModelId = x.ModelId
                });
            }
            return _mapper.Map<List<Model.Dio>>(lista);
        }
    }
}
