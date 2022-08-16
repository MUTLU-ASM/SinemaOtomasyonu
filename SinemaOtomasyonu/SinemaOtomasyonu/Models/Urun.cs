namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urun")]
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            AdisyonDetay = new HashSet<AdisyonDetay>();
        }

        public int urunID { get; set; }

        public int? turID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(100)]
        public string resim { get; set; }

        [Column(TypeName = "money")]
        public decimal? fiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdisyonDetay> AdisyonDetay { get; set; }
    }
}
