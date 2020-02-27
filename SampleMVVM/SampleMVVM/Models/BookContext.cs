﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.Models
{
    class BookContext : DbContext
    {
        public BookContext() : base("DbConnection") { }

        public DbSet<Book> Books { get; set; }
    }
}
