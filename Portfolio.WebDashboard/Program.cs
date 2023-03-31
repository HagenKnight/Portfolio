using Microsoft.AspNetCore;
using Portfolio.WebDashboard.ServiceCollection;

namespace Portfolio.WebDashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();      //Startup class is registered here
    }
}