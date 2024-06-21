using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VisioForge_SDK_Video_Capture_Demo.Models;

namespace VisioForge_SDK_Video_Capture_Demo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            System.Console.WriteLine("Startup.ConfigureServices!");
            services.AddDbContext<MyDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
        }

    }
}
