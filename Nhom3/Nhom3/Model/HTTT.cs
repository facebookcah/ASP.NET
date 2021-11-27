namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HTTT")]
    public partial class HTTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HTTT()
        {
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        public int MAHTTT { get; set; }

        [Required]
        [StringLength(50)]
        public string TENHTTT { get; set; }

        public bool TRANGTHAI { get; set; }

        [Column(TypeName = "ntext")]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
