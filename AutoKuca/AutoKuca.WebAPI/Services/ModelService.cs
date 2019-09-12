using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AutoKuca.WebAPI.Services
{
    public class ModelService : BaseCRUDService<Modeli,ModeliSearchRequest,Database.Model,ModeliUpsertRequest,ModeliUpsertRequest>
    {
      
        public ModelService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
         
        }

        public override List<Modeli> Get(ModeliSearchRequest request)
        {
            if(request.MarkaId != null)
            {
                var result = _db.Model.Include(x=>x.Marka).Where(x => x.MarkaId == request.MarkaId).ToList();
                List<Modeli> list1 = new List<Modeli>();

                foreach (var item in result)
                {
                    Model.Modeli novi = new Modeli()
                    {
                        ModelId = item.ModelId,
                        Naziv = item.Naziv,
                        NazivMarke = item.Marka.Naziv,
                        MarkaId = item.MarkaId
                    };
                    list1.Add(novi);
                }
                return list1;
            }

            var query1 = _db.Model.Include(x => x.Marka).AsQueryable();
            var query2 = _db.Model.Include(x => x.Marka).AsQueryable();




            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query1 = query1.Where(x => x.Naziv == request.Naziv);

            }

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query2 = query2.Where(x => x.Marka.Naziv == request.Naziv);

            }


            if (query1.Count() > query2.Count())
            {
                var lista = query1.ToList();
                List<Modeli> list1 = new List<Modeli>();

                foreach (var item in lista)
                {
                    list1.Add(new Modeli
                    {
                        ModelId = item.ModelId,
                        Naziv = item.Naziv,
                        NazivMarke = item.Marka.Naziv,
                        MarkaId = item.MarkaId


                    });
                }
                return list1;
            }
            else
            {
                var lista = query2.ToList();
                List<Modeli> list1 = new List<Modeli>();

                foreach (var item in lista)
                {
                    list1.Add(new Modeli
                    {
                        ModelId = item.ModelId,
                        Naziv = item.Naziv,
                        NazivMarke = item.Marka.Naziv,
                        MarkaId = item.MarkaId

                    });
                }
                return list1;
            }
        }

        public override Modeli GetById(int id)
        {
            var entity = _db.Model.Include(x => x.Marka).Where(x => x.ModelId == id).SingleOrDefault();

            var model = new Model.Modeli();

            model.MarkaId = entity.MarkaId;
            model.NazivMarke = entity.Marka.Naziv;
            model.ModelId = entity.ModelId;
            model.Naziv = entity.Naziv;

            return model;


        }

        //public override Modeli Update(int id, ModeliUpsertRequest request)
        //{
           
        //    return base.Update(id, request);
        //}




    }
}
