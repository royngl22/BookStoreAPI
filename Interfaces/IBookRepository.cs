using BookStoreAPI.Entities;
using BookStoreAPI.Models;

namespace BookStoreAPI.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
    }
}
