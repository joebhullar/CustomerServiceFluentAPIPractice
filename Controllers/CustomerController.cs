using CustomerServiceFluentAPIPractice.Models;
using CustomerServiceFluentAPIPractice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServiceFluentAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _icustomerRepository;
        public CustomerController(ICustomerRepository icustomerRepository)
        {
            this._icustomerRepository = icustomerRepository;
        }


        [HttpPost("Create")]
        public ActionResult CreateCustomer(Customer customer)
        {
            return Ok(this._icustomerRepository.CreateCustomer(customer));
        }

        [HttpGet("CustomerList")]
        public ActionResult GetCustomerList()
        {
            return Ok(this._icustomerRepository.GetCustomers());
        }

        [HttpGet("SearchCustomerById")]
        public ActionResult SearchCustomer(int customerId)
        {
            return Ok(this._icustomerRepository.SearchCustomer(customerId));
        }

        [HttpPut("UpdateCustomer")]
        public ActionResult UpdateCustomer(Customer customer)
        {
            return Ok(this._icustomerRepository.UpdateCustomer(customer));
        }

        [HttpDelete("DeleteCustomer")]
        public ActionResult DeleteCustomer(Customer customer)
        {
            return Ok(this._icustomerRepository.DeleteCustomer(customer));
        }
    }
}
