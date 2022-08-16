namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            Seans = new HashSet<Seans>();
        }

        public int filmID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        public short? Sure { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }

        [Column(TypeName = "text")]
        public string Konu { get; set; }

        public decimal? Puan { get; set; }

        [StringLength(50)]
        public string Oyuncu { get; set; }

        [StringLength(50)]
        public string yonetmen { get; set; }

        public int? filmTurID { get; set; }

        [StringLength(200)]
        public string afis { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vizyonBasTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vizyonBitTarihi { get; set; }

        public virtual FilmTur FilmTur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seans> Seans { get; set; }
    }
}
