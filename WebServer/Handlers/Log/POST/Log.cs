using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class Log : IHandler
    {
        public class LogReqJson
        {
            public string userName { get; set; }
            public string time { get; set; }
            public string frame { get; set; }
            public string stackTrace { get; set; }
            public string logStr { get; set; }
            public string logType { get; set; }
            public string deviceName { get; set; }
            public string deviceModel { get; set; }
            public string operatingSystem { get; set; }
            public string version { get; set; }
            public string exceptionSerialNum { get; set; }
            public string pos { get; set; }
            public string guid { get; set; }
            public string errorCode { get; set; }
            public int errorCodeToPlatform { get; set; }
            public string serverName { get; set; }
            public int subErrorCode { get; set; }
            public int uid { get; set; }
            public string cpuInfo { get; set; }
            public string gpuInfo { get; set; }
            public string memoryInfo { get; set; }
            public string clientIp { get; set; }
            public string errorLevel { get; set; }
            public string errorCategory { get; set; }
            public string notifyUserName { get; set; }
            public string auid { get; set; }
            public string buildUrl { get; set; }
        }
        public class LogResJson
        {
            public int code { get; set; } = 0;
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new LogResJson());
            return true;
        }
    }
}

