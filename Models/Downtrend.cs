namespace Scrapper.Models
{
    public record Downtrend(
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
        string _5d,
        string sscap,
        string sscomment);
}