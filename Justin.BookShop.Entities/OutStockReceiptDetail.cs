//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Justin.BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class OutStockReceiptDetail
    {
        public OutStockReceiptDetail()
        {
            this.Sort = 1;
        }
    
        public System.Guid ID { get; set; }
        public int Sort { get; set; }
        public int OutQuantity { get; set; }
        public decimal OutUnitPrice { get; set; }
        public Nullable<decimal> AccountPrice { get; set; }
        public System.Guid BookID { get; set; }
        public System.Guid HeaderID { get; set; }
    
        public virtual OutStockReceipt ReceiptHeader { get; set; }
        public virtual Book Book { get; set; }
    }
}
