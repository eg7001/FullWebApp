namespace FullWebApp.Models;

public class Manga
{
    public int MangaId;
    public int Chapters;
    public string Name;
    public double Rating;
    public enum AiringStatus
    {
        Releasing,
        Finished,
        NotYetReleased,
        Hiatus
    }
}