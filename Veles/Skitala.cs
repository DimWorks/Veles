using System;

namespace Veles
{
    internal class Skitala
    {
        public string Encrypt(int d, string mess)
        {
            int k = mess.Length % d;
            if (k > 0)
            {
                mess += new string(' ', d - k);
            }
            int m = mess.Length / d;
            string output = "";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    output += Convert.ToString(mess[i + m * j]);
                }
            }
            return output;
        }
        public string Decrypt(int d, string mess)
        {
            int m = mess.Length / d;
            var output = new char[mess.Length];
            int index = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    output[i + m * j] = mess[index];
                    index++;
                }
            }

            return string.Join("", output);
        }

    }
}
