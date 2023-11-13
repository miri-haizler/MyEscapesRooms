using escapeRoom.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace escapeRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {

     //   private DataContext context2;
        private DataContext context;
        public Customers(DataContext context)
        {
            this.context = context;
        }


        // GET: api/<Customers>
        [HttpGet]
        public IEnumerable<Coustomers_class> Get()
        {
            return context.customersList;
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Coustomers_class customer= context.customersList.Find(x => x.Id == id);
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
            context.customersList.Add(value);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Coustomers_class cust)
        {

            var update = context.customersList.Find(x => x.Id == id);
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
            var t = context.customersList.Find(x => x.Id == id);
            if (t == null)
            {
                return NotFound();
            }
           
          return Ok(context.customersList.Remove(t));
        }
    }
}
