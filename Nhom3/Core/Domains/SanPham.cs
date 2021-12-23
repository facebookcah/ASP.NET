namespace Core.Domains
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        public int MaDM { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSP { get; set; }

        [Required]
        [StringLength(100)]
        public string HoaChinh { get; set; }

        [Required]
        [StringLength(100)]
        public string HoaPhu { get; set; }

        public int ChieuNgang { get; set; }

        public int ChieuCao { get; set; }

        public double TrongLuong { get; set; }

        public int SoLuongTon { get; set; }

        public decimal Gia { get; set; }

        public decimal GiaKM { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Anh { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
