using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: game=hk4e_global&region=os_euro
    internal class DispatchGetGateAddress : IHandler
    {
        public class DispatchGetGateAddressResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; }
            public class Data
            {
                public List<Address> address_list { get; set; }
                public class Address
                {
                    public string ip { get; set; }
                    public int port { get; set; } = 8999;
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync("404 page not found");
            return true;
        }
    }
}
