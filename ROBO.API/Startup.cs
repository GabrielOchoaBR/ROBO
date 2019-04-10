using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Converters;
using ROBO.Aplicacao;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Servico;

namespace ROBO.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
            });

            services.AddSingleton<IRobo, Robo>();

            services.AddTransient<ICabecaInclinacaoAppServico, CabecaInclinacaoAppServico>();
            services.AddTransient(typeof(ICabecaInclinacaoServico), typeof(CabecaInclinacaoServico));

            services.AddTransient<ICabecaRotacaoAppServico, CabecaRotacaoAppServico>();
            services.AddTransient(typeof(ICabecaRotacaoServico), typeof(CabecaRotacaoServico));

            services.AddTransient<IPulsoEsquerdoAppServico, PulsoEsquerdoAppServico>();
            services.AddTransient(typeof(IPulsoEsquerdoServico), typeof(PulsoEsquerdoServico));

            services.AddTransient<IPulsoDireitoAppServico, PulsoDireitoAppServico>();
            services.AddTransient(typeof(IPulsoDireitoServico), typeof(PulsoDireitoServico));

            services.AddTransient<ICotoveloEsquerdoAppServico, CotoveloEsquerdoAppServico>();
            services.AddTransient(typeof(ICotoveloEsquerdoServico), typeof(CotoveloEsquerdoServico));

            services.AddTransient<ICotoveloDireitoAppServico, CotoveloDireitoAppServico>();
            services.AddTransient(typeof(ICotoveloDireitoServico), typeof(CotoveloDireitoServico));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Something went wrong. Please contact Gabriel Ochoa on go@gabrielochoa.me and report it.");
            });
        }
    }
}
