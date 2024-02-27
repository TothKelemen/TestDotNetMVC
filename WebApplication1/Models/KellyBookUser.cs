namespace WebApplication1.Models
{
    public class KellyBookUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateOnly Birth {  get; set; }

        public string Email { get; set; }

        public List<Books> FavoriteBook { get; set; }

        public List<BookPublisher> FavoritePublisher { get; set; }
    }
}
