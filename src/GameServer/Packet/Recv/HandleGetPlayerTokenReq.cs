using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

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

            // If the account doesn't have a player for this server, creates a new one
            session.Player = await DatabaseManager.GetPlayerByAccountUidAsync(req.AccountUid);
            session.Player.Token = req.AccountToken;

            // Check if player is already online
            if (GameServer.OnlinePlayers.ContainsKey(session.Player.GameUid))
            {
                // Kill the previous session, and replace it with the new one. Similar to Official behaviour
                GameServer.OnlinePlayers[session.Player.GameUid].Stop();
                GameServer.OnlinePlayers[session.Player.GameUid] = session;
            }
            else if (GameServer.OnlinePlayers.Count >= GameServer.Configuration.Server.MaxOnlinePlayers)
            {
                session.Stop();
                return;
            }

            // Update the player's session pointer
            session.Player.Session = session;

            // Set session state
            session.UseSecretKey = true;
            session.State = SessionState.WAITING_FOR_LOGIN;

            // Only Game Version >= 2.7.50 has this
            if (req.KeyId > 0)
            {
                try
                {
                    RSA signer = Crypto.CurSigner;

                    byte[] client_seed_encrypted = Convert.FromBase64String(req.ClientSeed);
                    byte[] client_seed = signer.Decrypt(client_seed_encrypted, RSAEncryptionPadding.Pkcs1);
                    byte[] encryptSeed = BitConverter.GetBytes(Crypto.ENCRYPT_SEED);
                    Crypto.Xor(client_seed, encryptSeed);
                    byte[] seed_bytes = client_seed;

                    //Kind of a hack, but whatever
                    RSA encryptor = req.KeyId == 3 ? Crypto.CurOSEncryptor : Crypto.CurCNEncryptor;
                    byte[] seed_encrypted = encryptor.Encrypt(seed_bytes, RSAEncryptionPadding.Pkcs1);

                    byte[] seed_bytes_sign = signer.SignData(seed_bytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                    await session.SendPacketAsync(new PacketGetPlayerTokenRsp(session, Convert.ToBase64String(seed_encrypted), Convert.ToBase64String(seed_bytes_sign), req.AccountToken));
                }
                catch (Exception ignore)
                {
                    // Only UA Patch users will have exception
                    byte[] clientBytes = Convert.FromBase64String(req.ClientSeed);
                    byte[] seed = BitConverter.GetBytes(Crypto.ENCRYPT_SEED);
                    Crypto.Xor(clientBytes, seed);

                    string base64str = Convert.ToBase64String(clientBytes);

                    await session.SendPacketAsync(new PacketGetPlayerTokenRsp(session, base64str, "bm90aGluZyBoZXJl", req.AccountToken));
                }
            }
            else
            {
                // Send packet
                await session.SendPacketAsync(new PacketGetPlayerTokenRsp(session, req.AccountToken));
            }
        }
    }
}
