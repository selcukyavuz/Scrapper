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
            Console.WriteLine($"NewHighs {newHighsResult!.data.Count}");

            var breakoutRangeResult = service.GetRecords<Models.BreakoutRange>(config["BreakoutRange"]!);
            Console.WriteLine($"BreakoutRange {breakoutRangeResult!.data.Count}");

            var breakoutDayResult = service.GetRecords<Models.BreakoutDay>(config["BreakoutDay"]!);
            Console.WriteLine($"BreakoutDay {breakoutDayResult!.data.Count}");

            var upOnHighRVolResult = service.GetRecords<Models.UpOnHighRVol>(config["UpOnHighRVol"]!);
            Console.WriteLine($"UpOnHighRVol {upOnHighRVolResult!.data.Count}");

            var gapUpResult = service.GetRecords<Models.UpOnHighRVol>(config["GapUp"]!);
            Console.WriteLine($"UpOnHighRVol {gapUpResult!.data.Count}");

            var movingUpNowResult = service.GetRecords<Models.MovingUpNow>(config["MovingUpNow"]!);
            Console.WriteLine($"MovingUpNow {movingUpNowResult!.data.Count}");

            var mostActiveNowResult = service.GetRecords<Models.MostActiveNow>(config["MostActiveNow"]!);
            Console.WriteLine($"MovingUpNow {mostActiveNowResult!.data.Count}");

            var recoveringResult = service.GetRecords<Models.Recovering>(config["Recovering"]!);
            Console.WriteLine($"Recovering {recoveringResult!.data.Count}");

            var newLowResult = service.GetRecords<Models.NewLow>(config["NewLow"]!);
            Console.WriteLine($"NewLow {newLowResult!.data.Count}");

            var breakdownRangeResult = service.GetRecords<Models.BreakdownRange>(config["BreakdownRange"]!);
            Console.WriteLine($"BreakdownRange {breakdownRangeResult!.data.Count}");

            var breakdownDayResult = service.GetRecords<Models.BreakdownDay>(config["BreakdownDay"]!);
            Console.WriteLine($"BreakdownDay {breakdownDayResult!.data.Count}");

            var downOnHighRVolResult = service.GetRecords<Models.DownOnHighRVol>(config["DownOnHighRVol"]!);
            Console.WriteLine($"DownOnHighRVol {downOnHighRVolResult!.data.Count}");

            var gapdownResult = service.GetRecords<Models.Gapdown>(config["Gapdown"]!);
            Console.WriteLine($"Gapdown {gapdownResult!.data.Count}");

            var movingDownNowResult = service.GetRecords<Models.MovingDownNow>(config["MovingDownNow"]!);
            Console.WriteLine($"MovingDownNow {movingDownNowResult!.data.Count}");

            var vwapResult = service.GetRecords<Models.VWAP>(config["VWAP"]!);
            Console.WriteLine($"VWAP {vwapResult!.data.Count}");

            var pullbacksResult = service.GetRecords<Models.Pullbacks>(config["Pullbacks"]!);
            Console.WriteLine($"Pullbacks {pullbacksResult!.data.Count}");
        }
    }
}