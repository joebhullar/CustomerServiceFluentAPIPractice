using CustomerServiceFluentAPIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServiceFluentAPIPractice.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer SearchCustomer(int id);

        int UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);

        int DeleteCustomer(Customer customer);
    }
}
