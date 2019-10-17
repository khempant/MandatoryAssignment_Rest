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
            
        };
        // GET: api/Book
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return BookList;
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(string id)
        {
            return BookList.Find(e => e.Isbn13 == id);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book newBookList)
        {
            BookList.Add(newBookList);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Book newBookList)
        {
            Delete(id);
            Post(newBookList);

        }

        private void Delete(string id)
        {
            BookList.RemoveAll(e => e.Isbn13 == id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
