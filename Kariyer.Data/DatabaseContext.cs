using Kariyer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Basvuran> Basvuranlar { get; set; }
        public DbSet<CalismaSekli> CalismaSekilleri { get; set; }
        public DbSet<Cinsiyet> Cinsiyetler { get; set; }
        public DbSet<DeneyimSure> DeneyimSureleri { get; set; }
        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<EkBilgi> EkBilgiler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<FavoriIlan> FavoriIlanlar { get; set; }
        public DbSet<Hakkimda> Hakkimdas { get; set; }
        public DbSet<Hobi> Hobiler { get; set; }
        public DbSet<Ilan> Ilanlar { get; set; }
        public DbSet<IlanDurumu> IlanDurumlari { get; set; }
        public DbSet<IlanKayit> IlanKayitlari { get; set; }
        public DbSet<IsDeneyim> IsDeneyimleri { get; set; }
        public DbSet<IsIlaniCalismaSekli> IsIlaniCalismaSekilleri { get; set; }
        public DbSet<IsIlaniCinsiyet> IsIlaniCinsiyetler { get; set; }
        public DbSet<IsIlaniDeneyimSuresi> IsIlaniDeneyimSureleri { get; set; }
        public DbSet<IsIlaniDurum> IsIlaniDurumlari { get; set; }
        public DbSet<IsIlaniMezuniyet> IsIlaniMezuniyetleri { get; set; }
        public DbSet<IsIlaniSehir> IsIlaniSehirler { get; set; }
        public DbSet<IsIlaniSektor> IsIlaniSektorler { get; set; }
        public DbSet<IsIlaniUlke> IsIlaniUlkeler { get; set; }
        public DbSet<IsIlaniYabanciDil> IlaniYabanciDilleri { get; set; }
        public DbSet<Mezuniyet> Mezuniyetler { get; set; }
        public DbSet<Mulakat> Mulakatlar { get; set; }
        public DbSet<MulakatListe> MulakatListeleri { get; set; }
        public DbSet<Ozgecmis> Ozgecmisler { get; set; }
        public DbSet<OzgecmisHavuzu> OzgecmisHavuzlari { get; set; }
        public DbSet<OzgecmisSehir> OzgecmisSehirleri { get; set; }
        public DbSet<OzgecmisSosyalMedya> OzgecmisSosyalMedyalar { get; set; }
        public DbSet<OzgecmisYabanciDil> OzgecmisYabanciDiller { get; set; }
        public DbSet<OzgecmisYazilimDil> OzgecmisYazilimDiller { get; set; }
        public DbSet<Referans> Referanlar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Sektor> Sektorler { get; set; }
        public DbSet<Sertifika> Sertifikalar { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<SirketIlan> SirketIlanlari { get; set; }
        public DbSet<SirketSehir> SirketSehirleri { get; set; }
        public DbSet<SirketSektor> SirketSektorleri { get; set; }
        public DbSet<SirketTakip> SirketTakipleri { get; set; }
        public DbSet<SirketSosyalMedya> SirketSosyalMedyalar { get; set; }
        public DbSet<SosyalMedya> SosyalMedyalar { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Universite> Universiteler { get; set; }
        public DbSet<Uyelik> Uyelikler { get; set; }
        public DbSet<YabanciDil> YabanciDiller { get; set; }
        public DbSet<YazilimDil> YazilimDiller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-V6MIU7R\SQLEXPRESS; database=KariyerWebDB; trusted_connection=true; MultipleActiveResultSets=True; Encrypt=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 1,
                RolAdi = "Admin"
            });
            modelBuilder.Entity<Uyelik>().HasData(new Uyelik
            {
                Id = 1,
                Adi = "Admin",
                Soyadi = "ADMİN",
                KullaniciAdi = "Admin",
                KayitTarihi = DateTime.Now,
                Email = "admin@kariyer.tc",
                RolId = 1,
                Sifre = "123456"

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
