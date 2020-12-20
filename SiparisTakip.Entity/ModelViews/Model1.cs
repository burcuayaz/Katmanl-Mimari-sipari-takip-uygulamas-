namespace SiparisTakip.Entity.ModelViews
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<vw_BankaHesap> vw_BankaHesap { get; set; }
        public virtual DbSet<vw_BankaHesapHareket> vw_BankaHesapHareket { get; set; }
        public virtual DbSet<vw_CariBakiye> vw_CariBakiye { get; set; }
        public virtual DbSet<vw_CariHareket> vw_CariHareket { get; set; }
        public virtual DbSet<vw_Fatura> vw_Fatura { get; set; }
        public virtual DbSet<vw_FaturaDetay> vw_FaturaDetay { get; set; }
        public virtual DbSet<vw_Kullanici> vw_Kullanici { get; set; }
        public virtual DbSet<vw_SatisDetayListesi> vw_SatisDetayListesi { get; set; }
        public virtual DbSet<vw_SatisListesi> vw_SatisListesi { get; set; }
        public virtual DbSet<vw_StokDetayliHesapEkstresi> vw_StokDetayliHesapEkstresi { get; set; }
        public virtual DbSet<vw_StokHareketListesi> vw_StokHareketListesi { get; set; }
        public virtual DbSet<vw_StokListesi> vw_StokListesi { get; set; }
        public virtual DbSet<vw_StokSayim> vw_StokSayim { get; set; }
        public virtual DbSet<vw_StokVaryantListesi> vw_StokVaryantListesi { get; set; }
        public virtual DbSet<vw_TeknikServis> vw_TeknikServis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vw_BankaHesap>()
                .Property(e => e.Bakiye)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_BankaHesapHareket>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Alacak)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Borc)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.Bakiye)
                .HasPrecision(38, 2);

            modelBuilder.Entity<vw_CariBakiye>()
                .Property(e => e.BakiyeDurumu)
                .IsUnicode(false);

            modelBuilder.Entity<vw_CariHareket>()
                .Property(e => e.Sira)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Sira)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Maliyet)
                .HasPrecision(38, 4);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.Kar)
                .HasPrecision(38, 4);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.YuzdeKar)
                .HasPrecision(38, 6);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.IrsaliyeSeri)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Fatura>()
                .Property(e => e.FaturaSeri)
                .IsUnicode(false);

            modelBuilder.Entity<vw_FaturaDetay>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_FaturaDetay>()
                .Property(e => e.DovizBirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.CepTelNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<vw_Kullanici>()
                .Property(e => e.TCKimlikNo)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.SatisTarihi1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.SatisZamani1)
                .IsUnicode(false);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.Miktari)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_SatisDetayListesi>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_SatisListesi>()
                .Property(e => e.IskontoOrani)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_StokDetayliHesapEkstresi>()
                .Property(e => e.BirimFiyati)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vw_StokHareketListesi>()
                .Property(e => e.Miktar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vw_StokListesi>()
                .Property(e => e.ToplamVarlik)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokListesi>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<vw_StokSayim>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamAlis)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamSatis)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.ToplamVarlik)
                .HasPrecision(29, 2);

            modelBuilder.Entity<vw_StokVaryantListesi>()
                .Property(e => e.Marka)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.MarkaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.ModelAdi)
                .IsUnicode(false);

            modelBuilder.Entity<vw_TeknikServis>()
                .Property(e => e.IsyeriAdi)
                .IsUnicode(false);
        }
    }
}
