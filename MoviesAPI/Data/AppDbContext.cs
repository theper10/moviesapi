using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Genre> Genres => Set<Genre>();
    public DbSet<Review> Reviews => Set<Review>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Action" },
            new Genre { Id = 2, Name = "Drama" },
            new Genre { Id = 3, Name = "Sci-Fi" }
        );

        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Title = "Inception", ReleaseYear = 2010, Rating = 8.8, GenreId = 3 },
            new Movie { Id = 2, Title = "Gladiator", ReleaseYear = 2000, Rating = 8.5, GenreId = 1 },
            new Movie { Id = 3, Title = "The Shawshank Redemption", ReleaseYear = 1994, Rating = 9.3, GenreId = 2 }
        );

        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, Comment = "Amazing movie", Score = 9, MovieId = 1 },
            new Review { Id = 2, Comment = "Very emotional", Score = 10, MovieId = 3 }
        );
    }
}