using Inksprie_Backend.Data;
using Inksprie_Backend.Entities;
using Inksprie_Backend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inksprie_Backend.Services
{
    public class AdminBookService : IAdminBookService
    {
        private readonly ApplicationDbContext _context;

        public AdminBookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<Book> CreateAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> UpdateAsync(Guid id, Book book)
        {
            var existing = await _context.Books.FindAsync(id);
            if (existing == null) return null;

            existing.Title = book.Title;
            existing.Author = book.Author;
            existing.Price = book.Price;
            existing.Genre = book.Genre;
            existing.Description = book.Description;
            existing.Publisher = book.Publisher;
            existing.Stock = book.Stock;
            existing.Language = book.Language;
            existing.Format = book.Format;
            existing.PublishedDate = book.PublishedDate;
            existing.IsOnSale = book.IsOnSale;
            existing.DiscountPrice = book.DiscountPrice;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null) return false;

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
