using Inksprie_Backend.Entities;

namespace Inksprie_Backend.Interfaces
{
    public interface IAdminBookService
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(Guid id);
        Task<Book> CreateAsync(Book book);
        Task<Book?> UpdateAsync(Guid id, Book book);
        Task<bool> DeleteAsync(Guid id);
    }
}
