namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETGIOHANG")]
    public partial class CHITIETGIOHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASANPHAM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAGIOHANG { get; set; }

        public int? SOLUONG { get; set; }

        public virtual GIOHANG GIOHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
