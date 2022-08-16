namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bilet")]
    public partial class Bilet
    {
        public int biletID { get; set; }

        public long? No { get; set; }

        [StringLength(50)]
        public string durum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        public int? seansID { get; set; }

        [StringLength(5)]
        public string cinsiyet { get; set; }

        public virtual Seans Seans { get; set; }
    }
}
