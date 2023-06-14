using System;
using System.Text;
using System.Security.Cryptography;

namespace Veles
{    class Password
    {
        public string GetHash(string input)
        {
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        WorkingFiles savingPass = new WorkingFiles();
        public bool CheckPass(string password)
        {
           string passwordHash = GetHash(password);
           string svPassword = savingPass.PassFromFiles();
           return (svPassword == passwordHash);
        }
        public void NewPass(string newPass)
        {
            var hash = GetHash(newPass);
            savingPass.PassToFile(hash);
        }
        public bool Reset(string input)
        {
            string standart = "jr7XHUby9Bbn0q/mTPEUFJhKvL/UOFG6eNP3OFWHbRs=";
            if (GetHash(input) == standart)
            {
                savingPass.PassToFile(standart);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
