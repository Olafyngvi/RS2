using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using AutoKuca.WebAPI.Database;
using AutoKuca.WebAPI.Security;
using AutoKuca.WebAPI.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AutoKuca.WebAPI
{
    public class Startup
    {

        public class BasicAuthDocumentFilter : IDocumentFilter
        {
            public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
            {
                var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

                swaggerDoc.Security = new[] { securityRequirements };
            }
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();

            var connection = @"Server=.;Database=Auto-KucaRS2;Trusted_Connection=True;ConnectRetryCount=0";

            services.AddDbContext<AutoKucaRS2Context>(options => options.UseSqlServer(connection));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
                c.CustomSchemaIds(x => x.FullName);
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddScoped<ICRUDService<Marke, object,MarkeUpsertRequest,MarkeUpsertRequest>, BaseCRUDService<Marke, object, Database.Marka,MarkeUpsertRequest,MarkeUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Dio, DioSearchRequest, DioUpsertRequest, DioUpsertRequest>, DioService>();
            services.AddScoped<ICRUDService<Model.Narudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest>, NarudzbaService>();
            services.AddScoped<ICRUDService<Model.Kategorija,object,KategorijaUpsertRequest,KategorijaUpsertRequest>,BaseCRUDService<Model.Kategorija, object, Database.Kategorija, KategorijaUpsertRequest, KategorijaUpsertRequest>>();
            services.AddScoped<ICRUDService<Opreme, object, OpremeUpsertRequest, OpremeUpsertRequest>, BaseCRUDService<Opreme, object, Database.Oprema, OpremeUpsertRequest, OpremeUpsertRequest>>();
            services.AddScoped<ICRUDService<TipoviVozila, object, TipoviUpsertRequest, TipoviUpsertRequest>, BaseCRUDService<TipoviVozila, object, Database.TipVozila, TipoviUpsertRequest, TipoviUpsertRequest>>();
            services.AddScoped <ICRUDService<Model.Modeli, ModeliSearchRequest,ModeliUpsertRequest,ModeliUpsertRequest>, ModelService>();
            services.AddScoped<ICRUDService<VozilaM, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest>, VozilaService>();
            services.AddScoped<IService<Model.Transmisija,object>, BaseService<Model.Transmisija,object,Database.Transmisija>>();
            services.AddScoped<ICRUDService<Model.DetaljiNarudzbe, DetaljiNarudzbaSearchRequest,DetaljiNarudzbeUpsertRequest,DetaljiNarudzbeUpsertRequest>, DetaljiNarudzbeService>();
            services.AddScoped<IService<Model.BrojVrata, object>, BaseService<Model.BrojVrata, object, Database.BrojVrata>>();
            services.AddScoped<IService<Model.Goriva, object>, BaseService<Model.Goriva, object, Database.Gorivo>>();
            services.AddScoped<IUpitiVozilaService, UpitiVozilaService>();
            services.AddScoped<IService<Model.VozilaM, object>, ProdanaService>();
            services.AddScoped<ICRUDService<Model.Slike, SlikeSearchRequest, SlikeUpsertRequest, SlikeUpsertRequest>, SlikeService>();
            services.AddScoped<ICRUDService<Model.Poslovnice, object, PoslovniceUpsertRequest, PoslovniceUpsertRequest>, PoslovniceService>();
            services.AddScoped<ICRUDService<Model.Uposlenici, UposleniciSearchRequest, UposleniciUpsertRequest, UposleniciUpsertRequest>, UposleniciService > ();
            services.AddScoped<ICRUDService<Model.Gradovi, GradoviSearchRequst,GradoviUpsertRequest,GradoviUpsertRequest>, GradoviService>();
            services.AddScoped<IService<Model.VrsteUposlenika, object>, BaseService<Model.VrsteUposlenika, object, Database.VrstaUposlenika>>();
            services.AddScoped<ICRUDService<Model.PodaciUvoza, PodaciUvozaSearchRequest, PodaciUvozaUpsertRequest, PodaciUvozaUpsertRequest>, PodaciUvozaService>();
            services.AddScoped<IAdminUpitiService, AdminUpitiService>();
            services.AddScoped<ICRUDService<Korisnici, object, KorisniciUpsertRequest, KorisniciUpsertRequest>, BaseCRUDService<Korisnici, object, Database.Korisnik, KorisniciUpsertRequest, KorisniciUpsertRequest>>();
            services.AddScoped<IKlijentService, KlijentiService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
              
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
