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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
        }

        [Key]
        
        public int MaSP { get; set; }
        [Display(Name ="Danh mục")]
        [Required(ErrorMessage = "Danh mục không được để trống")]
        public int MaDM { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(100,ErrorMessage ="Tên sản phẩm không quá 100 kí tự")]
        [Display(Name = "Tên sản phẩm")]
       
        public string TenSP { get; set; }

        [Display(Name = "Hoa chính")]
        [Required(ErrorMessage = "Hoa chính không được để trống")]
        [StringLength(100)]
        public string HoaChinh { get; set; }

        [Display(Name = "Hoa phụ")]
        [Required(ErrorMessage = "Hoa phụ không được để trống")]
        [StringLength(100)]
        public string HoaPhu { get; set; }
        [Display(Name = "Chiều ngang")]
        [Required(ErrorMessage = "Chiều ngang không được để trống")]
        public int ChieuNgang { get; set; }
        [Display(Name = "Chiều cao")]
        [Required(ErrorMessage = "Chiều cao không được để trống")]
        public int ChieuCao { get; set; }

        public double? TrongLuong { get; set; }

        public int? SoLuongTon { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Giá không được để trống")]
        public decimal Gia { get; set; }
        [Display(Name = "Giá khuyến mại")]
       
        public decimal? GiaKM { get; set; }
        [Display(Name = "Mô tả")]
       
        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }
        [Display(Name = "Ảnh")]
        
        [Column(TypeName = "ntext")]
        [Required(ErrorMessage ="Bạn phải chọn 1 ảnh")]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
