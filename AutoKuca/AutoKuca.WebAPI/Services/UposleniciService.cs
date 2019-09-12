using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AutoKuca.WebAPI.Services
{
    public class UposleniciService : BaseCRUDService<Model.Uposlenici, UposleniciSearchRequest, Database.Uposlenik,UposleniciUpsertRequest, UposleniciUpsertRequest>
    {
        public UposleniciService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }



        public override List<Uposlenici> Get(UposleniciSearchRequest search)
        {
            List<Uposlenici> lista = new List<Uposlenici>();

            var uposlenik = _db.Uposlenik.Include(x => x.Vrsta).Include(x => x.Poslovnica).Include(x=>x.UposlenikNavigation.Grad).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                uposlenik = uposlenik.Where(x => x.UposlenikNavigation.Ime.StartsWith(search.Ime));
            }

          

            if (search.vrstaID != 0)
            {
                uposlenik = uposlenik.Where(x => x.VrstaId == search.vrstaID);
            }

            foreach (var item in uposlenik)
            {
                lista.Add(new Uposlenici {
                    KorisnikId = item.UposlenikId,
                    Ime = item.UposlenikNavigation.Ime,
                    Prezime = item.UposlenikNavigation.Prezime,
                    KorisnickoIme = item.UposlenikNavigation.KorisnickoIme,
                    Telefon = item.UposlenikNavigation.Telefon,
                    Poslovnica = item.Poslovnica.Naziv,
                    Grad = item.UposlenikNavigation.Grad.Naziv,
                    VrstaUposlenika = item.Vrsta.Naziv,
                    VrstaUposlenikaId=item.VrstaId,
                    Status = item.Status
                });
            }

            foreach (var item in lista)
            {
                if (item.Status == true)
                    item.StatusS = "Ne radi";
                else { item.StatusS = "Radi"; }
            }

            return lista;

        }

        public override Uposlenici GetById(int id)
        {
            var uposlenik = _db.Uposlenik.Where(x=>x.UposlenikId==id).Include(x=>x.UposlenikNavigation).Include(x => x.UposlenikNavigation.Grad).Include(x => x.Vrsta).Include(x => x.Poslovnica).SingleOrDefault();

            Uposlenici model = new Uposlenici();
            model.KorisnikId = uposlenik.UposlenikId;
            model.Ime = uposlenik.UposlenikNavigation.Ime;
            model.Prezime = uposlenik.UposlenikNavigation.Prezime;
            model.KorisnickoIme = uposlenik.UposlenikNavigation.KorisnickoIme;
            model.Telefon = uposlenik.UposlenikNavigation.Telefon;
            model.Poslovnica = uposlenik.Poslovnica.Naziv;
            model.PoslovnicaId = uposlenik.PoslovnicaId;
            model.Grad = uposlenik.UposlenikNavigation.Grad.Naziv;
            model.GradId = uposlenik.UposlenikNavigation.GradId;
            model.VrstaUposlenika = uposlenik.Vrsta.Naziv;
            model.VrstaUposlenikaId = uposlenik.VrstaId;
            model.Adresa = uposlenik.UposlenikNavigation.Adresa;
            model.Jmbg = uposlenik.Jmbg;
            model.DatumZaposljavanja = uposlenik.DatumZaposljavanja;
            model.DatumRodjenja = uposlenik.DatumRodjenja;
            model.Status = uposlenik.Status;

            return model;
        }

       

        public override Uposlenici Insert(UposleniciUpsertRequest request)
        {
            Korisnik korisnik = new Korisnik();
            Uposlenik uposlenik = new Uposlenik();
            
            

            korisnik.Ime = request.Ime;
            korisnik.Prezime = request.Prezime;
            korisnik.Adresa = request.Adresa;
            korisnik.KorisnickoIme = request.KorisnickoIme;
            korisnik.LozinkaSalt = GenerateSalt();
            korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt,request.Lozinka);
            korisnik.Telefon = request.Telefon;
            korisnik.GradId = request.GradId;
            _db.Korisnik.Add(korisnik);

            uposlenik.DatumRodjenja = request.DatumRodjenja;
            uposlenik.DatumZaposljavanja = request.DatumZaposljavanja;
            uposlenik.PoslovnicaId = request.PoslovnicaId;
            uposlenik.Jmbg = request.Jmbg;
            uposlenik.VrstaId = request.VrstaUposlenikaId;
            uposlenik.Status = request.Status;
            uposlenik.UposlenikId = korisnik.KorisnikId;

            _db.Uposlenik.Add(uposlenik);

            _db.SaveChanges();

            return _mapper.Map<Uposlenici>(uposlenik);

        }

        public override Uposlenici Update(int id, UposleniciUpsertRequest request)
        {
            var korisnik = _db.Korisnik.Find(id);
            var uposlenik = _db.Uposlenik.Find(id);

            korisnik.Ime = request.Ime;
            korisnik.Prezime = request.Prezime;
            korisnik.Adresa = request.Adresa;
            korisnik.KorisnickoIme = request.KorisnickoIme;
            if (request.Lozinka!="")
            {
                korisnik.LozinkaSalt = GenerateSalt();
                korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, request.Lozinka);
            }
           
            korisnik.Telefon = request.Telefon;
            korisnik.GradId = request.GradId;
            _db.Korisnik.Attach(korisnik);
            _db.Korisnik.Update(korisnik);


            uposlenik.DatumRodjenja = request.DatumRodjenja;
            uposlenik.DatumZaposljavanja = request.DatumZaposljavanja;
            uposlenik.PoslovnicaId = request.PoslovnicaId;
            uposlenik.Jmbg = request.Jmbg;
            uposlenik.VrstaId = request.VrstaUposlenikaId;
            uposlenik.Status = request.Status;
            uposlenik.UposlenikId = korisnik.KorisnikId;

            _db.Uposlenik.Attach(uposlenik);
            _db.Uposlenik.Update(uposlenik);


            _db.SaveChanges();
            return _mapper.Map<Uposlenici>(uposlenik);

        }

        public override void Delete(int id)
        {

            var entity = _db.Uposlenik.Find(id);
            entity.Status = true;
            _db.SaveChanges();
        }
    }
}
