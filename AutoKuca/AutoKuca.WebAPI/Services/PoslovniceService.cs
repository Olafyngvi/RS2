using AutoKuca.Model;
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
    public class PoslovniceService : BaseCRUDService<Model.Poslovnice, object, Database.Poslovnica, PoslovniceUpsertRequest, PoslovniceUpsertRequest>
    {
        public PoslovniceService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Poslovnice> Get(object search)
        {
            List<Poslovnice> lista = new List<Poslovnice>();

            var poslovnice = _db.Poslovnica.Include(x => x.Grad).ToList();


            foreach (var item in poslovnice)
            {
                lista.Add(new Poslovnice
                {
                    PoslovnicaId = item.PoslovnicaId,
                    Adresa = item.Adresa,
                    Telefon = item.Telefon,
                    Naziv = item.Naziv,
                    Grad=item.Grad.Naziv,
                    Status = item.Status
                });
            }

            foreach (var item in lista)
            {
                if (item.Status == true)
                    item.StatusS = "DA";
                else { item.StatusS = "NE"; }
            }

            return lista;
        }

        public override Poslovnice GetById(int id)
        {
            Poslovnice pos = new Poslovnice();

            var poslovnice = _db.Poslovnica.Where(x=>x.PoslovnicaId==id).Include(x => x.Grad).SingleOrDefault();

            pos.PoslovnicaId = poslovnice.PoslovnicaId;
             pos.Adresa = poslovnice.Adresa;
            pos.Telefon = poslovnice.Telefon;
            pos.Naziv = poslovnice.Naziv;
            pos.GradId = poslovnice.GradId;
            pos.Grad = poslovnice.Grad.Naziv;
            pos.Status = poslovnice.Status;


            return pos;

        }

        public override void Delete(int id)
        {

            var entity = _db.Poslovnica.Find(id);
            entity.Status = true;
            _db.SaveChanges();
        }
    }
}
