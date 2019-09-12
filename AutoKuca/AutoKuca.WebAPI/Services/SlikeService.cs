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
    public class SlikeService : BaseCRUDService<Model.Slike, SlikeSearchRequest, Database.SlikeVozila, SlikeUpsertRequest, SlikeUpsertRequest>
    {
        public SlikeService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Slike> Get(SlikeSearchRequest search)
        {

            int? id = search.VoziloID;
           
            var slike = _db.SlikeVozila.Where(x => x.VoziloId == id);

            return _mapper.Map<List<Model.Slike>>(slike);


        }

        public override Slike GetById(int id)
        {
            var slike = _db.SlikeVozila.FirstOrDefault(x => x.SlikaId == id);
            return _mapper.Map<Model.Slike>(slike);
        }
    }
}
