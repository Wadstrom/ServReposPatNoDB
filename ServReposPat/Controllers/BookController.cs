using Microsoft.AspNetCore.Mvc;
using ServReposPat.Services;
using System.Collections.Generic;

namespace ServReposPat.Controllers
{
    // Skapa en ny controller i webapi-et som hanterar affärslogik för Böcker.
    // Skapa en metod i controllern som syftar till att hämta alla böcker, men lämna metoden tom nu.
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookservice;

            public BookController(IBookService service)
        {
            _bookservice = service;
        }
        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            IEnumerable<Book> books = _bookservice.GetBooks();
            return books;
        }
       
    }
}
