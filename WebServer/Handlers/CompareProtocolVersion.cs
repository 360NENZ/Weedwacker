using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class CompareProtocolVersion : IHandler
    {
        public Task<bool> HandleAsync(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
