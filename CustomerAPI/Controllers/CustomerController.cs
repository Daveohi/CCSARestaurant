using CCSARestaurant.Core;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRep customerRep;

        public CustomerController(ISessionFactory sessionFactory)
        {
            customerRep = new CustomerRep(sessionFactory);
        }

        // GET: api/Customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            var customer = this.customerRep.GetCustomer();
            return Ok(customer);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer = customerRep.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, Customer updatedCustomer)
        {
            if (id != updatedCustomer.Id)
            {
                return BadRequest();
            }

            var existingCustomer = customerRep.GetCustomerById(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            // Update the customer properties
            existingCustomer = updatedCustomer.FirstName;
            existingCustomer = updatedCustomer.Surname;
            // Update other properties as needed

            // Save the changes
            customerRep.UpdateCustomer(existingCustomer);

            return NoContent();
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = customerRep.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }

            customerRep.DeleteCustomer(customer);

            return NoContent();
        }
    }
}