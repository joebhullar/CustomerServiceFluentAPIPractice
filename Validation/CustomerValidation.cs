using CustomerServiceFluentAPIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;


namespace CustomerServiceFluentAPIPractice.Validation
{
    public class CustomerValidation: AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(c => c.CustomerId).NotNull();
            RuleFor(c => c.CustomerName).Length(0, 10).WithMessage("Customer name should not be exceed more than 10 characters");
            RuleFor(c => c.CustomerName).NotNull().WithMessage("Customer name should not be empty");
            RuleFor(c => c.CustomerEmail).EmailAddress().WithMessage("Customer email should be in proper format"); // QUESTION!! DOES This accctually validate anyhting else???
            RuleFor(c => c.CustomerAge).InclusiveBetween(10, 50).WithMessage("Customer age must be between 10 to 50");
            //RuleFor(c => c.CustomerPhone).MinimumLength(10).MaximumLength(15).WithMessage("Customer phone number must be between 10 to 15 characters");  //QUESTION I GET ERROR HERE!!
        }
    }
}
