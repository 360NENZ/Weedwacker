using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.WebServer
{
    internal class WebConfig : ConfigFile
    {
        public KestrelJson Kestrel = new();
        public ServerJson Server = new();

        public class KestrelJson
        {
            public List<Endpoint> Endpoints = new() { new Endpoint() };
            public class Endpoint
            {

                public CertificateJson Certificate = new();

                public string Url = "https://localhost:443";
                public string ClientCertificateMode = "NoCertificate";
                public string[] SslProtocols = new string[] { "Tls12", "Tls13" };
                public class CertificateJson
                {
                    public string Path = "./keystore.p12";
                    public string Password = "123456";
                }

            }
        }

        public class Database
        {
            public DataStore Server = new DataStore();
            public class DataStore
            {
                public string ConnectionUri = "mongodb://localhost:27017";
                public string Database = "weedwacker";
            }
        }

        public class ServerJson
        {

            public bool LogCommands = false;
            public PoliciesJson Policies = new();
            public FilesJson Files = new();
            public AccountJson Account = new();
            public DispatchJson Dispatch = new();

            public class AccountJson
            {
                public bool AutoCreate = false;
                public string[] DefaultPermissions = Array.Empty<string>();
                public int MaxAccount = -1;
            }
        }


        /* Data containers. */

        public class DispatchJson
        {
            public List<Region> Regions = new();
            public string DefaultName = "Weedwacker";

        }

        public class PoliciesJson
        {
            public CORS Cors = new CORS();

            public class CORS
            {
                public bool Enabled = false;
                public string[] AllowedOrigins = new string[] { "*" };
            }
        }

        public class FilesJson
        {
            public string IndexFile = "./index.html";
            public string ErrorFile = "./404.html";
        }

        /* Objects. */

        public class Region
        {
            public Region() { }

            public Region(
                string name, string title,
                string address, uint port
            )
            {
                Name = name;
                Title = title;
                Ip = address;
                Port = port;
            }

            public string Name = "os_usa";
            public string Title = "Weedwacker";
            public string Ip = "127.0.0.1";
            public uint Port = 22102;
        }
    }
}
