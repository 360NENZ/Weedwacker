using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class SdkDataUpload : IHandler
    {
        //Note: client may send a list of jsons like this : [{...},{...}]
        public class SdkDataUploadReqJson
        {
            public int applicationId { get; set; } = 900001;
            public string applicationName { get; set; } = "mihoyosdk";
            public string msgId { get; set; }
            public string eventTime { get; set; }
            public int eventId { get; set; } = 900001;
            public string eventName { get; set; } = "UserBehavior";
            public UploadContent uploadContent { get; set; } = new();
            public class UploadContent
            {
                public DeviceInfo deviceInfo { get; set; } = new();
                public UserInfo userInfo { get; set; } = new();
                public VersionInfo versionInfo { get; set; } = new();
                public class DeviceInfo
                {
                    public int platform { get; set; }
                    public string systemInfo { get; set; }
                    public string deviceId { get; set; }
                    public string deviceName { get; set; }
                    public string deviceModel { get; set; }
                    public string bundleId { get; set; } = "hk4e_global";
                    public string device_fp { get; set; } = "";
                    public int device_sciX { get; set; }
                    public int device_sciY { get; set; }
                    public int soft_sciX { get; set; }
                    public int soft_sciY { get; set; }
                    public double romCapacity { get; set; }
                    public double romRemain { get; set; }
                    public double ramCapacity { get; set; }
                    public double ramRemain { get; set; }
                    public string addressMac { get; set; }
                    public string gpuName { get; set; }
                    public double gpuMemSize { get; set; }
                    public int processorCount { get; set; }
                    public double processorFrequency { get; set; }
                    public string processorType { get; set; }
                }
                public class UserInfo
                {
                    public string userId { get; set; } = "";
                    public string accountType { get; set; } = "";
                    public string accountId { get; set; } = "3";
                    public string channelId { get; set; } = "1";
                }
                public class VersionInfo
                {
                    public string clientVersion { get; set; }
                    public string logVersion { get; set; }
                    public LogInfo logInfo { get; set; } = new();
                    public class LogInfo
                    {
                        public string logTime { get; set; }
                        public int actionId { get; set; } = 100;//,102
                        public string actionName { get; set; } = "main";//,"login"
                        public CBody cBody { get; set; } = new();
                        public class CBody
                        {
                            public string mac_address { get; set; }
                            public int type { get; set; } = 0;//,2
                            public int stage { get; set; } = 1;//,4,3
                            public string gamebiz { get; set; } = "hk4e_global";
                            public int env { get; set; } = 2;
                            public string channelId { get; set; } = "1";
                            public string subchannelId { get; set; } = "3";                         

                        }
                    }
                }
            }

        }
        public class SdkDataUploadResJson
        {
            public int code { get; set; } = 0;
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new SdkDataUploadResJson());
            return true;
        }
    }
}
