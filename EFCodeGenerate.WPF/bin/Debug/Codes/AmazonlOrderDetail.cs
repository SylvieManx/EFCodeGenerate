using System;
using System.Collections.Generic;

namespace Decision.Entity
{
    public partial class AmazonlOrderDetail
    {
        public decimal Id { get; set; }
        public string AmazonOrderId { get; set; }
        public string AmazonOrderItemCode { get; set; }
        public string Asin { get; set; }
        public string Sku { get; set; }
        public string ItemStatus { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Principal { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Shipping { get; set; }
        public Nullable<decimal> ShippingTax { get; set; }
        public Nullable<decimal> Giftwrap { get; set; }
        public Nullable<decimal> GiftwrapTax { get; set; }
        public string PromotionIds { get; set; }
        public Nullable<decimal> ItemPromotionDiscount { get; set; }
        public Nullable<decimal> ShipPromotionDiscount { get; set; }
        public string SysSite { get; set; }
        public string SysShopsName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UploadDate { get; set; }
        public string Platform { get; set; }
    }
}


