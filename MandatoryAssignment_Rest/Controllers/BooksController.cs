using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MandatoryAssignment_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public static List<Book> BookList = new List<Book>
        {
            new Book("1234567896543","Popular","FreedomFighter",68,"SocialStudies"),
            new Book("1239567896542","Khem","CountryLove",108,"SocialStudies"),
            new Book("1234767896943","Ganga","HealthInstructor",98,"HealthScience"),
            new Book("1234562965743","Boris","ViceCity",58,"Games"),
            new Book("1234568896513","Michel","Algebra",68,"Mathematics"),
            new Book("1234567896842","William","Lyrics",65,"MusicsStudies"),
        }
        // GET: api/Items
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return BookList;
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            
        }

        // POST: api/Items
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
