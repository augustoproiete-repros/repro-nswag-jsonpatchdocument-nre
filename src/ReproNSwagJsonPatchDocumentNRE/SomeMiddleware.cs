using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ReproNSwagJsonPatchDocumentNRE
{
    public class SomeMiddleware
    {
        private readonly RequestDelegate _next;

        public SomeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext); // BOOM!
        }
    }
}
