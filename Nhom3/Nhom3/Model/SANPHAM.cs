namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            CHITIETGIOHANGs = new HashSet<CHITIETGIOHANG>();
        }

        [Key]
        [DisplayName("Mã sản phẩm")]
        public int MASANPHAM { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Tên sản phẩm")]
        public string TENSANPHAM { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        [DisplayName("Mô tả")]
        public string MOTA { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Hoa chính")]
        public string HOACHINH { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Hoa phụ")]
        public string HOAPHU { get; set; }
        [DisplayName("Chiểu ngang")]
        public int CHIEUNGANG { get; set; }
        [DisplayName("Chiểu cao")]
        public int CHIEUCAO { get; set; }
        [DisplayName("Giá bán")]
        public decimal GIABAN { get; set; }
        [DisplayName("Giá KM")]
        public decimal? GIAKM { get; set; }
        [DisplayName("DM con")]
        public int MADANHMUCCON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }

        public virtual DANHMUCCON DANHMUCCON { get; set; }

        public virtual DANHMUCCON DANHMUCCON1 { get; set; }
    }
}
