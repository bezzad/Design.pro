using Microsoft.AspNetCore.Hosting;
using TeleBanel;

namespace Design.pro.Helpers
{
    public static class BotHelper
    {

        public static IWebHostBuilder UseTelegramBot(this IWebHostBuilder webHostBuilder, string botApiKey, string botPass)
        {
            var bot = new BotManager(botApiKey, botPass);
            bot.StartListening();

            return webHostBuilder;
        }
    }
}