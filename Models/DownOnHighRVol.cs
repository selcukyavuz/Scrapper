namespace Scrapper.Models
{
    public record DownOnHighRVol(
        int xindex,
        string lotime,
        string sscode,
        string ssname,
        string ssarrow,
        string sslast,
        string sslow,
        string sschg,
        string sschgp,
        string ssvol,
        string ssrvol,
        string ss5mvol,
        string sscap,
        string sscomment);
}