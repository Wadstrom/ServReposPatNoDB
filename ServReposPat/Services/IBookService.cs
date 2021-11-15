using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
    }
}
