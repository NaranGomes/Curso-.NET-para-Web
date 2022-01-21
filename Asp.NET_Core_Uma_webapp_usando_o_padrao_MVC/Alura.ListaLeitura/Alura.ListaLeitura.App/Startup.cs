using Alura.ListaLeitura.App.Logica;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvcCore();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }       
                   
    }
}