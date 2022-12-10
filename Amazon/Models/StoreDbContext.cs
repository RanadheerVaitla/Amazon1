using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Amazon.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }
    }
}