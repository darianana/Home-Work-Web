using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace Third
{
    public class Demidovich
    {
        private readonly RequestDelegate _next;
        
        public Demidovich(RequestDelegate next)
        {
            this._next = next;
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            double a = 10;
            double b = 100;
            double c = 2;
            double n = 0;
            n = 2 * Math.Sin(a) * Math.Cos(b) / Math.Pow(a + b, c);
            await context.Response.WriteAsync($"Hello, it's  middleware!\r\n" +
                                              $"a = 10\r\n" +
                                              $"b = 100\r\n" +
                                              $"2 * sin(x) * cos(y) / (x + y) ^ z = {n}");
        } 
    }
}