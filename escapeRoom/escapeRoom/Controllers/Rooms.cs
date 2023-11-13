using escapeRoom.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Xml.Serialization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace escapeRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rooms : ControllerBase
    {

        private DataContext context;
        public Rooms(DataContext context)
        {
            this.context = context;
        }

        // GET: api/<Rooms>
        [HttpGet]
        public List<Room_class> Get()
        {
            return context.roomsList;
        }

        // GET api/<Rooms>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Room_class room = context.roomsList.Find(x => x.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        // POST api/<Rooms>
        [HttpPost]
        public void Post([FromBody] Room_class value)
        {
            context.roomsList.Add(value);
        }

        // PUT api/<Rooms>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Room_class value)
        {
            Room_class update = context.roomsList.Find(x => x.Id == id);
            if (update == null)
            {
                return NotFound();
            }
            update.Id = value.Id;
            update.IsOpen = value.IsOpen;
            update.Room_name = value.Room_name;
            return Ok(update);
        }

        //Status
        [HttpPut("{id},{status}")]
        public ActionResult Status(bool status, [FromBody] int id)
        {
            Room_class st = context.roomsList.Find(x => x.Id == id);
            if (st == null)
            {
                return NotFound();
            }
            st.IsOpen = status;
            return Ok(st);

        }

    }
}


