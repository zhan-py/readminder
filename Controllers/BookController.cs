using Microsoft.AspNetCore.Mvc;
using summary.Data;
using summary.Data.Services;

namespace summary.Controllers
{
    [Route("api/[controller]")]
    public class BookController:Controller
    {
        private IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }

        //add book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }

        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }


        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {
            _service.UpdateBook(id, book);
            return Ok(book);
        }

        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookByID(int id) 
        { 
            var book = _service.GetBookById(id);
            return Ok(book);
        }
    }
}
