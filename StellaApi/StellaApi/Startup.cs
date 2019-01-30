using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ourakoz.StellaApi.Models;

namespace ourakoz.StellaApi
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CardContext>(opt => opt.UseSqlServer(Program.Configuration.GetConnectionString("StellaContext")));
            services.AddMvc();
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}