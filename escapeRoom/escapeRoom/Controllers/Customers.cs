using escapeRoom.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace escapeRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {

        private static List<Coustomers_class> customersList=new List<Coustomers_class>() { 
        new Coustomers_class(123,"Brachi","Dinkel"), new Coustomers_class(456,"Miri","Haizler"), new Coustomers_class(789,"Sara","Cohen"), new Coustomers_class(258,"Lea","Levi")};
        // GET: api/<Customers>
        [HttpGet]
        public IEnumerable<Coustomers_class> Get()
        {
            return customersList;
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Coustomers_class customer= customersList.Find(x => x.Id == id);
            if (customer==null)
            {
                return NotFound(); 
            }
            return Ok(customer);
        }

        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] Coustomers_class value)
        {
            customersList.Add(value);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Coustomers_class cust)
        {

            var update = customersList.Find(x => x.Id == id);
            if (update == null)
            {
               return NoContent();
            }
            update.Id = cust.Id;
            update.LName = cust.LName;
            update.FName = cust.FName;
            return Ok(update);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var t = customersList.Find(x => x.Id == id);
            if (t == null)
            {
                return NotFound();
            }
            return Ok(customersList.Remove(t));
        }
    }
}
