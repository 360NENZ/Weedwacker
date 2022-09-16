using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: version=OSRELWin3.0.0&lang=1&platform=3&binary=1&time=352&channel_id=1&sub_channel_id=3&account_type=1&dispatchSeed=fdbb946d8ec3ddc3&key_id=3
    internal class QueryCurrentRegion : IHandler
    {
        public class QueryCurRegionRspJson
        {
            public string? content { get; set; }
            public string? sign { get; set; }
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            var req = context.Request;
            string last = req.Path.ToString().Split('/').Last();
            if (last == "query_cur_region")
            {
                //Not Found version config
                await context.Response.WriteAsync("CAESGE5vdCBGb3VuZCB2ZXJzaW9uIGNvbmZpZxoA");
                return true;
            }
            else
            {
                return await WithRegion(context);
            }
        }

        // /query_cur_region/{region}?{query}
        private async Task<bool> WithRegion(HttpContext context)
        {
            var req = context.Request;
            // Get region to query.
            string regionName = req.Path.ToString().Split('/').Last();
            string versionName = req.Query["version"];
            // Get region data.
            string regionData = "CAESGE5vdCBGb3VuZCB2ZXJzaW9uIGNvbmZpZw==";
            if (req.Query.Count > 0)
            {
                if (RegionManager.Regions.TryGetValue(regionName, out RegionManager.RegionData region))
                    regionData = region.base64;
            }

            string[] versionCode = new Regex("[a-zA-Z]").Replace(versionName, "").Split(".");
            int versionMajor = int.Parse(versionCode[0]);
            int versionMinor = int.Parse(versionCode[1]);
            int versionFix = int.Parse(versionCode[2]);

            if (versionMajor >= 3 || (versionMajor == 2 && versionMinor == 7 && versionFix >= 50) || (versionMajor == 2 && versionMinor == 8))
            {
                try
                {
                    //TODO QueryCurrentRegionEvent  

                    if (!req.Query.ContainsKey("dispatchSeed"))
                    {
                        
                        var response = new RegionManager.QueryCurRegionRspJson
                        {
                            content = regionData,
                            // More love for UA Patch players
                            sign = "TW9yZSBsb3ZlIGZvciBVQSBQYXRjaCBwbGF5ZXJz"
                        };

                        await context.Response.WriteAsJsonAsync(response);
                        return true;
                    }

                    string key_id = req.Query["key_id"];
                    var encryptor = key_id.Equals("3") ? Crypto.CurOSEncryptor : Crypto.CurCNEncryptor;
                    var regionInfo = Convert.FromBase64String(regionData);



                    //Thank you so much GH Copilot
                    int chunkSize = 256 - 11;
                    int regionInfoLength = regionInfo.Length;
                    int numChunks = (int)Math.Ceiling(regionInfoLength / (double)chunkSize);

                    //Encrypt regionInfo in chunks
                    byte[] encryptedRegionInfo = new byte[numChunks*256];

                    for (int i = 0; i < numChunks; i++)
                    {
                        Index from = i * chunkSize;
                        Index to = Math.Min((i + 1) * chunkSize, regionInfoLength);
                        byte[] chunk = regionInfo[from..to];
                        byte[] encryptedChunk = encryptor.Encrypt(chunk, RSAEncryptionPadding.Pkcs1);
                        Array.Copy(encryptedChunk, 0, encryptedRegionInfo, i*256, encryptedChunk.Length);
                    }
                    var signer = Crypto.CurSigner;
                    byte[] privateSignature = signer.SignData(regionInfo, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);


                    var rsp = new QueryCurRegionRspJson
                    {
                        content = Convert.ToBase64String(encryptedRegionInfo),
                        sign = Convert.ToBase64String(privateSignature)
                    };

                    context.Response.Headers.Vary = "Accept-Encoding";
                    context.Response.Headers.ContentType = "text/html";
                    await context.Response.WriteAsJsonAsync(rsp);
                }
                catch (Exception e)
                {
                    Logger.WriteErrorLine(string.Format("An error occurred while handling query_cur_region/{0}.", regionName), e);
                }
            }
            else
            {
                //TODO QueryCurrentRegionEvent

                await context.Response.WriteAsync(regionData);
            }
            // Log to console.
            Logger.WriteLine(string.Format("Client {0}s request: query_cur_region/{1}s", context.Connection.RemoteIpAddress.ToString(), regionName));
            return true;
        }
    }
}
