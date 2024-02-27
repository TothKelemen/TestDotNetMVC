namespace WebApplication1.Models
{
    public class Books
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public int PageNumber { get; set; }

        public List<BookType> Types { get; set; }
    }
}
