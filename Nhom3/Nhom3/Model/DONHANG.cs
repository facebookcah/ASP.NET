namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        public int MADONHANG { get; set; }

        public DateTime NGAYDAT { get; set; }

        public int TINHTRANG { get; set; }

        public int MAKH { get; set; }

        public int MAHTTT { get; set; }

        public int MAGIAMGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        public virtual MAGIAMGIA MAGIAMGIA1 { get; set; }

        public virtual HTTT HTTT { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
