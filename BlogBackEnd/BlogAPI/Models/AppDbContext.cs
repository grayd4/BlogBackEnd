﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BlogAPI.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
