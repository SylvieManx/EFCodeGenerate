using System;
using System.Collections.Generic;

namespace Decision.Entity
{
    public partial class ManageFbaShipments
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Fnsku { get; set; }
        public string Asin { get; set; }
        public int Shipped { get; set; }
        public string SysSellerId { get; set; }
        public string SysSite { get; set; }
        public string SysShopsName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime UploadDate { get; set; }
        public string UserName { get; set; }
    }
}


