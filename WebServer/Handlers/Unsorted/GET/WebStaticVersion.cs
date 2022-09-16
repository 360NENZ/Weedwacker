using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    internal class WebStaticVersion : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            string requestFor = context.Request.Path.ToString().Substring(context.Request.Path.ToString().LastIndexOf("-") + 1);

            await GetPageResources("/webstatic/" + requestFor, context);
            return true;
        }

        private static async Task GetPageResources(string path, HttpContext context)
        {
            try
            {
                string filestream = await File.ReadAllTextAsync(path);
                new FileExtensionContentTypeProvider().TryGetContentType(WebServer.Configuration.structure.data + path, out string? contentType);
                context.Request.ContentType = contentType ?? System.Net.Mime.MediaTypeNames.Application.Octet;
                await context.Response.WriteAsync(filestream);
            }
            catch
            {
                if (WebServer.Configuration.Server.LogPackets == Shared.Enums.ServerDebugMode.MISSING)
                {
                    Logger.WriteLine("Webstatic File Missing: " + path);
                }
                context.Response.StatusCode = 404;
            }
        }
    }
}
