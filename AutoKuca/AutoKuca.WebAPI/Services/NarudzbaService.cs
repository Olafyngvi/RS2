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
    public class NarudzbaService : BaseCRUDService<Model.Narudzba, NarudzbaSearchRequest, Database.Narudzba, NarudzbaUpsertRequest, NarudzbaUpsertRequest>
    {
        public NarudzbaService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<Model.Narudzba> Get(NarudzbaSearchRequest search)
        {
            List<Model.Narudzba> lista = new List<Model.Narudzba>();
            var query = _db.Narudzba.AsQueryable();
            if (search.KlijentId != 0)
            {
                query = query.Where(x => x.KlijentId == search.KlijentId).AsQueryable();
                foreach (var x in query)
                {
                    lista.Add(new Model.Narudzba
                    {
                        NarudzbaId = x.NarudzbaId,
                        DatumNarudžbe = x.DatumNarudžbe,
                        Zavrsena = x.Zavrsena,
                        KlijentId = x.KlijentId
                    });
                }
                return _mapper.Map<List<Model.Narudzba>>(lista);
            }
            if (search.Zavrsena == true)
            {
                query = query.Where(x => x.Zavrsena == true);
            }
            else
            {
                query = query.Where(x => x.Zavrsena != true);
            }
            
            foreach(var x in query)
            {
                lista.Add(new Model.Narudzba
                {
                    NarudzbaId = x.NarudzbaId,
                    DatumNarudžbe = x.DatumNarudžbe,
                    Zavrsena = x.Zavrsena,
                    KlijentId = x.KlijentId
                });
            }
            return _mapper.Map<List<Model.Narudzba>>(lista);
        }
        public override Model.Narudzba Update(int id, NarudzbaUpsertRequest request)
        {
            var obj =_db.Narudzba.Find(id);

            obj.Zavrsena = true;
            _db.Narudzba.Update(obj);
            _db.SaveChanges();
            var novi = _mapper.Map<Model.Narudzba>(obj);
            return novi;
        }
    }
}
