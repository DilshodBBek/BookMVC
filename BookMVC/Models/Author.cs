namespace BookMVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Author> AllAuthors()
        {
             return new List<Author>
            {
                new(){Id=1, Name="Abdulla Qodiriy"},
                new(){Id=2, Name="Abdulla Qodiriy"},
                new(){Id=3, Name="Gofur Gulom"},
                new(){Id=4, Name="No name"},
                new(){Id=5, Name="Jorj Oruel"},
            };
        }
    }
}
