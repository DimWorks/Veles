using System;
using System.IO;
using System.Windows.Forms;


namespace Veles
{
    class WorkingFiles
    {
        public string ChekTheFile() // функция проверяет наличие пакпки "Veles" и файла "data.ini" в ней, если нет, то создаёт их и возвращает полный путь до файла
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Veles";
            bool isCreat = File.Exists(path + "\\data.txt");
            if (!isCreat)
            {
                Directory.CreateDirectory(path);
                path += "\\data.txt";
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("jr7XHUby9Bbn0q/mTPEUFJhKvL/UOFG6eNP3OFWHbRs="); // Пароль DAD
                    MessageBox.Show("Файлы данных были повреждены, информация утерена, пароль сброшен");
                }
            }
            else
            {
                if (File.ReadAllLines(path + "\\data.txt").Length == 0)
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine("jr7XHUby9Bbn0q/mTPEUFJhKvL/UOFG6eNP3OFWHbRs="); // Пароль DAD
                        MessageBox.Show("Файлы данных были повреждены, информация утерена, пароль сброшен");
                    }
                }
                return path + "\\data.txt";
            }
            return path;
        }

        public void ToFile(string message)
        {
            string path = ChekTheFile();
            string password;
            using (var passRead = new StreamReader(path))
            {
                password = passRead.ReadLine();  // записываем в переменную
            }
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(password + Environment.NewLine + message);
            }
        }

        public string FromFiles()
        {
            string path = ChekTheFile(); //Получение пути к файлу
            try
            {
                string output = File.ReadAllText(path).Split('\n')[1/*количество пропускаемых строк*/];
                return output.Remove(output.Length - 1);
            }
            catch
            {
                MessageBox.Show("У вас нет сохранёного сообщения");
                return null;
            }
        }

        public string PassFromFiles()
        {
            string path = ChekTheFile(); //Получение пути к файлу
            string output = File.ReadAllText(path).Split('\n')[0/*количество пропускаемых строк*/];
            return output.Remove(output.Length - 1);
        }

        public void PassToFile(string input)
        {
            string path = ChekTheFile();
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(input);
            }
        }
        public void EncryptFile(string pathFrom, string shifr, string pathTo)
        {
            string message;
            StreamReader read = null; 
            StreamWriter write = null;
            bool isRight = false;
            try
            {
                read = new StreamReader(pathFrom);
                isRight = true;
            }
            catch
            {
                MessageBox.Show("Ошибка доступа к файлу" + pathFrom + "\nВозможно он занят другим процессом");
                isRight = false;
            }

            if(isRight)
            {
                try
                {
                    write = new StreamWriter(pathTo, true, System.Text.Encoding.UTF8);
                }
                catch
                {
                    MessageBox.Show("Ошибка доступа к файлу" + pathTo + "\nВозможно он занят другим процессом");
                    isRight = false;
                }
            }
            
            if(isRight)
            {
                Encrypt input = new Encrypt();

                input.shifr = shifr;
                var res = DialogResult.Cancel;
                switch (shifr)
                {
                    case "Caesar":
                        input.Text = "Шифр Цезаря";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Caesar call_Caesar = new Caesar();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Caesar.Encrypt(Convert.ToInt32(input.Key), message));
                            }
                        }
                        break;

                    case "Gamal":
                        Gamal call_Gamal = new Gamal();
                        input.Text = "Шифр Гамаля";
                        input.isThree = true;
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Tuple<int, int, int> KeysGamal = call_Gamal.CreatKey(Convert.ToInt32(input.Key), Convert.ToInt32(input.KeyP), Convert.ToInt32(input.KeyQ));
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Gamal.Encrypt(KeysGamal.Item1, KeysGamal.Item2, KeysGamal.Item3, message));
                            }
                        }
                        break;
                    case "Rijndael":
                        Rijndael call_Rijndael = new Rijndael();
                        input.Text = "Шифр Риндаэля";
                        input.isThree = true;
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Rijndael.Encrypt(message, input.Key, input.KeyP));
                            }
                        }
                        break;
                    case "Atbash":
                        input.Text = "Шифр Атбаш";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Atbash call_Atbash = new Atbash();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Atbash.Encrypt(message));
                            }
                        }
                        break;
                    case "Visener":
                        input.Text = "Шифр Виженера";
                        res = input.ShowDialog();

                        if (res == DialogResult.OK)
                        {
                            Visener call_Visener = new Visener();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Visener.Encrypt(message, input.Key));
                            }
                        }
                        break;
                    case "RSA":
                        input.Text = "RSA";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            RSA call_RSA = new RSA();
                            Tuple<int, int, int> KeysRSA = call_RSA.CreatKey(Convert.ToInt32(input.Key));
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_RSA.Encrypt(message, KeysRSA.Item1, KeysRSA.Item2, KeysRSA.Item3));
                            }
                        }
                        break;
                    case "Gronsfeld":
                        input.Text = "Шифр Гронсфельда";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Gronsfeld call_Gronsfeld = new Gronsfeld();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Gronsfeld.Encrypt(Convert.ToInt32(input.Key), message));
                            }
                        }
                        break;
                    case "DES":
                        input.Text = "DES";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Tuple<string, string> mesKey = new Tuple<string, string>("", "");
                            DES call_DES = new DES();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                mesKey = call_DES.Encrypt(message, input.Key);
                                write.WriteLine(mesKey.Item1);
                            }
                            Output call_output = new Output();
                            call_output.Text = "DES";
                            call_output.hat.Text = "Сгенерированный ключ расшифровки(скопируйте):";
                            call_output.Sometext = mesKey.Item2;
                            call_output.ShowDialog();
                        }
                        break;
                    case "Table":
                        input.Text = "Табличная перестановка с ключевым словом";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Table call_table = new Table();
                            string tmp = input.Key;
                            message = read.ReadLine();
                            write.WriteLine(call_table.Encrypt(message, tmp));
                        }
                        break;
                    case "Skitala":
                        input.Text = "Шифр Скитала";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Skitala call_Skitala = new Skitala();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Skitala.Encrypt(Convert.ToInt32(input.Key), message));
                            }
                        }
                        break;
                    case "RC4":
                        input.Text = "RC4";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            RC4 call_RC4 = new RC4();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_RC4.Do(message, input.Key));
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Выберите алгоритм!");
                        break;
                }

                read.Close();
                write.Close();
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Файл зашифрован!");
                }
            }
            
        }
        public void DecryptFile(string pathFrom, string shifr, string pathTo)
        {

            string message;
            StreamReader read = null;
            StreamWriter write = null;
            bool isRight = false;
            try
            {
                read = new StreamReader(pathFrom);
                isRight = true;
            }
            catch
            {
                MessageBox.Show("Ошибка доступа к файлу" + pathFrom + "\nВозможно он занят другим процессом");
                isRight = false;
            }

            if (isRight)
            {
                try
                {
                    write = new StreamWriter(pathTo, true, System.Text.Encoding.UTF8);
                }
                catch
                {
                    MessageBox.Show("Ошибка доступа к файлу" + pathTo + "\nВозможно он занят другим процессом");
                    isRight = false;
                }
            }

            if (isRight)
            {
                Dekrypt decrypt = new Dekrypt();
                Output output = new Output();
                var res = DialogResult.Cancel;
                switch (shifr)
                {
                    case "Caesar":
                        decrypt.Text = "Шифр Цезаря";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Caesar call_Caesar = new Caesar();
                            output.Text = "Шифр Цезаря";
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Caesar.Decrypt(Convert.ToInt32(decrypt.Key), message));
                            }
                        }
                        break;
                    case "Visener":
                        decrypt.Text = "Шифр Виженера";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Visener call_Visener = new Visener();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Visener.Decrypt(decrypt.Key, message));
                            }
                        }

                        break;
                    case "Atbash":
                        Atbash call_Atbash = new Atbash();
                        while (!read.EndOfStream)
                        {
                            message = read.ReadLine();
                            write.WriteLine(call_Atbash.Decrypt(message));
                        }
                        break;
                    case "RSA":
                        decrypt.Text = "RSA";
                        decrypt.isDouble = true;
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Caesar call_Caesar = new Caesar();
                            output.Text = "RSA"; RSA call_RSA = new RSA();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_RSA.Decrypt(Convert.ToInt32(decrypt.Key), Convert.ToInt32(decrypt.KeyP), message));
                            }
                        }
                        break;
                    case "Gronsfeld":
                        decrypt.Text = "Шифр Гронсфельда";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Gronsfeld call_Gronsfeld = new Gronsfeld();
                            output.Text = "Шифр Гронсфельда";
                            string tmp = decrypt.Key;
                            if (int.TryParse(tmp, out int key))
                            {
                                while (!read.EndOfStream)
                                {
                                    message = read.ReadLine();
                                    write.WriteLine(call_Gronsfeld.Decrypt(key, message));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ключ должен состоять из цифр");
                            }
                        }
                        break;
                    case "Skitala":
                        decrypt.Text = "Шифр Скитала";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Skitala call_Skitala = new Skitala();
                            output.Text = "Шифр Скитала";
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Skitala.Decrypt(Convert.ToInt32(decrypt.Key), message));
                            }
                        }
                        break;
                    case "DES":
                        decrypt.Text = "DES";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            DES call_DES = new DES();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_DES.Decrypt(decrypt.Key, message));
                            }
                        }
                        break;
                    case "Gamal":
                        decrypt.Text = "Шифр Эль-Гамаля";
                        decrypt.isThree = true;
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            decrypt.isThree = true;
                            Gamal call_Gamal = new Gamal();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Gamal.Decrypt(Convert.ToInt32(decrypt.Key), Convert.ToInt32(decrypt.KeyP), Convert.ToInt32(decrypt.KeyQ), message));
                            }
                        }
                        break;
                    case "Rijndael":
                        decrypt.Text = "Rijndael";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Rijndael call_Rijndael = new Rijndael();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_Rijndael.Decrypt(message, decrypt.Key, decrypt.KeyP));
                            }
                        }

                        break;
                    case "Table":
                        decrypt.Text = "Табличная перестановка с ключевым словом";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Table call_table = new Table();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_table.Decrypt(message, decrypt.Key));
                            }
                        }
                        break;
                    case "RC4":
                        decrypt.Text = "Табличная перестановка с ключевым словом";
                        res = decrypt.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            RC4 call_RC4 = new RC4();
                            while (!read.EndOfStream)
                            {
                                message = read.ReadLine();
                                write.WriteLine(call_RC4.Do(message, decrypt.Key));
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Выберите алгоритм!");
                        break;
                }
                read.Close();
                write.Close();

                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Файл расшифрован!");
                }
            }
        }

    }
}
