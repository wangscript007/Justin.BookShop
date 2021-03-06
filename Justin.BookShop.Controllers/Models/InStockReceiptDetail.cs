﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.BookShop.Controllers.Models
{
    public class InStockReceiptDetail
    {
        public Guid ID { get; set; }
        public int EntryQuantity { get; set; }
        public decimal EntryUnitPrice { get; set; }
        public decimal AccountPrice { get; set; }
        public Guid BookID { get; set; }
        public string ISBN { get; set; }
        public string BookName { get; set; }
    }
}
