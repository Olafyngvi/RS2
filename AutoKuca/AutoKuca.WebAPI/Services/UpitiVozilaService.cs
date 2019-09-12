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
    public class UpitiVozilaService : IUpitiVozilaService
    {
        protected readonly AutoKucaRS2Context _db;
        protected readonly IMapper _mapper;

        public UpitiVozilaService(AutoKucaRS2Context db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Model.UpitiVozila> Get(UpitiVozilaSearchRequest search)
        {
            if (search.VrstaUpitaID == 1)
            {
                var list = _db.UpitiVozila.Where(x => x.Pregledano == false).ToList();
                return _mapper.Map<List<Model.UpitiVozila>>(list);
            }
            else
            {
                var list = _db.UpitiVozila.Where(x => x.Pregledano == true).ToList();
                return _mapper.Map<List<Model.UpitiVozila>>(list);
            }
        }

        public Model.UpitiVozila GetById(int id)
        {
            var entity = _db.Set<Database.UpitiVozila>().Find(id);
            return _mapper.Map<Model.UpitiVozila>(entity);
        }

        public Model.UpitiVozila Insert(UpitiVozilaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.UpitiVozila>(request);
            _db.Set<Database.UpitiVozila>().Add(entity);
            _db.SaveChanges();
            return _mapper.Map<Model.UpitiVozila>(entity);
        }

     

        public void Delete(int id)
        {
            var entity = _db.UpitiVozila.Find(id);
            entity.Pregledano = true;
            _db.SaveChanges();

        }
    }
}






  
    





