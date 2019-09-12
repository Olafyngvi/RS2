using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKuca.WebAPI.Mappers
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<Database.Model, Model.Modeli>();
            CreateMap<Database.Marka, Model.Marke>();
            CreateMap<Database.Oprema, Model.Opreme>();
            CreateMap<Database.TipVozila, Model.TipoviVozila>();
            CreateMap<Database.Vozila, Model.VozilaM>();
            CreateMap<Database.Transmisija, Model.Transmisija>();
            CreateMap<Database.BrojVrata, Model.BrojVrata>();
            CreateMap<Database.SlikeVozila, Model.Slike>();
            CreateMap<Database.Poslovnica, Model.Poslovnice>();
            CreateMap<Database.Uposlenik, Model.Uposlenici>();
            CreateMap<Database.Grad, Model.Gradovi>();
            CreateMap<Database.VrstaUposlenika, Model.VrsteUposlenika>();
            CreateMap<Database.VozilaPoslovnice, Model.PodaciUvoza>();
            CreateMap<Database.KontaktUpit, Model.UpitiAdmin>();
            CreateMap<Database.Klijent, Model.Klijenti>();
            CreateMap<Database.UpitiVozila, Model.UpitiVozila>();
            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.Dio, Model.Dio>();
            CreateMap<Database.Narudzba, Model.Narudzba>();
            CreateMap<Database.DetaljiNarudzbe, Model.DetaljiNarudzbe>();





            CreateMap<Model.Requests.MarkeUpsertRequest, Database.Marka>();
            CreateMap<Model.Requests.ModeliUpsertRequest, Database.Model>();
            CreateMap<Model.Requests.OpremeUpsertRequest, Database.Oprema>();
            CreateMap<Model.Requests.TipoviUpsertRequest, Database.TipVozila>();
            CreateMap<Model.Requests.VozilaUpsertRequest, Database.Vozila>();
            CreateMap<Model.Requests.SlikeUpsertRequest, Database.SlikeVozila>();
            CreateMap<Model.Requests.PoslovniceUpsertRequest, Database.Poslovnica>();
            CreateMap<Model.Requests.GradoviUpsertRequest, Database.Grad>();
            CreateMap<Model.Requests.PodaciUvozaUpsertRequest, Database.VozilaPoslovnice>();
            CreateMap<Model.Requests.KlijentiUpsertRequest, Database.Klijent>();
            CreateMap<Model.Requests.UpitiVozilaUpsertRequest, Database.UpitiVozila>();
            CreateMap<Model.Requests.UpitiVozilaUpsertRequest, Database.KontaktUpit>();
            CreateMap<Model.Requests.KategorijaUpsertRequest, Database.Kategorija>();
            CreateMap<Model.Requests.DioUpsertRequest, Database.Dio>();
            CreateMap<Model.Requests.NarudzbaUpsertRequest, Database.Narudzba>();
            CreateMap<Model.Requests.DetaljiNarudzbeUpsertRequest, Database.Narudzba>();













        }

    }
}
