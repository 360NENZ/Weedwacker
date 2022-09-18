using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    internal class GetAnnContent : IHandler
    {
        public class GetAnnContentRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; }
            public class Data
            {
                public string t { get; set; }
                public List<Announcement> list { get; set; } = new();
                public int total { get; set; }
                public class Announcement
                {
                    public int ann_id { get; set; }
                    public string title { get; set; }
                    public string subtitle { get; set; }
                    public string banner { get; set; }
                    public string content { get; set; }
                    public string lang { get; set; } = "en-US";
                    public Announcement(string annTitle, string annSubTitle, string bannerJpg, string domain , string annContent)
                    {
                        title = annTitle;
                        subtitle = annSubTitle;
                        banner = domain + "/hk4e/announcement/assets/banner/" + bannerJpg;
                        content = annContent;
                    }
                }
                public Data(List<Announcement> announcements)
                {
                    t = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
                    total = announcements.Count;
                    int id = 1;
                    foreach(Announcement announcement in announcements)
                    {
                        announcement.ann_id = id++;
                        list.Add(announcement);
                    }
                }
            }
            public GetAnnContentRspJson(Data dataa)
            { 
                data = dataa;
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {

            GetAnnContentRspJson.Data data;

            if (!File.Exists(WebServer.Configuration.structure.data + "GameAnnouncement.json"))
            {
                string dispatchDomain = WebServer.Configuration.Server.EnforceEncryption ? WebServer.Configuration.Kestrel.Endpoints.Https.Url : WebServer.Configuration.Kestrel.Endpoints.Http.Url;
                GetAnnContentRspJson.Data.Announcement ann1 = new("<strong>Welcome to Weedwacker!</strong>", "Welcome!", "1.jpg", dispatchDomain, "<p>Hi there!</p>First of all, welcome to Weedwacker. If you have any issues, please let us know so that Primrose can help you!");
                GetAnnContentRspJson.Data.Announcement ann2 = new("<strong>How to use announcements</strong>", "How to use announcements", "2.jpg", dispatchDomain, "<p>Announcement content uses HTML. The specific content of the announcement is stored in the WebServer's Data directory <code>GameAnnouncement.json</code>, while <code>GameAnnouncementList.json</code> stores the announcement list data.</p><h2><code>GameAnnouncement</code></h2><table><tr><th>Parameter</th><th>Description</th></tr><tr><td>ann_id</td><td>Unique ID</td></tr><tr><td>title</td><td>Title shown at the top of the content</td></tr><tr><td>subtitle</td><td>Short title shown on the left</td></tr><tr><td>banner</td><td>Image to display between content and title</td></tr><tr><td>content</td><td>Content body in HTML</td></tr><tr><td>lang</td><td>Language code for this entry</td></tr></table><h2><code>GameAnnouncementList</code></h2><p>If you want to add an announcement, please add the list data in the announcement type corresponding to <code>GameAnnouncementList</code>, and finally add the announcement content in <code>GameAnnouncement</code>.</p>");
                data = new(new List<GetAnnContentRspJson.Data.Announcement>() { ann1,ann2});
                Logger.WriteLine("GameAnnouncement.json not found. Generating default json");
                string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
                await File.WriteAllTextAsync("config.json", jsonString);
            }
            else
            {
                data = JsonConvert.DeserializeObject<GetAnnContentRspJson.Data>(await File.ReadAllTextAsync(WebServer.Configuration.structure.data + "GameAnnouncement.json"));
            }
            
            await context.Response.WriteAsJsonAsync(new GetAnnContentRspJson(data));
            return true;
        } 
    }
}
