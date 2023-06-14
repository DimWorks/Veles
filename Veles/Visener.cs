using System;
using System.Collections.Generic;

namespace Veles
{
   class Visener
    {
        public string Encrypt(string message, string key)
        {
            if (message == "")
            {
                return "";
            }
            List<char> messageArr = new List<char>();
            messageArr.AddRange(message);
            List<char> keyArr = new List<char>();
            keyArr.AddRange(key);

            List<char> encryptedMessage = new List<char>();
            int element = 0;
            for( int i = 0; i < messageArr.Count; i++)
            {
                element = (Convert.ToInt32(messageArr[i]) + key[i % keyArr.Count]) % 1400;
                encryptedMessage.Add(Convert.ToChar(element));
            }

            string output = new string(encryptedMessage.ToArray());
            return output;
        }

        public string Decrypt(string key, string message)
        {
            if (message == "")
            {
                return "";
            }
            List<char> messageArr = new List<char>();
            messageArr.AddRange(message);
            List<char> keyArr = new List<char>();
            keyArr.AddRange(key);

            List<char> decryptedMessage = new List<char>();
            int element = 0;
            for (int i = 0; i < messageArr.Count; i++)
            {
                element = (Convert.ToInt32(messageArr[i]) + 1400 - Convert.ToInt32(keyArr[i % keyArr.Count])) % 1400;
                try
                {
                    decryptedMessage.Add(Convert.ToChar(element));
                }
                catch
                {
                    decryptedMessage.Add('#');
                }                
            }
            string output = new string(decryptedMessage.ToArray());
            return output;
        }
    }
}
