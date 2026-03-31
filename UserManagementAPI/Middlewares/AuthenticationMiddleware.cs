using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace UserManagementAPI.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Simple authorization check based on token for the sake of the exercise
            if (!context.Request.Headers.TryGetValue("Authorization", out var extractedToken))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsJsonAsync(new { error = "401 Unauthorized" });
                return;
            }

            // In a real application, token string would be retrieved differently
            var token = extractedToken.ToString();
            if (string.IsNullOrEmpty(token) || !token.StartsWith("Bearer ") || token.Length <= 7)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsJsonAsync(new { error = "401 Unauthorized" });
                return;
            }
            
            // Further token validation usually goes here
            await _next(context);
        }
    }
}
