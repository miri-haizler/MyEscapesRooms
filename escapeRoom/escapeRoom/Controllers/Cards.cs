using escapeRoom.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace escapeRoom.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Cards : ControllerBase
    {
        //// GET: api/<Cards>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}



        // GET api/<Cards>/5
        //[HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
        //    Room_class r = Rooms.roomsList.Find(x => x.Id == id);
        //    if (r == null)
        //    {
        //        return NotFound();
        //    }
        //    if (r.IsOpen == true && r.IsFull(0) < 20)
        //    {
        //        return Ok("you can go to update cards");
        //    }
        //    return Ok("sorry! all the cards saled out");
        //}


        private DataContext context;
        public Cards(DataContext context)
        {
            this.context = context;
        }


        // POST api/<Cards>
        [HttpPost]
        public ActionResult Post([FromBody] int idCustomer, int idRoom, int count)
        {
            Room_class r = /*Rooms.*/context.roomsList.Find(x => x.Id == idRoom);
            if (r == null)
            {
                return NotFound();
            }
            if (r.IsOpen == true && r.IsFull(0) < 20)
            {
                Cards_Class card = new Cards_Class(idCustomer, count, idRoom);
                context.cardsList.Add(card);
                r.IsFull(count);
                return Ok("the card added successfully!");
            }
            return Ok("sorry! all the cards saled out");


        }

        // PUT api/<Cards>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] int count)
        {
            Cards_Class card = context.cardsList.Find(x => x.IdCard == id);
            if (card == null)
            {
                return NotFound();
            }
            card.CountOfCard = count;
            return Ok("the count updated successfully!");
        }

        // DELETE api/<Cards>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Cards_Class card = context.cardsList.Find(x => x.IdCard == id);
            if (card == null)
            {
                return NotFound();
            }
            context.cardsList.Remove(card);
            return Ok("the card removed successfully!");
        }
    }
}
