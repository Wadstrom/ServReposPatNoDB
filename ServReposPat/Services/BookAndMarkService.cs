using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServReposPat.Models;
using ServReposPat.Repos;
namespace ServReposPat
{
    public interface IBookAndMarkService
    {
        BookAndMark GetBookAndMark();
    }
    public class BookAndMarkService : IBookAndMarkService
    {
        private readonly IBookMark _bookMarkRepo;
        private readonly IBook _bookRepo;

        public BookAndMarkService(IBook book, IBookMark bookMark)
        {
            _bookMarkRepo = bookMark;
            _bookRepo = book;
        }

        public BookAndMark GetBookAndMark()
        {
            
          var book = _bookRepo.GetBooks().FirstOrDefault();
          var bookmarkList =  _bookMarkRepo.GetBookMarks(book.ISBN);
           
          var bookmarks = from isbn in bookmarkList where isbn.ISBN == book.ISBN select isbn;

          var bookandmark=  new BookAndMark() { Book = book, bookMarks = bookmarks.ToList() };
            return bookandmark;
        }
    }

}
