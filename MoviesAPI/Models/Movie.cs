namespace MoviesAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }

        public int GenreId { get; set; }
        public Genre? Genre { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}