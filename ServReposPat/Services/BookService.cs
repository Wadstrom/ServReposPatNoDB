using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat.Services
{
    public class BookService : IBookService
    {
        
            private readonly IBook _bookrepo;

            public BookService(IBook book)
            {
                _bookrepo = book;
            }

        public List<Book> GetBooks()
        {
            return _bookrepo.GetBooks();
        }
    }
}
