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
    public class AdminUpitiService : IAdminUpitiService
    {
        protected readonly AutoKucaRS2Context _db;
        protected readonly IMapper _mapper;

        public AdminUpitiService(AutoKucaRS2Context db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Model.UpitiAdmin> Get(UpitiVozilaSearchRequest search)
        {
            if (search.VrstaUpitaID == 1)
            {
                var list = _db.KontaktUpit.Where(x => x.Pregledano == false).ToList();
                return _mapper.Map<List<Model.UpitiAdmin>>(list);
            }
            else
            {
                var list = _db.KontaktUpit.Where(x => x.Pregledano == true).ToList();
                return _mapper.Map<List<Model.UpitiAdmin>>(list);
            }
        }

        public Model.UpitiAdmin GetById(int id)
        {
            var entity = _db.Set<Database.KontaktUpit>().Find(id);
            return _mapper.Map<Model.UpitiAdmin>(entity);
        }

        public Model.UpitiAdmin Insert(UpitiVozilaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.KontaktUpit>(request);
            _db.Set<Database.KontaktUpit>().Add(entity);
            _db.SaveChanges();
            return _mapper.Map<Model.UpitiAdmin>(entity);
        }



        public void Delete(int id)
        {
            var entity = _db.KontaktUpit.Find(id);
            entity.Pregledano = true;
            _db.SaveChanges();

        }
    }
}
