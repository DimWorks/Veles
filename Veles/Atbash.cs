using System;

namespace Veles
{
    internal class Atbash
    {
        public string Encrypt(string message)
        {
            string encryptMessage = "";
            int element;

            foreach (var symbol in message)
            {
                element = (Convert.ToInt32(Math.Abs(1104 - symbol))) % 1104;
                encryptMessage = encryptMessage + Convert.ToChar(element);
            }
            return encryptMessage;
        }

        public string Decrypt(string encryptMessage)
        {
            string decryptMessage = "";
            int element;

            foreach (var symbol in encryptMessage)
            {
                element = (Convert.ToInt32(Math.Abs(1104 - symbol))) % 1104;
                decryptMessage = decryptMessage + Convert.ToChar(element);
            }
            return decryptMessage;
        }
    }
}
