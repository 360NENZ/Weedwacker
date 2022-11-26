using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class RedDotList : IHandler
    {
        public class RedDotListReqJson
        {
            public string uid { get; set; }
            public string region { get; set; }
            public string game_biz { get; set; }
            public string player_level { get; set; }
        }
        public class RedDotListResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public List<Infos> infos { get; set; } = new() { new Infos() };
                public class Infos
                {
                    public int red_point_type { get; set; } = 2201;
                    public int content_id { get; set; } = 77;
                    public bool display { get; set; } = true;
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new RedDotListResJson());
            return true;
        }
    }
}
