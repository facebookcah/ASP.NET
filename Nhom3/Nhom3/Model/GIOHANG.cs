namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIOHANG")]
    public partial class GIOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIOHANG()
        {
            CHITIETGIOHANGs = new HashSet<CHITIETGIOHANG>();
        }

        [Key]
        public int MAGIOHANG { get; set; }

        [Required]
        [StringLength(100)]
        public string TENNGUOINHAN { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string DIACHINGUOINHAN { get; set; }

        [Required]
        [StringLength(11)]
        public string DIENTHOAINGUOINHAN { get; set; }

        public DateTime? NGAYGIOGIAO { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string LOICHUC { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }
    }
}
