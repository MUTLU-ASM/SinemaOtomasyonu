using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SinemaOtomasyonu.Models
{
    public partial class MBSinemaContext : DbContext
    {
        public MBSinemaContext()
            : base("name=MBSinemaContext1")
        {
        }

        public virtual DbSet<Adisyon> Adisyon { get; set; }
        public virtual DbSet<AdisyonDetay> AdisyonDetay { get; set; }
        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmTur> FilmTur { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<Seans> Seans { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tur> Tur { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adisyon>()
                .Property(e => e.toplamUcret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AdisyonDetay>()
                .Property(e => e.birimFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Film>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.Konu)
                .IsUnicode(false);

            modelBuilder.Entity<Film>()
                .Property(e => e.Puan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Film>()
                .Property(e => e.afis)
                .IsUnicode(false);

            modelBuilder.Entity<FilmTur>()
                .Property(e => e.ad)
                .IsFixedLength();

            modelBuilder.Entity<Salon>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Yetki>()
                .HasMany(e => e.Kullanici)
                .WithOptional(e => e.Yetki)
                .HasForeignKey(e => e.yetkiID);
        }
    }
}
