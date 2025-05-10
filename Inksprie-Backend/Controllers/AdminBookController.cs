using Inksprie_Backend.Entities;
using Inksprie_Backend.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inksprie_Backend.Controllers
{
    [ApiController]
    [Route("api/admin/[controller]")]
    [Authorize]
    public class AdminBookController : ControllerBase
    {
        private readonly IAdminBookService _adminBookService;

        public AdminBookController(IAdminBookService adminBookService)
        {
            _adminBookService = adminBookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _adminBookService.GetAllAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var book = await _adminBookService.GetByIdAsync(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            var created = await _adminBookService.CreateAsync(book);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Book book)
        {
            var updated = await _adminBookService.UpdateAsync(id, book);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _adminBookService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
