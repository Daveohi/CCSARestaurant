using CCSARestaurant.Core;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace ChefAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChefController : ControllerBase
    {
        private readonly ChefRep chefRep;
        private object existingChef;
        private object chef;
        private object updatedChef;

        public ChefController(ISessionFactory sessionFactory)
        {
            chefRep = new ChefRep(sessionFactory);
        }

        // GET: api/Customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            var customer = this.chefRep.GetChef();
            return Ok(chef);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetChef(int id)
        {
            var chef = chefRep.GetChefById(id);
            if (chef == null)
            {
                return NotFound();
            }

            return Ok(chef);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public IActionResult UpdateChef(int id, Customer updatedChef)
        {
            if (id != updatedChef.Id)
            {
                return BadRequest();
            }

            var existingCustomer = chefRep.GetChefById(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            // Update the customer properties
            existingChef = updatedChef.FirstName;
            existingChef = updatedChef.Surname;
            // Update other properties as needed

            // Save the changes
            chefRep.UpdateChef(existingChef);

            return NoContent();
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public IActionResult DeleteChef(int id)
        {
            var customer = chefRep.GetChefById(id);
            if (customer == null)
            {
                return NotFound();
            }

            chefRep.DeleteChef(chef);

            return NoContent();
        }
    }
}