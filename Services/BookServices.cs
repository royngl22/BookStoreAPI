using System;
using BookStoreAPI.Entities;
using BookStoreAPI.Interfaces;
using BookStoreAPI.Models;
using BookStoreAPI.Repositories;

namespace BookStoreAPI.Services
{
    public class BookServices : IBookServices
    {
        private IBookRepository _iBookRepository;

        public BookServices(IBookRepository iBookRepository)
        {
            _iBookRepository = iBookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            var result = await _iBookRepository.GetBooks();
            return result.ToList();
        }
    }
}
