namespace MoviesAPI.DTOs;

public class MovieResponseDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }

    public int GenreId { get; set; }
    public string GenreName { get; set; } = string.Empty;
}