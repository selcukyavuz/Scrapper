 using Microsoft.Extensions.Configuration;

namespace Scrapper // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true);
            var config = builder.Build();
            var service = new Service();

            var newHighsResult = service.GetRecords<Models.NewHighs>(config["NewHighs"]!);
            Console.WriteLine(newHighsResult!.data.Count.ToString());

            var breakoutRangeResult = service.GetRecords<Models.BreakoutRange>(config["BreakoutRange"]!);
            Console.WriteLine(breakoutRangeResult!.data.Count.ToString());

            var breakoutDayResult = service.GetRecords<Models.BreakoutDay>(config["BreakoutDay"]!);
            Console.WriteLine(breakoutDayResult!.data.Count.ToString());

            var upOnHighRVolResult = service.GetRecords<Models.UpOnHighRVol>(config["UpOnHighRVol"]!);
            Console.WriteLine(upOnHighRVolResult!.data.Count.ToString());

            var gapUpResult = service.GetRecords<Models.UpOnHighRVol>(config["GapUp"]!);
            Console.WriteLine(gapUpResult!.data.Count.ToString());

            var movingUpNowResult = service.GetRecords<Models.MovingUpNow>(config["MovingUpNow"]!);
            Console.WriteLine(movingUpNowResult!.data.Count.ToString());
        }
    }
}