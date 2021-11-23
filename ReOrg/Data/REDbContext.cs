using Microsoft.EntityFrameworkCore;
using ReOrg.Data.Configurations;
using ReOrg.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReOrg.Data
{
    public class REDbContext : DbContext
    {
        public REDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmailConfiguration());

        }
        public DbSet<Email> EMAIL { get; set; }
    }
}
