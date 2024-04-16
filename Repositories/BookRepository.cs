using BookStoreAPI.Entities;
using BookStoreAPI.Interfaces;
using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookStoresDbContext _dbContext;

        public BookRepository(BookStoresDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            var result = await _dbContext.Books.ToListAsync();
            return result;
        }
    }
}
