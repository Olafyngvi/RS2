using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AutoKuca.WebAPI.Services
{
    public class ProdanaService : BaseService<Model.VozilaM, object, Database.Vozila>
    {
        public ProdanaService(AutoKucaRS2Context db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<VozilaM> Get(object search)
        {
            var lista = _db.Vozila.Include(x => x.Model.Marka).Include(x => x.Model).Include(x => x.TipVozila).Include(x => x.Oprema).Include(x => x.BrojVrata).Include(x => x.Transmisija);

            List<VozilaM> lis1 = new List<VozilaM>();

            foreach (var item in lista)
            {
                if (item.Status == true)
                    lis1.Add(new VozilaM
                    {
                        VoziloId = item.VoziloId,
                        Model = item.Model.Naziv,
                        Marka = item.Model.Marka.Naziv,
                        TipVozila = item.TipVozila.Naziv,
                        Cijena = item.Cijena,
                        SifraAutomobila = item.SifraAutomobila

                    });
            }

            return lis1;
        }
    }
}
