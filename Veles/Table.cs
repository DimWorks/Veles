using System;
using System.Linq;

namespace Veles
{
    internal class Table
    {
        public int rouding(int bigger, int smaller)
        {
            int res = bigger / smaller;
            if (bigger % smaller == 0)
            {
                return res;
            }
            else
            {
                return (res + 1);
            }
        }

        public string Encrypt(string message, string key)
        {
            int amount_lines = rouding(message.Count(), key.Count());
            char[,] messageArr = new char[amount_lines, key.Count()];
            int matrix_size = key.Count();
            int i = 0, j = 0;
            foreach (char item in message)
            {
                if (j < matrix_size)
                {
                    messageArr[i, j] = item;
                }
                else
                {
                    i++;
                    j = 0;
                    messageArr[i, j] = item;
                }
                j++;
            }

            if (message.Count() % key.Count() != 0)
            {
                int free = message.Count() % key.Count();
                for (int t = free; t < key.Count(); t++)
                {
                    messageArr[amount_lines - 1, t] = Convert.ToChar(1104);
                }
            }

            string encryptMessage = "";

            i = 0;
            j = 0;
            for (int a = 0; a < amount_lines * matrix_size; a++)
            {
                if (i < amount_lines)
                {
                    encryptMessage = encryptMessage + messageArr[i, j];
                }
                else
                {
                    j++;
                    i = 0;
                    encryptMessage = encryptMessage + messageArr[i, j];
                }
                i++;

            }
            return encryptMessage;
        }

        public string Decrypt(string encryptMessage, string key)
        {
            int amount_lines = rouding(encryptMessage.Count(), key.Count());
            char[,] messageArr = new char[amount_lines, key.Count()];
            int matrix_size = key.Count();
            int i = 0, j = 0;
            string decryptMessage = "";

            foreach (char item in encryptMessage)
            {
                if (i < amount_lines)
                {
                    messageArr[i, j] = item;
                }
                else
                {
                    j++;
                    i = 0;
                    messageArr[i, j] = item;
                }
                i++;
            }

            i = 0;
            j = 0;
            foreach (var item in encryptMessage)
            {
                if (j < matrix_size)
                {
                    decryptMessage = decryptMessage + messageArr[i, j];
                }
                else
                {
                    i++;
                    j = 0;
                    decryptMessage = decryptMessage + messageArr[i, j];
                }
                j++;
            }
            if (decryptMessage.Contains(Convert.ToChar(1104)))
            {
                int ind = decryptMessage.IndexOf(Convert.ToChar(1104));

                for (int n = ind; n < decryptMessage.Count(); n++)
                {
                    if (decryptMessage[n] == Convert.ToChar(1104))
                    {
                        decryptMessage = decryptMessage.Remove(n);
                    }
                }
            }
            return decryptMessage;
        }
    }
}
