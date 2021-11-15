using Microsoft.AspNetCore.Mvc;
using ServReposPat.Services;
using System.Collections.Generic;
using System.Linq;

namespace ServReposPat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookMarkController : ControllerBase
    {
        private readonly IBookMarkService _bookMarkService;
        private readonly IBook _book;
        public BookMarkController(IBookMarkService bookMarkService, IBook book)
        {
            _bookMarkService = bookMarkService;
            _book = book;
        }

        [HttpGet]
        public List<BookMark> GetBookMarks()
        {
            var listbook = _book.GetBooks().FirstOrDefault();
            var isbn = listbook.ISBN;
           return _bookMarkService.GetBookMarks(isbn);
        }
    }
}
