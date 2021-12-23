namespace Nhom3.Core.Domains
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

        [Required(ErrorMessage = "Danh mục sản phẩm không được để trống")]
        [Display(Name = "Danh mục")]
        public int MaDM { get; set; }

        [Required(ErrorMessage ="Tên sản phẩm không được để trống")]
        [StringLength(100)]
        [Display(Name ="Tên sản phẩm")]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "Hoa chính của sản phẩm không được để trống")]

        [StringLength(100)]
        [Display(Name = "Hoa chính")]

        public string HoaChinh { get; set; }

        [Required(ErrorMessage = "Hoa phụ của sản phẩm không được để trống")]

        [StringLength(100)]
        [Display(Name = "Hoa Phụ")]
       

        public string HoaPhu { get; set; }
        [Display(Name = "Chiều ngang")]
        [Required(ErrorMessage = "Chiều ngang không được để trống")]
        public int ChieuNgang { get; set; }
        [Display(Name = "Chiều cao")]

        [Required(ErrorMessage = "Chiều cao không được để trống")]
        public int ChieuCao { get; set; }
        [Display(Name = "Trọng lượng")]
       
        public double TrongLuong { get; set; }
        [Display(Name = "Số lượng tồn")]

        public int SoLuongTon { get; set; }
        [Display(Name = "Giá gốc")]
        [Required(ErrorMessage = "Giá gốc không được để trống")]
        public decimal Gia { get; set; }
        [Display(Name = "Giá khuyến mãi")]
        [Required(ErrorMessage = "Giá Khuyến mãi không được để trống")]
        public decimal GiaKM { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }
        [Display(Name = "Ảnh")]

        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Anh { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
