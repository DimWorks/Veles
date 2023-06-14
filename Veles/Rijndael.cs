using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Veles
{
    internal class Rijndael
    {
        public string Encrypt(string message, string publicKey, string privateKey)
        {
            string result = "";
            byte[] privateKeyBytes = { };
            privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] publicKeyBytes = { };
            publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(message);
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream,
                provider.CreateEncryptor(publicKeyBytes, privateKeyBytes),
                CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                result = Convert.ToBase64String(memoryStream.ToArray());
            }
            return result;
        }

        public string Decrypt(String data, string publicKey, string privateKey)
        {
            string result = "";
            byte[] privateKeyBytes = { };
            privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] publicKeyBytes = { };
            publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] inputByteArray = new byte[data.Replace(" ", "+").Length];
            inputByteArray = Convert.FromBase64String(data.Replace(" ", "+"));
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream,
                provider.CreateDecryptor(publicKeyBytes, privateKeyBytes),
                CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                result = Encoding.UTF8.GetString(memoryStream.ToArray());
            }
            return result;
        }
    }
}
