using Ceen;
namespace Weedwacker.Server.HTTP.Handlers
{
    internal class QueryCurrentRegion : IHttpModule
    {
        public Task<bool> HandleAsync(IHttpContext context)
        {
            RegionManager.QueryCurrentRegion(context);
            return Task.FromResult(true);
        }
    }
}
