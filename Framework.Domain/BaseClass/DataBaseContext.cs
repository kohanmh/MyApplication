using Framework.IDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Framework.Domain
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<CustomerEntity> CustomerEntity { get; set; }
    }
}
