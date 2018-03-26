using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ourakoz.GaiaAPI.Models;

namespace ourakoz.GaiaAPI
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CardContext>(opt => opt.UseSqlServer(Program.Configuration.GetConnectionString("GaiaContext")));
            services.AddMvc();
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}