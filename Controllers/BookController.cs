using BookStoreAPI.Entities;
using BookStoreAPI.Interfaces;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private IBookServices _iBookServices;

        public BookController(IBookServices iBookServices)
        {
            _iBookServices = iBookServices;
        }

        [HttpGet("GetAllBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {

            var result =  await _iBookServices.GetAllBooks();
            return StatusCode(200, result);
        }
    }
}
