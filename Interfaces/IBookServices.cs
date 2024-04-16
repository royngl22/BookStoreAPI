using BookStoreAPI.Entities;
using BookStoreAPI.Models;

namespace BookStoreAPI.Interfaces
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
