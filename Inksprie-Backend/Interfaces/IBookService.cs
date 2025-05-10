using Inksprie_Backend.Dtos;

namespace Inksprie_Backend.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetBooksAsync(string? search = null);

    }
}
