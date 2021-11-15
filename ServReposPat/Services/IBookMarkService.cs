using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat.Services
{
    public interface IBookMarkService
    {
        List<BookMark> GetBookMarks(Guid isbn);
    }
}
