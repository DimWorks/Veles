using System;

namespace Veles
{
    internal class Gronsfeld
    {
        public string GenerateKey(string str, string keyword)
        {
            int sizeOfText = str.Length;
            string key = "";

            if (str.Length == keyword.Length)
                key = keyword;
            else
            {
                int index = 0, count = 0;
                while (count < sizeOfText)
                {
                    key += keyword[index];
                    if (index == (keyword.Length - 1))
                        index = -1;
                    index++;
                    count++;
                }
            }
            return key;
        }
        public string CipheredText(string str, string key)
        {
            string cipher = "";

            for (int i = 0; i < str.Length; i++)
            {
                int num = key[i] - '0';
                int x = str[i] + num;

                cipher += (char)x;
            }

            return cipher;
        }
        public string Encrypt(int tmp, string message)
        {

            string key = tmp.ToString();
            string keyFull = GenerateKey(message, key);
            string output = CipheredText(message, keyFull);
            return output;
        }
        public string DecryptedText(string message, string key)
        {
            string output = "";

            for (int i = 0; i < message.Length; i++)
            {
                int num = key[i] - '0';
                int x = message[i] - num;

                output += (char)x;
            }

            return output;
        }
        public string Decrypt(int tmp, string message)
        {
            string key = tmp.ToString();
            string keyFull = GenerateKey(message, key);
            string output = DecryptedText(message, keyFull);
            return output;
        }
    }
}
