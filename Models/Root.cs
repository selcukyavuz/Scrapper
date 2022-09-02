namespace Scrapper.Models
{
    public record Root<T>(List<T> data) where T : class;
}