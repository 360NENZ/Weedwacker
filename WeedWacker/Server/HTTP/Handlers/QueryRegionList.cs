using Weedwacker.Server;
using Ceen;

namespace Weedwacker.Server.HTTP.Handlers
{
    internal class QueryRegionList : IHttpModule
    {
        public Task<bool> HandleAsync(IHttpContext context)
        {
            //TODO implement event system and add this event
        
            //context.Response = RegionManager.QueryRegionList();

            // Log to console.
            Logger.WriteLine(String.Format("[Dispatch] Client {0}s request: query_region_list", context.GetRemoteIP()));
            return Task.FromResult(true);
        }

    }
}
