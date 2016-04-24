﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin.BookShop.IRepository
{
    public class CreateDatabaseIfNotExists<TContext> : System.Data.Entity.CreateDatabaseIfNotExists<TContext> where TContext : System.Data.Entity.DbContext
    {
        protected override void Seed(TContext context)
        {
            base.Seed(context);
        }
    }
}
