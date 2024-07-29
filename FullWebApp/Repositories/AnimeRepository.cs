using FullWebApp.DTOs.WorkoutDTOs;
using FullWebApp.Interfaces;
using FullWebApp.Models;

namespace FullWebApp.Repositories;

public class AnimeRepository : IAnimeRepository
{
    public Task<List<Anime>> GetAllAnime()
    {
        throw new NotImplementedException();
    }

    public Task<Anime?> GetAnimetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Anime?> CreateAnimeAsync(Anime workout)
    {
        throw new NotImplementedException();
    }

    public Task<Anime?> UpdateAnimeAsync(int id, UpdateAnimeDto animeDto)
    {
        throw new NotImplementedException();
    }

    public Task<Anime?> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Anime?> Exists(int id)
    {
        throw new NotImplementedException();
    }
}