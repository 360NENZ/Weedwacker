using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PrivateChatReq)]
    internal class HandlePrivateChatReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            PrivateChatReq req = PrivateChatReq.Parser.ParseFrom(payload);
            if(req.TargetUid == (uint)GameServer.Configuration.Server.GameOptions.Constants.SERVER_CONSOLE_UID)
            {
                if (req.Text[0] == '/')
                {
                    try
                    {
                        string cmd = ConsoleHandler.ParseCommandString(req.Text.Substring(1), out string[] args);
                        Logger.WriteLine(await ConsoleHandler.ExecuteCommand(cmd, UserRank.Player, args));
                    }
                    catch (Exception e)
                    {
                        Logger.WriteErrorLine(e.ToString());
                    }                 
                }

                // Create chat packet.
                var notify = new PacketPrivateChatNotify((uint)session.Player.GameUid, req.TargetUid, req.Text);

                // Send and put in history.
                await session.SendPacketAsync(notify);
                await session.SendPacketAsync(new PacketPrivateChatRsp());
            }
        }
    }
}
