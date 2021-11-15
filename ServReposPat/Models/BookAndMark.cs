using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServReposPat.Models
{
    public class BookAndMark
    {
       public Book Book { get; set; }
      public  List<BookMark> bookMarks{get;set;}
    }
}
