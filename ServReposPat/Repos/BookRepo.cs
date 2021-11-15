using System;
using System.Collections.Generic;

namespace ServReposPat.Repos
{
    public class BookRepo : IBook
    {
        public  List<Book> GetBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                id = 1,
                ISBN = Guid.NewGuid(),
                titel = "Service Repository Pattern for dummies"
                },

            new Book()
            {
                id = 2,
                ISBN = Guid.NewGuid(),
                titel = "Landing your first job as a developer"
            },
             new Book()
            {
                id = 3,
                ISBN = Guid.NewGuid(),
                titel = "You can do it!"
            }
        };
            return books;
        }
    }
}
