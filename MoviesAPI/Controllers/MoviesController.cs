using Microsoft.AspNetCore.Mvc;
using MoviesAPI.DTOs;
using MoviesAPI.Services.Interfaces;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieResponseDto>>> GetMovies()
    {
        var movies = await _movieService.GetAllAsync();
        return Ok(movies);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MovieResponseDto>> GetMovie(int id)
    {
        var movie = await _movieService.GetByIdAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        return Ok(movie);
    }

    [HttpPost]
    public async Task<ActionResult<MovieResponseDto>> CreateMovie(MovieCreateDto dto)
    {
        var createdMovie = await _movieService.CreateAsync(dto);

        return CreatedAtAction(nameof(GetMovie), new { id = createdMovie.Id }, createdMovie);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMovie(int id, MovieUpdateDto dto)
    {
        var updated = await _movieService.UpdateAsync(id, dto);

        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        var deleted = await _movieService.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpPatch("{id}/rating")]
    public async Task<IActionResult> PatchMovieRating(int id, MoviePatchDto dto)
    {
        var updated = await _movieService.PatchRatingAsync(id, dto);

        if (!updated)
        {
            return NotFound(new { message = $"Movie with id {id} was not found." });
        }

        return NoContent();
    }
}