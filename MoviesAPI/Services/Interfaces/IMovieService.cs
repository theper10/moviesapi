using MoviesAPI.DTOs;

namespace MoviesAPI.Services.Interfaces;

public interface IMovieService
{
    Task<IEnumerable<MovieResponseDto>> GetAllAsync();
    Task<MovieResponseDto?> GetByIdAsync(int id);
    Task<MovieResponseDto> CreateAsync(MovieCreateDto dto);
    Task<bool> UpdateAsync(int id, MovieUpdateDto dto);
    Task<bool> PatchRatingAsync(int id, MoviePatchDto dto);
    Task<bool> DeleteAsync(int id);
}