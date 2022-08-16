namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        public int kullaniciID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string eposta { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        public int? yetkiID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarihi { get; set; }

        public virtual Yetki Yetki { get; set; }
    }
}
