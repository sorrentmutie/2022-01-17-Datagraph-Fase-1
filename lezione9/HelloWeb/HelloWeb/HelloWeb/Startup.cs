using HelloWeb.Interfacce;
using HelloWeb.Interfacce.Implementazioni;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace HelloWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddSingleton<IGestioneTempo, TempoFinto>();
             services.AddScoped<IGestioneTempo, TempoFinto>();
            //services.AddTransient<IGestioneTempo, TempoFinto>();
            services.AddScoped<ISaluto, GeneratoreSaluto>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
                              ISaluto saluto, ILogger<Startup> logger)
        {

            // app.UseWelcomePage();
            app.UseStaticFiles();

            if (env.IsEnvironment("development"))
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async contestoHttp =>
            //   {
            //       await contestoHttp.Response.WriteAsync("Mio primo middleware");
            //   });



            app.Use( async (contestoHttp, next) => {
                logger.LogError("Sono nel mio primo middleware");
                var indirizzoRichiesta = contestoHttp.Request.Path;
                logger.LogError($"{indirizzoRichiesta}");
                await next.Invoke();
            });


            app.Use(async (contestoHttp, next) => {
                logger.LogError("Sono nel mio secondo middleware");
                await next.Invoke();
            });

            app.Use(async (contestoHttp, next) =>
            {
                if (contestoHttp.Request.Path.StartsWithSegments("/pippo"))
                {
                    await contestoHttp.Response.WriteAsync("Esci fuori disgraziato");
                } else
                {
                    await next.Invoke();
                }
            });


            

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                   // throw new Exception("errore gravissimo");
                    //var oraCorrente = new TempoServer().OraCorrente();
                    await context.Response.WriteAsync($"{saluto.EstraiSaluto()}");
                });
            });
        }
    }
}
