using System;
using System.Collections.Generic;

namespace Veles
{
    class Caesar
    {
		public string Encrypt(int key, string message)
		{
            if (message == "")
            {
                return "";
            }
            List<char> messageArr = new List<char>();
            messageArr.AddRange(message);

            List<char> encryptedMessage = new List<char>();

            int element = 0;
            for (int i = 0; i < messageArr.Count; i++)
            {                
                element = (Convert.ToInt32(messageArr[i]) + key) % 10000;
                encryptedMessage.Add(Convert.ToChar(element));
            }

            string output = new string(encryptedMessage.ToArray());
            return output;
        }

        public string Decrypt(int key, string message)
        {
            if (message == "")
            {
                return "";
            }
            List<char> messageArr = new List<char>();
            messageArr.AddRange(message);
            List<char> decryptedMessage = new List<char>();
            int element = 0;
            for (int i = 0; i < messageArr.Count; i++)
            {
                element = (Convert.ToInt32(messageArr[i]) - key) % 10000;
                if (element < 0) element *= (-1);
                decryptedMessage.Add(Convert.ToChar(element));
            }
            string output = new string(decryptedMessage.ToArray());
            return output;
        }
    }
}
