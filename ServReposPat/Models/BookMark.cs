using System;

namespace ServReposPat
{
    //- Skapa en modell för bokmärken som har attributen: Id, en boks id, sidnummer, radnummer.

    public class BookMark
    {
        public int id { get; set; }
        public Guid ISBN { get; set; }
        public int pagenumber { get; set; }
        public int rownumber { get; set; }
        public BookMark(Guid isbn)
        {
            ISBN = isbn;
        }
    }
}
