using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode("GetPlayerTokenReq")]
    internal class HandleGetPlayerTokenReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            GetPlayerTokenReq req = GetPlayerTokenReq.Parser.ParseFrom(payload);

            // Authenticate
            if (! await GameServer.VerifyToken(req.AccountUid, req.AccountToken)) return;
            /*

            // Set account
            session.setAccount(account);

            // Check if player object exists in server
            // NOTE: CHECKING MUST SITUATED HERE (BEFORE getPlayerByUid)! because to save firstly ,to load secondly !!!
            // TODO - optimize
            bool kicked = false;
            Player exists = GameServer().getPlayerByAccountId(account.getId());
            if (exists != null)
            {
                GameSession existsSession = exists.getSession();
                if (existsSession != session)
                {// No self-kicking
                    exists.onLogout();//must save immediately , or the below will load old data
                    existsSession.close();
                    Grasscutter.getLogger().warn("Player {} was kicked due to duplicated login", account.getUsername());
                    kicked = true;
                }
            }

            //NOTE: If there are 5 online players, max count of player is 5,
            // a new client want to login by kicking one of them ,
            // I think it should be allowed
            if (!kicked)
            {
                // Max players limit
                if (ACCOUNT.maxPlayer > -1 && Grasscutter.getGameServer().getPlayers().size() >= ACCOUNT.maxPlayer)
                {
                    session.close();
                    return;
                }
            }

            // Call creation event.
            PlayerCreationEvent event = new PlayerCreationEvent(session, Player.class); event.call();

        // Get player.
        Player player = DatabaseHelper.getPlayerByAccount(account, event.getPlayerClass());

        if (player == null) {
            int nextPlayerUid = DatabaseHelper.getNextPlayerId(session.getAccount().getReservedPlayerUid());

        // Create player instance from event.
        player = event.getPlayerClass().getDeclaredConstructor(GameSession.class).newInstance(session);

        // Save to db
        DatabaseHelper.generatePlayerUid(player, nextPlayerUid);
        }

    // Set player object for session
    session.setPlayer(player);

        // Checks if the player is banned
        if (session.getAccount().isBanned()) {
            session.send(new PacketGetPlayerTokenRsp(session, 21, "FORBID_CHEATING_PLUGINS", session.getAccount().getBanEndTime()));
            session.close();
            return;
        }

// Load player from database
player.loadFromDatabase();

// Set session state
session.setUseSecretKey(true);
session.setState(SessionState.WAITING_FOR_LOGIN);

// Only >= 2.7.50 has this
if (req.getKeyId() > 0)
{
    try
    {
        Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
        cipher.init(Cipher.DECRYPT_MODE, Crypto.CUR_SIGNING_KEY);

        var client_seed_encrypted = Utils.base64Decode(req.getClientSeed());
        var client_seed = ByteBuffer.wrap(cipher.doFinal(client_seed_encrypted))
            .getLong();

        byte[] seed_bytes = ByteBuffer.wrap(new byte[8])
            .putLong(Crypto.ENCRYPT_SEED ^ client_seed)
            .array();

        //Kind of a hack, but whatever
        cipher.init(Cipher.ENCRYPT_MODE, req.getKeyId() == 3 ? Crypto.CUR_OS_ENCRYPT_KEY : Crypto.CUR_CN_ENCRYPT_KEY);
        var seed_encrypted = cipher.doFinal(seed_bytes);

        Signature privateSignature = Signature.getInstance("SHA256withRSA");
        privateSignature.initSign(Crypto.CUR_SIGNING_KEY);
        privateSignature.update(seed_bytes);

        session.send(new PacketGetPlayerTokenRsp(session, Utils.base64Encode(seed_encrypted), Utils.base64Encode(privateSignature.sign())));
    }
    catch (Exception ignore)
    {
        // Only UA Patch users will have exception
        byte[] clientBytes = Utils.base64Decode(req.getClientSeed());
        byte[] seed = ByteHelper.longToBytes(Crypto.ENCRYPT_SEED);
        Crypto.xor(clientBytes, seed);

        String base64str = Utils.base64Encode(clientBytes);

        session.send(new PacketGetPlayerTokenRsp(session, base64str, "bm90aGluZyBoZXJl"));
    }
}
else
{
    // Send packet
    session.send(new PacketGetPlayerTokenRsp(session));
}*/
        }
    }
}
