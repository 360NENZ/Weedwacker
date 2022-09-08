using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.Shared.Utils
{
    public class Crypto
    {
        //private static SecureRandom secureRandom = new SecureRandom();

        public static byte[] DISPATCH_KEY;
        public static byte[] DISPATCH_SEED;

        public static byte[] ENCRYPT_KEY;
        public static ulong ENCRYPT_SEED = 11468049314633205968;
        public static byte[] ENCRYPT_SEED_BUFFER = new byte[0];
        /*
        public static PublicKey CUR_OS_ENCRYPT_KEY;
        public static PublicKey CUR_CN_ENCRYPT_KEY;
        public static System.Security.Cryptography.RSA CUR_SIGNING_KEY;
        */
        public static void LoadKeys()
        {
            var keys = Config.WebConfig.structure.keys;
            DISPATCH_KEY = File.ReadAllBytes(keys + "dispatchKey.bin");
            DISPATCH_SEED = File.ReadAllBytes(keys + "dispatchSeed.bin");

            ENCRYPT_KEY = File.ReadAllBytes(keys + "secretKey.bin");
            ENCRYPT_SEED_BUFFER = File.ReadAllBytes(keys + "secretKeyBuffer.bin");
            /*
            try
            {
                var signingCertificate = new X509Certificate2(keys + "SigningKey.der")
                CUR_SIGNING_KEY = signingCertificate.GetRSAPrivateKey();
                    .generatePrivate(new PKCS8EncodedKeySpec(FileUtils.readResource("/keys/SigningKey.der")));

                CUR_OS_ENCRYPT_KEY = new X509Certificate2(keys + "OSCB_Pub.der");
                    .generatePublic(new X509EncodedKeySpec(FileUtils.readResource("/keys/OSCB_Pub.der")));

                CUR_CN_ENCRYPT_KEY = new X509Certificate2(keys + "OSCN_Pub.der")
                    .generatePublic(new X509EncodedKeySpec(FileUtils.readResource("/keys/OSCN_Pub.der")));
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine("An error occurred while loading keys.", e);
            }
          */  
        }

        public static void Xor(byte[] packet, byte[] key)
        {
            try
            {
                for (int i = 0; i < packet.Length; i++)
                {
                    packet[i] ^= key[i % key.Length];
                }
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine("Crypto error.", e);
            }
        }
    }
}
