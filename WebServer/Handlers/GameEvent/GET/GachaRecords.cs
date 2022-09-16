using Microsoft.AspNetCore.Http;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Database;

namespace Weedwacker.WebServer.Handlers
{
    internal class GachaRecords : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            string recordsTemplate = await File.ReadAllTextAsync(WebServer.Configuration.structure.data +"gacha/records.html");
            if (!(recordsTemplate.Length > 0))
            {
                Logger.WriteLine("File does not exist: " + recordsTemplate);
                context.Response.StatusCode = 500;
                return false;
            }

            string sessionKey = context.Request.Query["s"];
            Account account = await DatabaseManager.GetAccountBySessionKeyAsync(sessionKey);
            if (account == null)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Requested account was not found");
                return false;
            }/*
            Player player = .getGameServer().getPlayerByAccountId(account.getId());
            if (player == null)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("No player associated with requested account");
                return false;
            }

            int page = 0, gachaType = 0;
            if (context.Request.Query.ContainsKey("p"))
                page = int.Parse(context.Request.Query["p"]);
            if (context.Request.Query.ContainsKey("gachaType"))
                gachaType = int.Parse(context.Request.Query["gachaType"]);
            
            string records = DatabaseManager.getGachaRecords(player.getUid(), page, gachaType).toString();
            long maxPage = DatabaseManager.getGachaRecordsMaxPage(player.getUid(), page, gachaType);

            string template = new String(FileUtils.read(recordsTemplate), StandardCharsets.UTF_8)
                .replace("{{REPLACE_RECORDS}}", records)
                .replace("{{REPLACE_MAXPAGE}}", String.valueOf(maxPage))
                .replace("{{TITLE}}", translate(player, "gacha.records.title"))
                .replace("{{DATE}}", translate(player, "gacha.records.date"))
                .replace("{{ITEM}}", translate(player, "gacha.records.item"))
                .replace("{{LANGUAGE}}", Utils.getLanguageCode(account.getLocale()));
            context.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
            ctx.result(template);
            await context.Response.WriteAsJsonAsync(new ListPriceTiersResJson());*/
            return true;
        }
    }
}
