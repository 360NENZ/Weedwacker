using Weedwacker.Shared.Utils.Configuration;
using System.Security.Cryptography;

namespace Weedwacker.Shared.Utils
{
    public class Crypto
    {

        public static byte[] DISPATCH_KEY;
        public static byte[] DISPATCH_SEED;

        public static byte[] ENCRYPT_KEY;
        public static ulong ENCRYPT_SEED = 11468049314633205968;
        public static byte[] ENCRYPT_SEED_BUFFER = new byte[0];
        
        public static RSA CurOSEncryptor = RSA.Create(); //Public key
        public static RSA CurCNEncryptor = RSA.Create(); // Public Key
        public static RSA CurSigner = RSA.Create(); //Private Key
        
        public static void LoadKeys(string path)
        {

            DISPATCH_KEY = File.ReadAllBytes(path + "dispatchKey.bin");
            DISPATCH_SEED = File.ReadAllBytes(path + "dispatchSeed.bin");

            ENCRYPT_KEY = File.ReadAllBytes(path + "secretKey.bin");
            ENCRYPT_SEED_BUFFER = File.ReadAllBytes(path + "secretKeyBuffer.bin");
            
            try
            {
                CurOSEncryptor.ImportFromPem(File.ReadAllText(path + "OSCB.pem").ToCharArray());

                CurCNEncryptor.ImportFromPem(File.ReadAllText(path + "OSCN.pem").ToCharArray());

                CurSigner.ImportFromPem(File.ReadAllText(path + "SigningKey.pem").ToCharArray());
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine("An error occurred while loading keys.", e);
            }
            
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

        public static byte[] CreateSessionKey(int length)
        {
            return System.Security.Cryptography.RandomNumberGenerator.GetBytes(length);
        }
    }
}
