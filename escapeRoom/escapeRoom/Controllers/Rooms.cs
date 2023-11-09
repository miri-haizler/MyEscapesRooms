using escapeRoom.Entities;
using Microsoft.AspNetCore.Mvc;

using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace escapeRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rooms : ControllerBase
    {

        public static List<Room_class> roomsList = new List<Room_class>() { 
        new Room_class(10,"Kind Shlomo",true),new Room_class(20,"Prag room",false),new Room_class(30,"Zofen",true),new Room_class(40,"Hayara",true)
        };

        // GET: api/<Rooms>
        [HttpGet]
        public List<Room_class> Get()
        {
            return roomsList;
        }

        // GET api/<Rooms>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Room_class room = roomsList.Find(x => x.Id == id);
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
            roomsList.Add(value);
        }

        // PUT api/<Rooms>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Room_class value)
        {
            Room_class update = roomsList.Find(x => x.Id == id);
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
            Room_class st = roomsList.Find(x => x.Id == id);
            if (st == null)
            {
                return NotFound();
            }
            st.IsOpen = status;
            return Ok(st);

        }

    }
}


