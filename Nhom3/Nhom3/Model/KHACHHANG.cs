namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            DONHANGs = new HashSet<DONHANG>();
            TAIKHOANs = new HashSet<TAIKHOAN>();
        }

        [Key]
        public int MAKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TENKH { get; set; }

        public int DIENTHOAI { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(100)]
        public string HINHANH { get; set; }

        public bool GIOITINH { get; set; }

        [StringLength(15)]
        public string NGAYSINH { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
