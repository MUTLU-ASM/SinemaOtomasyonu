namespace SinemaOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tur")]
    public partial class Tur
    {
        public int TurID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }
    }
}
