using Ceen;
namespace Weedwacker.Server.HTTP.Handlers
{
    internal class RiskyAPICheck : IHttpModule
    {
        public Task<bool> HandleAsync(IHttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
