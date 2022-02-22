using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServiceFluentAPIPractice.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public int CustomerAge { get; set; }
        public int CustomerAddress { get; set; }
        public int CustomerPhone { get; set; }
    }
}
