namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdisyonDetay")]
    public partial class AdisyonDetay
    {
        public int adisyonDetayID { get; set; }

        public int? adisyonID { get; set; }

        public int? urunID { get; set; }

        public int? miktar { get; set; }

        [Column(TypeName = "money")]
        public decimal? birimFiyat { get; set; }

        public virtual Adisyon Adisyon { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
