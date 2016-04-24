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
    
    public partial class Press
    {
        public Press()
        {
            this.Books = new HashSet<Book>();
            this.InStockReceipts = new HashSet<InStockReceipt>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public EntityState State { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<InStockReceipt> InStockReceipts { get; set; }
    }
}