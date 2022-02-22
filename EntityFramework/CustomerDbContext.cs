using CustomerServiceFluentAPIPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServiceFluentAPIPractice.EntityFramework
{
    public class CustomerDbContext :DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//what does onModelCreating do? its purpose is to validate data before db connection? 
        {
            // base.OnModelCreating(modelBuilder);
            new CustomerMap(modelBuilder.Entity<Customer>());
        }
    }
}
