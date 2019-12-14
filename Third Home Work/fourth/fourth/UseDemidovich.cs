using Microsoft.AspNetCore.Builder;
namespace Third
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseDemidovich(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Demidovich>();
        }
    }
}