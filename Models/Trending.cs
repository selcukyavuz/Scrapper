namespace Scrapper.Models
{
    public record Trending(
        int xindex,
        string sstime,
        string sscode,
        string ssname,
        string ssarrow,
        string sslast,
        string sshigh,
        string sschg,
        string sschgp,
        string ssvol,
        string ssrvol,
        string _5d,
        string sscap,
        string sscomment
        );
}