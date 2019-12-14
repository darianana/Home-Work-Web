using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace second
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            double x = 10;
            double k = 100;
            double n = 0;
            app.Use(async (context, next) =>
            {
                n = Math.Log10(Math.Sin(Math.PI / x)) * k;
                await next.Invoke();
            });
 
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"x = 10\r\n" +
                                                  $"k = 100\r\n" +
                                                  $"lg(sin(Pi/x) * k = {n}");
            });
        }
    }
}