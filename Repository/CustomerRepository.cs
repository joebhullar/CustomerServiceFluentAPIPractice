using CustomerServiceFluentAPIPractice.EntityFramework;
using CustomerServiceFluentAPIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServiceFluentAPIPractice.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        CustomerDbContext _customerDbContext; //We Inject the ApplicationDbContext into the Repository
        public CustomerRepository(CustomerDbContext customerDbContext)
        {
            this._customerDbContext = customerDbContext;
        }
        public int CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer SearchCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
