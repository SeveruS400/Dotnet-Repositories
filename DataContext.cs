using Adetsis.IsTakip.Entities.Birimler;
using Adetsis.IsTakip.Entities.Kategoriler;
using Adetsis.IsTakip.Entities.Kullanicilar;
using Adetsis.IsTakip.Entities.Musteriler;
using Adetsis.IsTakip.Entities.Siparisler;
using Adetsis.IsTakip.Entities.Tedarikciler;
using Adetsis.IsTakip.Entities.Urunler;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Kategori> Kategories { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<PersonelYetki> PersonelYetkis { get; set; }
        public DbSet<Yetkiler> Yetkilers { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<MusteriYetkili> MusteriYetkilis { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<SiparisDosya> SiparisDosyas { get; set; }
        public DbSet<SiparisSurec> SiparisSurecs { get; set; }
        public DbSet<SiparisSurecDurum> SiparisSurecDurums { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}