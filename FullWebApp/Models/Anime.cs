namespace FullWebApp.Models;

public class Anime
{
    public int AnimeId;
    public int Episodes;
    public string Name;
    public double Rating;
    public enum AiringStatus
    {
        Airing,
        NotYetReleased,
        Finished
    }
}