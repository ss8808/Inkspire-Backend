using Inksprie_Backend.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inksprie_Backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks([FromQuery] string? search)
        {
            var books = await _bookService.GetBooksAsync(search);
            return Ok(books);
        }
    }
}
