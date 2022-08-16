namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seans()
        {
            Bilet = new HashSet<Bilet>();
        }

        public int seansID { get; set; }

        public int? filmID { get; set; }

        public int? salonID { get; set; }

        public TimeSpan? seansBaslangicSaati { get; set; }

        public TimeSpan? seansBitisSaati { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }

        public virtual Film Film { get; set; }

        public virtual Salon Salon { get; set; }
    }
}
