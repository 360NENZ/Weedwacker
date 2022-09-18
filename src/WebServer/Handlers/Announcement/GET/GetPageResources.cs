using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    internal class GetPageResources : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            try
            {
                string filestream = await File.ReadAllTextAsync(context.Request.Path);
                new FileExtensionContentTypeProvider().TryGetContentType(WebServer.Configuration.structure.data + context.Request.Path, out string? contentType);
                context.Request.ContentType = contentType ?? System.Net.Mime.MediaTypeNames.Application.Octet;
                await context.Response.WriteAsync(filestream);
            }
            catch
            {
                if (WebServer.Configuration.Server.LogPackets == Shared.Enums.ServerDebugMode.MISSING)
                {
                    Logger.WriteLine("Could not find file: " + WebServer.Configuration.structure.data + context.Request.Path);
                }
                context.Response.StatusCode = 404;
            }
            return true;
        }
    }
}