using Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ModelViews
{
   public partial class ProductOrder
    {
        public String ProductName { get; set; }
        public String Image { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }

        //public ProductOrder(SanPham product, int quantity)
        //{
        //    this.ProductName = product.TenSanPham;
        //    this.Image = product.Anh;
        //    this.Price = product.GiaBan;
        //    this.SalePrice = (decimal)product.GiaKM;
        //    this.Price = product.GiaBan;
        //    this.Quantity = quantity;
        //}
    }
}
