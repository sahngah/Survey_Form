using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace DojoSurvey
{
    public class Startup
    {
        public void Configure(IApplicationBuilder App)
        {
            App.UseMvc();     
            App.UseStaticFiles();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}
