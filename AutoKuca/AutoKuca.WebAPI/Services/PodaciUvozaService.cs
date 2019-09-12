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
    public class PodaciUvozaService : BaseCRUDService<Model.PodaciUvoza, PodaciUvozaSearchRequest, Database.VozilaPoslovnice, PodaciUvozaUpsertRequest, PodaciUvozaUpsertRequest>
    {
        public PodaciUvozaService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<PodaciUvoza> Get(PodaciUvozaSearchRequest search)
        {
            var vozilo = _db.VozilaPoslovnice.Include(x => x.Vozilo).Include(x => x.Poslovnica).Include(x => x.Vozilo.Model).Include(x => x.Vozilo.Model.Marka).AsQueryable();

            if (search.PoslovnicaId != 0)
            {
                vozilo = vozilo.Where(x => x.PoslovnicaId == search.PoslovnicaId);
            }

            List<PodaciUvoza> pod = new List<PodaciUvoza>();

            foreach (var item in vozilo)
            {
                pod.Add(new PodaciUvoza {
                    VozilaPoslovniceId=item.VozilaPoslovniceId,
                    DatumUvoza = item.DatumUvoza,
                    Poslovnica = item.Poslovnica.Naziv,
                    Sifra=item.Vozilo.SifraAutomobila,
                    Marka=item.Vozilo.Model.Marka.Naziv,
                    Model=item.Vozilo.Model.Naziv
                });
            }

            return pod;

            
        }

        public override PodaciUvoza GetById(int id)
        {
            var vozilo = _db.VozilaPoslovnice.Where(x=>x.VozilaPoslovniceId==id).Include(x => x.Vozilo).Include(x => x.Poslovnica).Include(x => x.Vozilo.Model).Include(x => x.Vozilo.Model.Marka).FirstOrDefault();
            PodaciUvoza pod = new PodaciUvoza();
            pod.DatumUvoza = vozilo.DatumUvoza;
            pod.PoslovnicaId = vozilo.PoslovnicaId;
            pod.Poslovnica = vozilo.Poslovnica.Naziv;
            pod.VoziloId = vozilo.VoziloId;
            pod.Sifra = vozilo.Vozilo.SifraAutomobila;

            return pod;

        }

    }
}
