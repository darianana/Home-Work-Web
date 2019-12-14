using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace fifth
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;

        public RoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if (path == "/task1")
            {
                await context.Response.WriteAsync("Hello World!");
            }
            else if (path == "/task2")
            {
                double x = 10;
                double k = 100;
                double n = 0;
                n = Math.Log10(Math.Sin(Math.PI / x)) * k;
                await context.Response.WriteAsync($"x = 10\r\n" +
                                                  $"k = 100\r\n" +
                                                  $"lg(sin(Pi/x) * k = {n}");
            }
            else
            {
                context.Response.StatusCode = 404;
            }

            //await _next.Invoke(context);
        }
    }
}