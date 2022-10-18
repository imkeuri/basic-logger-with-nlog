using LOGGER.DEMO.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LOGGER.DEMO
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var loggerService = new LoggerService();

                    loggerService.LogDebug("HOLAAAAAA");

                    webBuilder.UseStartup<Startup>();
                });
    }
}