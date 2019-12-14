using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Third
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
            app.Map("/1", First);
            app.Map("/2", Second);
 
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello! Choose your formula:\r\n" +
                                                  "1. N = 2 * sin(x) * cos(y) / (x + y) ^ z \r\n" +
                                                  "2. N = ((x * (sqrt(x) + y^3)) / Pi) ");
            });
        }
 
        private static void First(IApplicationBuilder app)
        {
            double a = 10;
            double b = 100;
            double c = 2;
            double n = 0;
            app.Use(async (context, next) =>
            {
                n = 2 * Math.Sin(a) * Math.Cos(b) / Math.Pow(a + b, c);
                await next.Invoke();
            });
 
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"a = 10\r\n" +
                                                  $"b = 100\r\n" +
                                                  $"c = 2\r\n" +
                                                  $"2 * sin(x) * cos(y) / (x + y) ^ z = {n}");
            });
        }
        private static void Second(IApplicationBuilder app)
        {
            double r = 9;
            double t = 100;
            double n = 0;
            app.Use(async (context, next) =>
            {
                n = ((r * (Math.Sqrt(r) + Math.Pow(t, 3))) / Math.PI);
                await next.Invoke();
            });
 
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"r = 9\r\n" +
                                                  $"t = 100\r\n" +
                                                  $"((x * (sqrt(x) + y^3)) / Pi) = {n}");
            });
        }
    }
}