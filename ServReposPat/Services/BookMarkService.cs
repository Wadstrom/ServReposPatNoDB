using ServReposPat.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat.Services
{
    public class BookMarkService :IBookMarkService
    {
        private readonly IBookMark _bookmark;

        public BookMarkService(IBookMark bookMarkRepo)
        {
            _bookmark = bookMarkRepo;
        }
        public List<BookMark> GetBookMarks(Guid isbn)
        {
            return _bookmark.GetBookMarks(isbn);


        }
      
    }
}
