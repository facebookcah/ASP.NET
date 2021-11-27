using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nhom3.Model
{
    public partial class FlowerDB : DbContext
    {
        public FlowerDB()
            : base("name=FlowerDB")
        {
        }

        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<DANHMUCCON> DANHMUCCONs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<GIOHANG> GIOHANGs { get; set; }
        public virtual DbSet<HTTT> HTTTs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<MAGIAMGIA> MAGIAMGIAs { get; set; }
        public virtual DbSet<QUYEN> QUYENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANHMUC>()
                .HasMany(e => e.DANHMUCCONs)
                .WithRequired(e => e.DANHMUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHMUCCON>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.DANHMUCCON)
                .HasForeignKey(e => e.MADANHMUCCON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHMUCCON>()
                .HasMany(e => e.SANPHAMs1)
                .WithRequired(e => e.DANHMUCCON1)
                .HasForeignKey(e => e.MADANHMUCCON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIOHANG>()
                .Property(e => e.DIENTHOAINGUOINHAN)
                .IsFixedLength();

            modelBuilder.Entity<GIOHANG>()
                .HasMany(e => e.CHITIETGIOHANGs)
                .WithRequired(e => e.GIOHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HTTT>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.HTTT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.NGAYSINH)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAGIAMGIA>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.MAGIAMGIA1)
                .HasForeignKey(e => e.MAGIAMGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QUYEN>()
                .Property(e => e.TENQUYEN)
                .IsFixedLength();

            modelBuilder.Entity<QUYEN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.QUYEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIAKM)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETGIOHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATKHAU)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TENQUYEN)
                .IsFixedLength();
        }
    }
}
