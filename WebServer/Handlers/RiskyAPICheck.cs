using Ceen;
namespace Weedwacker.WebServer.Handlers
{
    internal class RiskyAPICheck : IHttpModule
    {
        public Task<bool> HandleAsync(IHttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
