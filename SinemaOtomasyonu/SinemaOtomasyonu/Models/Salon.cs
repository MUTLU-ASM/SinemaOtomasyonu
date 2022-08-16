namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salon")]
    public partial class Salon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salon()
        {
            Seans = new HashSet<Seans>();
        }

        public int salonID { get; set; }

        public short? salonNo { get; set; }

        public short? ad { get; set; }

        [StringLength(50)]
        public string durum { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public int? koltukSayisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seans> Seans { get; set; }
    }
}
