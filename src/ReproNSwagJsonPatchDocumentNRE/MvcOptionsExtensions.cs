using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ReproNSwagJsonPatchDocumentNRE
{
    public static class MvcOptionsExtensions
    {
        // JSON Patch, AddNewtonsoftJson, and System.Text.Json
        // https://docs.microsoft.com/en-us/aspnet/core/web-api/jsonpatch?view=aspnetcore-3.1#json-patch-addnewtonsoftjson-and-systemtextjson

        public static MvcOptions AddNewtonsoftJsonPatchInputFormatter(this MvcOptions options)
        {
            options.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
            return options;
        }

        private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
        {
            var builder = new ServiceCollection()
                .AddLogging()
                .AddControllers()
                .AddNewtonsoftJson()
                .Services.BuildServiceProvider();

            return builder
                .GetRequiredService<IOptions<MvcOptions>>()
                .Value
                .InputFormatters
                .OfType<NewtonsoftJsonPatchInputFormatter>()
                .First();
        }
    }
}
