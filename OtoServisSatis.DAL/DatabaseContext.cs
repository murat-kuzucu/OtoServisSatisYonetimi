using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtoServisSatis.DAL
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Arac> Arac { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Marka> Markalar { get; set; }

        public DbSet<Musteri> Musteriler { get; set; }

        public DbSet<Rol> Roller { get; set; }

        public DbSet<Satis> Satislar {  get; set; }

        public DbSet<Servis> Servisler { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public class DatabaseInitializer:CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                if (!context.Kullanicilar.Any())
                {
                    context.Kullanicilar.Add(new Kullanici()
                    {
                        Adi = "Admin",
                        AktifMi = true,
                        EklenmeTarihi = DateTime.Now,
                        Email = "admin@otoservissatis.tc",
                        KullaniciAdi = "admin",
                        Sifre = "123456",

                    });
                    context.SaveChanges();
                }
                base.Seed(context);
            }
        }

        public DatabaseContext():base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}

/*
 * Ef de migration aktif etme
 * App.config dosyalarina (DAL katmani ve WindowsApp katmani) connection string olusturulmasi
 * PacketManagerConsole da view menusunden aktif etme
 * PMC konusunda aktif proje olarak sag ust menuden projeadi.DAL katmani secip enable-migrations yazarak migrations olusturma.
 * isim verilip olusturulan migrationsi, migrations klasoru eklendikten sonra PMC konsoluna update-database veri tabanı kurulmasi.
 */