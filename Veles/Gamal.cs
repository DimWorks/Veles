using System;
using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veles
{
    internal class Gamal
    {
        public static int NOD(int k, int p)
        {
            while (k > 0 && p > 0)
                if (k > p)
                    k %= p;
                else
                    p %= k;
            return k + p;
        }
        public static bool isSimple(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static long mod(long a, int x, int p, int y) // Передается а, её степень х, делитель р и степень при которое остаток всегда будет 1 (у)
        {
            long res = 1;
            if (a % p == 0)
            {
                return 0;
            }

            x = x % y;

            if (x % y == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    res = (res * a) % p;
                }
            }
            return res;
        }
        public static int power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        public static int mul(int a, long b, int n) // a*b mod n - умножение a на b по модулю n
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
        public Tuple<int, int, int> CreatKey(int p, int g, int x)
        {
            int tmp = p;
            while (p < 100000)
            {
                p = p + 100000;
            }
            while (!isSimple(p))
            {
                p++;
            }

            while (g > p)
            {
                g--; ;
            }
            while (x > p)
            {
                x--; ;
            }

            if (p != tmp)
            {
                MessageBox.Show("Открытые ключи были изменены: " + p + ", " + g + ", " + x);
            }

            Tuple<int, int, int> Keys = new Tuple<int, int, int>(p, g, x);
            return Keys;
        }
        public string Encrypt(int p, int g, int x, string m)
        {

            long y;
            y = mod(g, x, p, p - 1);
            int k = 2;
            for (int i = 2; i < p - 1; i++)
            {
                if (NOD(i, p - 1) == 1)
                {
                    k = i;
                    break;
                }
            }
            List<int> Message = new List<int>();   //сообщение в кодировке 
            for (int i = 0; i < m.Length; i++)
            {
                Message.Add((int)m[i]);
            }
            List<long> crypt_r = new List<long>();
            List<long> crypt_e = new List<long>();
            long r, e;

            for (int i = 0; i < Message.Count; i++)
            {  //закодированный текст в кодировке
                r = mod(g, k, p, p - 1);
                long temp = mod(Message[i], 1, p, p - 1);
                e = mod(y, k, p, p - 1);
                e = e * temp;
                e = mod(e, 1, p, p - 1);
                crypt_r.Add(r);
                crypt_e.Add(e);
            }
            List<string> tmp = new List<string>();

            for (int i = 0; i < crypt_r.Count; i++)
            {
                tmp.Add(crypt_r[i].ToString());
                tmp.Add(crypt_e[i].ToString());
            }
            string output = "";
            for (int i = 0; i < tmp.Count; i++)
            {
                output = output + tmp[i].ToString() + " ";
            }

            return output;

        }
        public string Decrypt(int p, int g, int x, string m)
        {
            string str = "";


            if (m.Length > 0)
            {
                string[] strA = m.Split(' ');
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0;
                        int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            ai = ai * 10 + (int)(a[j] - 48);
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (int)(b[j] - 48);
                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            long c = mod(ai, p - 1 - x, p, p - 1);
                            long deM = mul(bi, c, p);
                            char ms = (char)deM;
                            str = str + ms;
                        }
                    }
                }
            }
            return str;
        }
    }
}
