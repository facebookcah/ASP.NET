namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAGIAMGIA")]
    public partial class MAGIAMGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAGIAMGIA()
        {
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        [Column("MAGIAMGIA")]
        public int MAGIAMGIA1 { get; set; }

        public int PHANTRAM { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string MOTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
