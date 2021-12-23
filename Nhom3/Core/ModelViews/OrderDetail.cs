using Core.Domains;
using System;
using System.Collections.Generic;

namespace Core.ModelViews
{
    public partial class OrderDetail
    {
        public int OrderCode{ get; set; }
        public int CustomerCode{ get; set; }
        public DateTime OrderDate{ get; set; }
        public string Payments { get; set; }

        public int Status{ get; set; }
        public List<ProductOrder> products{ get; set; }

        public OrderDetail(List<ProductOrder> products)
        {
    
        }
    }
}
