using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat
{
    public interface IBookMark
    {
       
        List<BookMark> GetBookMarks(Guid isbn);
    }
}
