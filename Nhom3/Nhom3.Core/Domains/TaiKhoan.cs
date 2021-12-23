namespace Nhom3.Core.Domains
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            GioHangs = new HashSet<GioHang>();
        }

        [Key]
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Tên tài khoản không được để trống")]
        [StringLength(100,ErrorMessage ="Tên tài khoản không vượt quá 100 kí tự")]
        public string TenTaiKhoan { get; set; }

        [Display(Name ="Mật khẩu")]

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MaxLength(20,ErrorMessage ="Mật khẩu không được vượt quá 20 kí tự")]
        [MinLength(8,ErrorMessage ="Mật khẩu không được ít hơn 8 kí tự")]
        public string MatKhau { get; set; }
        [Display(Name = "Quyền đăng nhập")]

        public int Quyen { get; set; }
        [Display(Name = "Tình trạng")]

        public bool TinhTrang { get; set; }
        [Display(Name = "Tên khách hàng")]

        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string TenKhachHang { get; set; }
        [EmailAddress(ErrorMessage ="Không đúng định dạng email")]
        [StringLength(100,ErrorMessage ="Email không vượt quá 100 kí tự")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(12, ErrorMessage = "Số điện thoại không vượt quá 12 kí tự")]
        public string SoDienThoai { get; set; }
        [Display(Name = "Ghi chú")]

        [Column(TypeName = "ntext")]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
