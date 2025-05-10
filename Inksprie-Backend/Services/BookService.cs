using Inksprie_Backend.Data;
using Inksprie_Backend.Dtos;
using Inksprie_Backend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inksprie_Backend.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookDto>> GetBooksAsync(string? search = null)
        {
            var query = _context.Books.AsQueryable();

            if (!string.IsNullOrEmpty(search))
                query = query.Where(b => b.Title.Contains(search) || b.Author.Contains(search));

            return await query.Select(b => new BookDto
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Price = b.Price,
                Genre = b.Genre,
                IsOnSale = b.IsOnSale,
                DiscountPrice = b.DiscountPrice
            }).ToListAsync();
        }
    }
}
