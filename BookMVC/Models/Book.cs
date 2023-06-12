namespace BookMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static List<Book> GetAllBooks()
        {
            return new List<Book>
            {
                new(){Id=1, Name="O`tkan kunlar"},
                new(){Id=2, Name="Mehrobdan chayon"},
                new(){Id=3, Name="Shum bola"},
                new(){Id=4, Name="Susambil"},
                new(){Id=5, Name="Molxona"},
            };
        }
    }
}
