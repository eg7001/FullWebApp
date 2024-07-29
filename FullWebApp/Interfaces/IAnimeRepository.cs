using FullWebApp.DTOs.WorkoutDTOs;
using FullWebApp.Models;

namespace FullWebApp.Interfaces;

public interface IAnimeRepository
{
    Task<List<Anime>> GetAllAnime();
    Task<Anime?> GetAnimetById(int id);
    Task<Anime?> CreateAnimeAsync(Anime workout);
    Task<Anime?> UpdateAnimeAsync(int id, UpdateAnimeDto animeDto);
    Task<Anime?> DeleteAsync(int id);
    Task<Anime?> Exists(int id);
}