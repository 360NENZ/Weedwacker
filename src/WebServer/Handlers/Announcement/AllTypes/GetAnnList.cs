using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    internal class GetAnnList : IHandler
    {
        public class GetAnnListRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; }
            public class Data
            {
                public string t { get; set; }
                public List<AnnList> list { get; set; }
                public class AnnList
                {
                    public List<Announcement> list { get; set; } = new();
                    public class Announcement
                    {
                        public int ann_id { get; set; }
                        public string title { get; set; }
                        public string subtitle { get; set; }
                        public string banner { get; set; }
                        public string tag_icon { get; set; }
                        public int type { get; set; } = -1; // default to an invalid type
                        public string type_label { get; set; }
                        public string lang { get; set; } = "en-US";
                        public string start_time { get; set; } = "2020-09-25 04:05:30";
                        public string end_time { get; set; } = "2030-10-30 11:00:00";
                        public string content { get; set; } = "";
                        public bool has_content { get; set; } = true;

                        public Announcement(string annTitle, string annSubTitle, string bannerJpg, string dispatchDomain, string annType)
                        {
                            title = annTitle;
                            subtitle = annSubTitle;
                            banner = dispatchDomain + "/hk4e/announcement/assets/banner/" + bannerJpg;
                            tag_icon = dispatchDomain + "/hk4e/announcement/assets/tag_icon.png";
                            type_label = annType;
                        }
                    }

                    public int type_id { get; set; }
                    public string type_label { get; set; }

                    public AnnList(int id, string label)
                    {
                        type_id = id;
                        type_label = label;
                    }
                }

                public int total { get; set; }
                public List<AnnType> type_list { get; set; }
                public class AnnType
                {
                    public int id { get; set; }
                    public string name { get; set; }
                    public string mi18n_name { get; set; }

                    public AnnType(int TypeId, string TypeName, string TypeMi18n_name)
                    {
                        id = TypeId;
                        name = TypeName;
                        mi18n_name = TypeMi18n_name;
                    }
                }

                public int timezone { get; set; } = -5;
                public bool alert { get; set; } = false;
                public int alert_id { get; set; } = 0;

                public Data(List<AnnList.Announcement> announcements)
                {
                    t = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
                    type_list = new() { new AnnType(1, "活动公告", "Activity"), new AnnType(2, "游戏系统公告", "System"), new AnnType(3, "idklol", "Events") };
                    foreach (AnnList.Announcement ann in announcements)
                    {
                        foreach (AnnType type in type_list)
                        {
                            if (ann.type_label == type.mi18n_name)
                            {
                                ann.type = type.id;
                                break;
                            }                         
                        }
                        if (ann.type == -1)
                        {
                            Logger.WriteErrorLine("Invalid Announcement type: " + ann.type_label);
                        }
                    }
                    list = new();
                    int id = 1;
                    foreach (AnnType annType in type_list)
                    {
                        AnnList annList = new(annType.id, annType.mi18n_name);
                        foreach (AnnList.Announcement ann in announcements)
                        {
                            if (ann.type_label == annType.mi18n_name)
                            {
                                ann.ann_id = id++;
                                annList.list.Add(ann);
                            }
                        }
                        announcements.RemoveAll(w => w.type == annType.id);
                        list.Add(annList);
                    }
                }
            }
            public GetAnnListRspJson(Data dataa)
            {
                data = dataa;
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            GetAnnListRspJson.Data data;

            if (!File.Exists(WebServer.Configuration.structure.data + "GameAnnouncementList.json"))
            {
                string dispatchDomain = WebServer.Configuration.Server.EnforceEncryption ? WebServer.Configuration.Kestrel.Endpoints.Https.Url : WebServer.Configuration.Kestrel.Endpoints.Http.Url;
                GetAnnListRspJson.Data.AnnList.Announcement ann1 = new("<strong>Welcome to Weedwacker!</strong>", "Welcome!", "1.jpg", dispatchDomain, "System");
                GetAnnListRspJson.Data.AnnList.Announcement ann2 = new("<strong>How to use announcements</strong>", "How to use announcements", "2.jpg", dispatchDomain, "System");
                data = new(new List<GetAnnListRspJson.Data.AnnList.Announcement>() { ann1, ann2 });
                Logger.WriteLine("GameAnnouncementList.json not found. Generating default json");
                string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
                await File.WriteAllTextAsync(WebServer.Configuration.structure.data + "GameAnnouncementList.json", jsonString);
            }
            else
            {
                data = JsonConvert.DeserializeObject<GetAnnListRspJson.Data>(await File.ReadAllTextAsync(WebServer.Configuration.structure.data + "GameAnnouncement.json"));
            }

            await context.Response.WriteAsJsonAsync(new GetAnnListRspJson(data));
            return true;
        }
    }
}
