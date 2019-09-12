using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AutoKuca.WebAPI.Services
{
    public class VozilaService : BaseCRUDService<Model.VozilaM, VozilaSearchRequest, Database.Vozila, VozilaUpsertRequest, VozilaUpsertRequest>
    {
        public VozilaService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<VozilaM> Get(VozilaSearchRequest search)
        {
            var query = _db.Vozila.Include(x => x.Model.Marka).Include(x => x.Model).Include(x => x.TipVozila).Include(x => x.Oprema).Include(x => x.BrojVrata).Include(x => x.Transmisija).AsQueryable(); 
            if (search.MarkaId != 0)
            {
                query = query.Where(x => x.Model.MarkaId == search.MarkaId);
            }
            if (search.TransmisijaId != 0)
            {
                query = query.Where(x => x.TransmisijaId == search.TransmisijaId);
            }
            if (search.TipVozilaId != 0)
            {
                query = query.Where(x => x.TipVozilaId == search.TipVozilaId);
            }
            if (search.Godina!=0)
            {
                query = query.Where(x => x.DatumProizvodnje.Year == search.Godina);
            }
            if (search.Sortiraj == 1)
            {
                query = query.OrderBy(x=>x.Model.Marka.Naziv);
            }
            if (search.Sortiraj == 2)
            {
                query = query.OrderBy(x=>x.Cijena);
            }
            if (search.pocetna == true)
            {
                query = query.OrderBy(x => x.BrojPregleda).Take(5);
            }
            if (search.preporuka == true)
            {
                query = GetSlicneProizvode(search.voziloId).Take(1);
            }
            if (search.preporukaTip == true)
            {
                query = GetSlicneProizvodePoTipu(search.voziloId).Take(3);
            }



            List <VozilaM> lis1 = new List<VozilaM>();

       

            foreach (var item in query)
            {
                if (item.Status == false)
                    lis1.Add(new VozilaM
                    {
                        VoziloId = item.VoziloId,
                        Model = item.Model.Naziv,
                        Marka = item.Model.Marka.Naziv,
                        TipVozila = item.TipVozila.Naziv,
                        Cijena = item.Cijena,
                        SifraAutomobila = item.SifraAutomobila,
                        BrojPregleda = item.BrojPregleda,

                });
            }

            foreach (var item in lis1)
            {
                if (_db.SlikeVozila.FirstOrDefault(x => x.VoziloId == item.VoziloId)!=null)
                    item.Slika = _db.SlikeVozila.FirstOrDefault(x => x.VoziloId == item.VoziloId).Slika;
            }

            return lis1;
        }

        public override VozilaM GetById(int id)
        {
            var lista = _db.Vozila.Where(x=>x.VoziloId==id).Include(x => x.Model.Marka).Include(x => x.Model).Include(x => x.TipVozila).Include(x => x.Oprema).Include(x => x.BrojVrata).Include(x => x.Transmisija).Include(x => x.Gorivo).SingleOrDefault();
            var poslovnica = _db.VozilaPoslovnice.Where(x => x.VoziloId == id).Include(x => x.Poslovnica).FirstOrDefault();
            VozilaM lis1 = new VozilaM();

            lista.BrojPregleda++;
            _db.SaveChanges();
            lis1.VoziloId = lista.VoziloId;
            lis1.Model = lista.Model.Naziv;
            lis1.Marka = lista.Model.Marka.Naziv;
            lis1.TipVozila = lista.TipVozila.Naziv;
            lis1.Cijena = lista.Cijena;
            lis1.SifraAutomobila = lista.SifraAutomobila;
            lis1.Oprema = lista.Oprema.Naziv;
            lis1.OpremaOpis = lista.Oprema.Opis;
            lis1.Transmisija = lista.Transmisija.Naziv;
            lis1.BrojVrata = lista.BrojVrata.Naziv;
            lis1.Gorivo = lista.Gorivo.Naziv;
            lis1.Kubikaza = lista.Kubikaza;
            lis1.Kilometraza = lista.Kilometraza;
            lis1.SnagaMotora = lista.SnagaMotora;
            lis1.Status = lista.Status;
            lis1.DatumProizvodnje = lista.DatumProizvodnje;
            lis1.ModelId = lista.ModelId;
            lis1.OpremaId = lista.OpremaId;
            lis1.TipVozilaId = lista.TipVozilaId;
            lis1.TransmisijaId = lista.TransmisijaId;
            lis1.BrojVrataId = lista.BrojVrataId;
            lis1.GorivoId = lista.GorivoId;
            lis1.PoslovnicaNaziv = poslovnica.Poslovnica.Naziv;      
            lis1.DatumUvoza = poslovnica.DatumUvoza;
            lis1.PoslovnicaId = poslovnica.PoslovnicaId;
            return lis1;
        }

        public override VozilaM Insert(VozilaUpsertRequest request)
        {
            Database.Vozila vozilo = new Vozila();
            Database.VozilaPoslovnice podatci = new VozilaPoslovnice();

            vozilo.Cijena = request.Cijena;
            vozilo.SifraAutomobila = request.SifraAutomobila;
            vozilo.OpremaId = request.OpremaId;
            vozilo.TransmisijaId = request.TransmisijaId;
            vozilo.BrojVrataId = request.BrojVrataId;
            vozilo.TipVozilaId = request.TipVozilaId;
            vozilo.ModelId = request.ModelId;
            vozilo.DatumProizvodnje = request.DatumProizvodnje;
            vozilo.Kilometraza = request.Kilometraza;
            vozilo.Kubikaza = request.Kubikaza;
            vozilo.SnagaMotora = request.SnagaMotora;
            vozilo.Status = request.Status;
            vozilo.GorivoId = request.GorivoId;

            _db.Vozila.Add(vozilo);

            podatci.DatumUvoza = request.DatumUvoza;
            podatci.PoslovnicaId = request.PoslovnicaId;
            podatci.Vozilo = vozilo;

            _db.VozilaPoslovnice.Add(podatci);

            _db.SaveChanges();

            VozilaM vozila=null; 
            return vozila;

        }

        public override void Delete(int id)
        {

            var entity = _db.Vozila.Find(id);    
            entity.Status = true;
            _db.SaveChanges();
        }


  

            public IQueryable<Database.Vozila> GetSlicneProizvode(int id)
            {
                var marka = _db.Vozila.Where(x => x.VoziloId == id).Include(x => x.Model).Select(x => x.Model.MarkaId).FirstOrDefault();
                var aktivni = _db.Vozila.Where(x => x.VoziloId != id && x.Model.MarkaId == marka && x.Status == false).Include(x => x.Model.Marka).Include(x => x.Model).Include(x => x.TipVozila).Include(x => x.Oprema).Include(x => x.BrojVrata).Include(x => x.Transmisija).OrderBy(x => x.BrojPregleda).AsQueryable();        
                return aktivni;
        }

        public IQueryable<Database.Vozila> GetSlicneProizvodePoTipu(int id)
        {
            var tip = _db.Vozila.Where(x => x.VoziloId == id).Include(x => x.TipVozila).Select(x => x.TipVozilaId).FirstOrDefault();
            var aktivni = _db.Vozila.Where(x => x.VoziloId != id && x.TipVozilaId == tip && x.Status == false).Include(x => x.Model.Marka).Include(x => x.Model).Include(x => x.TipVozila).Include(x => x.Oprema).Include(x => x.BrojVrata).Include(x => x.Transmisija).OrderBy(x => x.BrojPregleda).AsQueryable();
            return aktivni;
        }



    }
}
