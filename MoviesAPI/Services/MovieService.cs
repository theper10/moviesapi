using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.DTOs;
using MoviesAPI.Models;
using MoviesAPI.Services.Interfaces;

namespace MoviesAPI.Services;

public class MovieService : IMovieService
{
    private readonly AppDbContext _context;

    public MovieService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<MovieResponseDto>> GetAllAsync()
    {
        return await _context.Movies
            .Include(m => m.Genre)
            .Select(m => new MovieResponseDto
            {
                Id = m.Id,
                Title = m.Title,
                ReleaseYear = m.ReleaseYear,
                Rating = m.Rating,
                GenreId = m.GenreId,
                GenreName = m.Genre != null ? m.Genre.Name : string.Empty
            })
            .ToListAsync();
    }

    public async Task<MovieResponseDto?> GetByIdAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie == null)
        {
            return null;
        }

        return new MovieResponseDto
        {
            Id = movie.Id,
            Title = movie.Title,
            ReleaseYear = movie.ReleaseYear,
            Rating = movie.Rating
        };
    }

    public async Task<MovieResponseDto> CreateAsync(MovieCreateDto dto)
    {
        var genreExists = await _context.Genres.AnyAsync(g => g.Id == dto.GenreId);
        if (!genreExists)
            throw new Exception("Genre not found");

        var movie = new Movie
        {
            Title = dto.Title,
            ReleaseYear = dto.ReleaseYear,
            Rating = dto.Rating,
            GenreId = dto.GenreId
        };

        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();

        var genre = await _context.Genres.FindAsync(dto.GenreId);

        return new MovieResponseDto
        {
            Id = movie.Id,
            Title = movie.Title,
            ReleaseYear = movie.ReleaseYear,
            Rating = movie.Rating,
            GenreId = movie.GenreId,
            GenreName = genre?.Name ?? string.Empty
        };
    }

    public async Task<bool> UpdateAsync(int id, MovieUpdateDto dto)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie == null)
        {
            return false;
        }

        movie.Title = dto.Title;
        movie.ReleaseYear = dto.ReleaseYear;
        movie.Rating = dto.Rating;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie == null)
        {
            return false;
        }

        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> PatchRatingAsync(int id, MoviePatchDto dto)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie == null)
        {
            return false;
        }

        movie.Rating = dto.Rating;

        await _context.SaveChangesAsync();
        return true;
    }
}

