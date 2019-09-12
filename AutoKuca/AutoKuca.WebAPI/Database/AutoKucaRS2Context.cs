using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoKuca.WebAPI.Database
{
    public partial class AutoKucaRS2Context : DbContext
    {
        public AutoKucaRS2Context()
        {
        }

        public AutoKucaRS2Context(DbContextOptions<AutoKucaRS2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BrojVrata> BrojVrata { get; set; }
        public virtual DbSet<DetaljiNarudzbe> DetaljiNarudzbe { get; set; }
        public virtual DbSet<Dio> Dio { get; set; }
        public virtual DbSet<Gorivo> Gorivo { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<KontaktUpit> KontaktUpit { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<Oprema> Oprema { get; set; }
        public virtual DbSet<Poslovnica> Poslovnica { get; set; }
        public virtual DbSet<SlikeVozila> SlikeVozila { get; set; }
        public virtual DbSet<TipVozila> TipVozila { get; set; }
        public virtual DbSet<Transmisija> Transmisija { get; set; }
        public virtual DbSet<UpitiVozila> UpitiVozila { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<Vozila> Vozila { get; set; }
        public virtual DbSet<VozilaPoslovnice> VozilaPoslovnice { get; set; }
        public virtual DbSet<VrstaUposlenika> VrstaUposlenika { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Auto-KucaRS2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<BrojVrata>(entity =>
            {
                entity.Property(e => e.BrojVrataId).HasColumnName("BrojVrataID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DetaljiNarudzbe>(entity =>
            {
                entity.Property(e => e.DetaljiNarudzbeId).HasColumnName("DetaljiNarudzbeID");

                entity.Property(e => e.DioId).HasColumnName("DioID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.HasOne(d => d.Dio)
                    .WithMany(p => p.DetaljiNarudzbe)
                    .HasForeignKey(d => d.DioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetaljiNarudzbe_Dio");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.DetaljiNarudzbe)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetaljiNarudzbe_Narudzba");
            });

            modelBuilder.Entity<Dio>(entity =>
            {
                entity.Property(e => e.DioId).HasColumnName("DioID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sifra)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Dio)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dio_Kategorija");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Dio)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dio_Model");
            });

            modelBuilder.Entity<Gorivo>(entity =>
            {
                entity.Property(e => e.GorivoId).HasColumnName("GorivoID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.Property(e => e.KlijentId)
                    .HasColumnName("KlijentID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatumRegistracije).HasColumnType("date");

                entity.HasOne(d => d.KlijentNavigation)
                    .WithOne(p => p.Klijent)
                    .HasForeignKey<Klijent>(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Klijent_Korisnik2");
            });

            modelBuilder.Entity<KontaktUpit>(entity =>
            {
                entity.HasKey(e => e.KontaktUpitiId);

                entity.Property(e => e.KontaktUpitiId).HasColumnName("KontaktUpitiID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ImePrezime).HasMaxLength(50);

                entity.Property(e => e.Poruka).HasColumnType("text");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisnik)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnik2_Grad");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Model_Marka");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.DatumNarudžbe).HasColumnType("date");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_Klijent");
            });

            modelBuilder.Entity<Oprema>(entity =>
            {
                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Poslovnica>(entity =>
            {
                entity.Property(e => e.PoslovnicaId).HasColumnName("PoslovnicaID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Poslovnica)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poslovnica_Grad");
            });

            modelBuilder.Entity<SlikeVozila>(entity =>
            {
                entity.HasKey(e => e.SlikaId)
                    .HasName("PK_Slike");

                entity.Property(e => e.SlikaId).HasColumnName("SlikaID");

                entity.Property(e => e.Slika).IsRequired();

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.SlikeVozila)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlikeVozila_Vozila");
            });

            modelBuilder.Entity<TipVozila>(entity =>
            {
                entity.Property(e => e.TipVozilaId).HasColumnName("TipVozilaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Transmisija>(entity =>
            {
                entity.Property(e => e.TransmisijaId).HasColumnName("TransmisijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UpitiVozila>(entity =>
            {
                entity.Property(e => e.UpitiVozilaId).HasColumnName("UpitiVozilaID");

                entity.Property(e => e.DatumVrijeme).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ImePrezime).HasMaxLength(50);

                entity.Property(e => e.Poruka).HasColumnType("text");

                entity.Property(e => e.SifraAutomobila).HasMaxLength(50);
            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.Property(e => e.UposlenikId)
                    .HasColumnName("UposlenikID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.DatumZaposljavanja).HasColumnType("date");

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasColumnName("JMBG")
                    .HasMaxLength(50);

                entity.Property(e => e.PoslovnicaId).HasColumnName("PoslovnicaID");

                entity.Property(e => e.VrstaId).HasColumnName("VrstaID");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.Uposlenik)
                    .HasForeignKey(d => d.PoslovnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uposlenik_Poslovnica");

                entity.HasOne(d => d.UposlenikNavigation)
                    .WithOne(p => p.Uposlenik)
                    .HasForeignKey<Uposlenik>(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uposlenik_Korisnik2");

                entity.HasOne(d => d.Vrsta)
                    .WithMany(p => p.Uposlenik)
                    .HasForeignKey(d => d.VrstaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uposlenik_VrstaUposlenika");
            });

            modelBuilder.Entity<Vozila>(entity =>
            {
                entity.HasKey(e => e.VoziloId);

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.Property(e => e.BrojPregleda).HasColumnName("brojPregleda");

                entity.Property(e => e.BrojVrataId).HasColumnName("BrojVrataID");

                entity.Property(e => e.DatumProizvodnje).HasColumnType("datetime");

                entity.Property(e => e.GorivoId).HasColumnName("GorivoID");

                entity.Property(e => e.Kilometraza)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Kubikaza)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.SifraAutomobila)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SnagaMotora)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipVozilaId).HasColumnName("TipVozilaID");

                entity.Property(e => e.TransmisijaId).HasColumnName("TransmisijaID");

                entity.HasOne(d => d.BrojVrata)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.BrojVrataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_BrojVrata");

                entity.HasOne(d => d.Gorivo)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.GorivoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_Gorivo");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_Model");

                entity.HasOne(d => d.Oprema)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.OpremaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_Oprema");

                entity.HasOne(d => d.TipVozila)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.TipVozilaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_TipVozila");

                entity.HasOne(d => d.Transmisija)
                    .WithMany(p => p.Vozila)
                    .HasForeignKey(d => d.TransmisijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozila_Transmisija");
            });

            modelBuilder.Entity<VozilaPoslovnice>(entity =>
            {
                entity.Property(e => e.VozilaPoslovniceId).HasColumnName("VozilaPoslovniceID");

                entity.Property(e => e.DatumUvoza).HasColumnType("date");

                entity.Property(e => e.PoslovnicaId).HasColumnName("PoslovnicaID");

                entity.Property(e => e.VoziloId).HasColumnName("VoziloID");

                entity.HasOne(d => d.Poslovnica)
                    .WithMany(p => p.VozilaPoslovnice)
                    .HasForeignKey(d => d.PoslovnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VozilaPoslovnice_Poslovnica");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.VozilaPoslovnice)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VozilaPoslovnice_Vozila");
            });

            modelBuilder.Entity<VrstaUposlenika>(entity =>
            {
                entity.Property(e => e.VrstaUposlenikaId).HasColumnName("VrstaUposlenikaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
