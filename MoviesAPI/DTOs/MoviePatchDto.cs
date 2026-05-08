using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.DTOs;

public class MoviePatchDto
{
    [Range(0, 10)]
    public double Rating { get; set; }
}