namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUCCON")]
    public partial class DANHMUCCON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHMUCCON()
        {
            SANPHAMs = new HashSet<SANPHAM>();
            SANPHAMs1 = new HashSet<SANPHAM>();
        }

        [Key]
        public int MADANHMUCCON { get; set; }

        [Required]
        [StringLength(100)]
        public string TENDANHMUCCON { get; set; }

        public int MADANHMUC { get; set; }

        public virtual DANHMUC DANHMUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs1 { get; set; }
    }
}
