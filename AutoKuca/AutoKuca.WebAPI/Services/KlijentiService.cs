using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Services
{
    public class KlijentiService : IKlijentService
    {
        protected readonly AutoKucaRS2Context _db;
        protected readonly IMapper _mapper;
        public KlijentiService(AutoKucaRS2Context db, IMapper mapper) 
        {
            _db = db;
            _mapper = mapper;
        }

        public  List<Klijenti> Get(KlijentSearchRequest search)
        {
            List<Klijenti> lista = new List<Klijenti>();
            var klijent = _db.Klijent.Include(x => x.KlijentNavigation).Include(x => x.KlijentNavigation.Grad).AsQueryable();
            if(search.Korisnicko != null)
            {
                klijent = klijent.Where(x => x.KlijentNavigation.KorisnickoIme == search.Korisnicko);
                foreach(var item in klijent)
                {
                    lista.Add(new Klijenti
                    {
                        KorisnikId = item.KlijentId,
                        Ime = item.KlijentNavigation.Ime,
                        Prezime = item.KlijentNavigation.Prezime,
                        KorisnickoIme = item.KlijentNavigation.KorisnickoIme,
                        Telefon = item.KlijentNavigation.Telefon,
                        Adresa = item.KlijentNavigation.Adresa,
                        Grad = item.KlijentNavigation.Grad.Naziv,
                        DatumRegistracije = item.DatumRegistracije,
                        BrojNarudzbi = item.BrojNarudzbi,
                    });
                }
                return lista;
            }
            foreach (var item in klijent)
            {
                lista.Add(new Klijenti
                {
                    KorisnikId = item.KlijentId,
                    Ime = item.KlijentNavigation.Ime,
                    Prezime = item.KlijentNavigation.Prezime,
                    KorisnickoIme = item.KlijentNavigation.KorisnickoIme,
                    Telefon = item.KlijentNavigation.Telefon,
                    Adresa=item.KlijentNavigation.Adresa,
                    Grad = item.KlijentNavigation.Grad.Naziv,
                    DatumRegistracije = item.DatumRegistracije,
                    BrojNarudzbi = item.BrojNarudzbi,
                });
            }
            if (search.Param != null)
            {
                lista = lista.Where(x => x.Ime.ToLower().Contains(search.Param.ToLower()) ||
                  x.Prezime.ToLower().Contains(search.Param.ToLower()) ||
                  x.Grad.ToLower().Contains(search.Param.ToLower()) ||
                  x.KorisnickoIme.ToLower().Contains(search.Param.ToLower()) ||
                  x.Adresa.ToLower().Contains(search.Param.ToLower())).ToList();
            }
            return lista;
        }

        public  Klijenti GetById(int id)
        {
            var klijent = _db.Klijent.Where(x => x.KlijentId == id).Include(x => x.KlijentNavigation).Include(x => x.KlijentNavigation.Grad).SingleOrDefault();

            Klijenti model = new Klijenti();
            model.KorisnikId = klijent.KlijentId;
            model.Ime = klijent.KlijentNavigation.Ime;
            model.Prezime = klijent.KlijentNavigation.Prezime;
            model.KorisnickoIme = klijent.KlijentNavigation.KorisnickoIme;
            model.Telefon = klijent.KlijentNavigation.Telefon;
            model.Grad = klijent.KlijentNavigation.Grad.Naziv;
            model.GradId = klijent.KlijentNavigation.GradId;       
            model.Adresa = klijent.KlijentNavigation.Adresa;
            model.DatumRegistracije = klijent.DatumRegistracije;
            model.BrojNarudzbi = klijent.BrojNarudzbi;
          

            return model;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algoritam = HashAlgorithm.Create("SHA1");
            byte[] inArray = algoritam.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public  Klijenti Insert(KlijentiUpsertRequest request)
        {
            Korisnik korisnik = new Korisnik();
            Klijent klijent = new Klijent();



            korisnik.Ime = request.Ime;
            korisnik.Prezime = request.Prezime;
            korisnik.Adresa = request.Adresa;
            korisnik.KorisnickoIme = request.KorisnickoIme;
            korisnik.LozinkaSalt = GenerateSalt();
            korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, request.Lozinka);
            korisnik.Telefon = request.Telefon;
            korisnik.GradId = request.GradID;

            _db.Korisnik.Add(korisnik);

             klijent.DatumRegistracije= DateTime.Now;
            klijent.BrojNarudzbi = request.BrojNarudzbi;
            klijent.KlijentId = korisnik.KorisnikId;
         

            _db.Klijent.Add(klijent);

            _db.SaveChanges();

            Klijenti ret = null;
            return ret;
        }

        public  Klijenti Update(int id, KlijentiUpsertRequest request)
        {
            var korisnik = _db.Korisnik.Find(id);
            var klijent = _db.Klijent.Find(id);
            if(request.Ime == null && request.Prezime == null)
            {
                klijent.BrojNarudzbi += request.BrojNarudzbi;

                _db.Klijent.Update(klijent);

                _db.SaveChanges();

                Model.Klijenti ret = null;
                return ret;
            }
            else
            {
                korisnik.Ime = request.Ime;
                korisnik.Prezime = request.Prezime;
                korisnik.Adresa = request.Adresa;
                korisnik.KorisnickoIme = request.KorisnickoIme;
                korisnik.LozinkaSalt = GenerateSalt();
                korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, request.Lozinka);
                korisnik.Telefon = request.Telefon;
                //korisnik.GradId = request.GradId;
                _db.Korisnik.Attach(korisnik);
                _db.Korisnik.Update(korisnik);

                klijent.DatumRegistracije = request.DatumRegistracije;
                klijent.BrojNarudzbi = request.BrojNarudzbi;

                _db.Klijent.Attach(klijent);
                _db.Klijent.Update(klijent);

                _db.SaveChanges();
                Klijenti ret = null;
                return ret;
            }
            
        }

        public Klijenti Delete(int id)
        {
            var klijent = _db.Klijent.Find(id);
            klijent.BrojNarudzbi += 1;

            _db.Klijent.Update(klijent);

            _db.SaveChanges();
            Klijenti ret = null;
            return ret;
        }
    }
}
