using System;
using System.Collections.Generic;

namespace ServReposPat.Repos
{
    public class BookMarkRepo : IBookMark
    {
        public List<BookMark> GetBookMarks(Guid isbn)
        {

            List<BookMark> bookMark = new List<BookMark>
            {
                new BookMark(isbn)
                {
                    id = 1,
                    ISBN = isbn,
                    pagenumber = 22,
                    rownumber = 4 

                },
                new BookMark(isbn)
                {
                    id = 2,
                    ISBN = isbn,
                    pagenumber = 11,
                    rownumber = 23
                },
                new BookMark(isbn)
                {
                    id = 3,
                    ISBN = isbn,
                    pagenumber = 104,
                    rownumber = 1
                }
            };
            return bookMark;
        }
    }
}
