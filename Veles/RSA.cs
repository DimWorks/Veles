using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Veles
{
    class RSA
    {
        private static long mod(int a, int x, int p, int y) // Пердается а, её степень х, делитель р и степень при которое остаток всегда будет 1 (у)
        {
            long res = 1;
            if (a % p == 0)
            {
                return 0;
            }
            else if (x == y)
            {
                return 1;
            }
            else
            {
                x = x % y;
                for (int i = 1; i <= x; i++)
                {
                    res = (res * a) % p;
                }
            }
            return res;
        }

        private static bool isSimple(int p)
        {
            if(p < 2)
            {
                return false;
            }
            else if(p == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(p); i++)
                {
                    if (p % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }

        private static int Euclid(int c, int m)
        {
            List<int> u = new List<int>() { c, 1, 0 };
            List<int> v = new List<int>() { m, 0, 1 };
            List<int> t = new List<int>() { m, 0, 1 };

            while (v[0] > 0)
            {
                int q = u[0] / v[0];
                t[0] = u[0] % v[0];
                t[1] = u[1] - q * v[1];
                t[2] = u[2] - q * v[2];

                u = v.ToList();
                v = t.ToList();
            }
            if (u[1] < 0)
            {
                u[1] += m;
            }

            return u[1];
        }

        private int Euler(int n)
        {
            int result = n;
            for (int i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result -= result / i;
                }
            }                
            if (n > 1)
            {
                result -= result / n;
            }                
            return result;
        }

        public Tuple<int, int, int> CreatKey(int e)
        {
            Random rand = new Random();
            int p = rand.Next(1000, 9000), q = rand.Next(1000, 8000);

            while (!isSimple(p))
            {
                p++;
            }

            while (!isSimple(q))
            {
                q++;
            }

            int nEyler =  (p - 1) * (q - 1);

            int tmp = e;

            while (!isSimple(e) && nEyler % e != 0 && e % nEyler != 0)
            {
                e++;
            }

            int d = Euclid(e, nEyler);


            while (d == 1)
            {
                e++;
                d = Euclid(e, nEyler);
            }

            if (e != tmp)
            {
                MessageBox.Show("Открытый ключ был изменён: " + e);
            }

            KeysRSA keysrsa = new KeysRSA();
            keysrsa.KeyD = Convert.ToString(d);
            keysrsa.KeyP = Convert.ToString(p * q);
            keysrsa.ShowDialog();
            Tuple<int, int, int> KeysRSA = new Tuple<int, int, int>(e, p, q);
            return KeysRSA;
        }
        public string Encrypt(string message, int e, int p, int q)
        {
            if (message == "")
            {
                return "";
            }
            int n = p * q;
            int nEyler = (p - 1) * (q - 1);

            List<char> messageArr = new List<char>();
            messageArr.AddRange(message);

            List<long> encryptedMessage = new List<long>();

            foreach(var item in messageArr)
            {
                int a = Convert.ToInt32(item);
                encryptedMessage.Add(mod(a, e, n, nEyler));
            }
            string output = "";
            foreach(long item in encryptedMessage)
            {
                output += " " + item;
            }

            return output;
        }

        public string Decrypt(int key, int n, string message)
        {
            if(message == "")
            {
                return "";
            }
            string[] messageArr = message.Split(' ');

            List<char> decryptedMessage = new List<char>();
            for(int i = 1; i < messageArr.Length; i++)
            {
                try
                {
                    decryptedMessage.Add(Convert.ToChar(mod(Convert.ToInt32(messageArr[i]), key, n, Euler(n))));
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
