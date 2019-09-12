using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
    public class GradoviService : BaseCRUDService<Model.Gradovi, GradoviSearchRequst, Database.Grad, GradoviUpsertRequest, GradoviUpsertRequest>
    {
        public GradoviService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Gradovi> Get(GradoviSearchRequst search)
        {
            var query = _db.Grad.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }

          return  _mapper.Map<List<Model.Gradovi>>(query);
        }
    }
}
