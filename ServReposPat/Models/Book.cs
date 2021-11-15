using System;

namespace ServReposPat
{
    /// <summary>
    ///  id, ISBN, titel. (ISBN är ett unikt id för publikationer)
    /// </summary>
    public class Book
    {
        public int id { get; set; }
        public Guid ISBN { get; set; }
        public string titel { get; set; }


    }
}
