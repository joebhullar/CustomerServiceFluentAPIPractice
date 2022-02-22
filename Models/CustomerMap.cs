using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServiceFluentAPIPractice.Models
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityTypeBuilderCustomer)
        {
            entityTypeBuilderCustomer.HasKey(cust => cust.CustomerId);
            entityTypeBuilderCustomer.Property(cust => cust.CustomerId).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerName).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerAge).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerName).HasMaxLength(50);
            entityTypeBuilderCustomer.Property(cust => cust.CustomerPhone).IsRequired();

        }
    }
}
