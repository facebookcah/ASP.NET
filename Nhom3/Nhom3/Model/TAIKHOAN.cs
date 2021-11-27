namespace Nhom3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        public int MATAIKHOAN { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Tên đăng nhập")]
        public string TENDANGNHAP { get; set; }

        [Required]
        [StringLength(25)]
        [DisplayName("Mật khẩu")]
        public string MATKHAU { get; set; }
        [DisplayName("Trạng thái")]
        public bool TRANGTHAI { get; set; }
        [DisplayName("Tên khách hàng")]
        public int MAKH { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Tên quyền")]
        public string TENQUYEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual QUYEN QUYEN { get; set; }
    }
}
