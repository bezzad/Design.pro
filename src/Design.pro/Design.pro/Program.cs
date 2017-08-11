using System.IO;
using Design.pro.Helpers;
using Design.pro.Properties;
using Microsoft.AspNetCore.Hosting;

namespace Design.pro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .UseTelegramBot(Resources.BotApiKey, Resources.BotApiPassword)
                .Build();

            host.Run();

        }
    }
}
