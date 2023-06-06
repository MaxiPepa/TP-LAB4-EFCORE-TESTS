using TP_LAB4_EFCORE_TESTS.Data.Entities;

namespace TP_LAB4_EFCORE_TESTS.Data
{
    public class FakeDB
    {
        public List<Movie> Movies = new()
        {
            new Movie(1, "Spiderman Homecoming", "Action", 2.15, 175000000, new List<Actor>
            {
                new Actor(1, "Tom Holland", "Picture", new DateTime(1996, 06, 01)),
                new Actor(2, "Zendaya", "Picture", new DateTime(1996,09, 01)),
                new Actor(3, "Robert Downey Jr.", "Picture", new DateTime(1965, 04, 04))
            }),

            new Movie(2, "Megan", "Horror/Cience Fiction", 1.75, 12000000, new List<Actor>
            {
                new Actor(4, "Amie Donald", "Picture", new DateTime(2010, 01, 28)),
                new Actor(5, "Allison Williams", "Picture", new DateTime(1998, 04, 13)),
                new Actor(6, "Violet McGraw", "Picture", new DateTime(2011, 04, 22))
            }),

            new Movie(3, "Midsommar", "Horror", 3, 9000000, new List<Actor>
            {
                new Actor(7, "Florence Pugh", "Picture", new DateTime(1996, 01, 03)),
                new Actor(8, "Will Poulter", "Picture", new DateTime(1993, 01, 28)),
                new Actor(9, "Jack Reynor", "Picture", new DateTime(1992, 01, 23))
            })
        };
    }
}
