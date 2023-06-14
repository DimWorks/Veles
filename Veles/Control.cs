using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace Veles
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            this.KeyPreview = true; // Говорим, что следим за нажатием клавиши в данной форме
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Control_KeyDown);
        }

        CheckBox lastChecked;
        string shifr = "ERROR";
        private void cb_Caesar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if(activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Caesar";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }            
        }

        private void cb_Visener_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Visener";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }

        private void cb_RSA_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "RSA";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }

        private void cb_Gronsfeld_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Gronsfeld";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }

        private void cb_DES_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "DES";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }

        private void cb_Atbash_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
            shifr = "Atbash";
        }

        private void cb_Table_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Table";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }
        private void skitala_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Skitala";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }

        private void cd_Gamal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Gamal";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "RC4";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked)
            {
                lastChecked = activeCheckBox;
                shifr = "Rijndael";
            }
            else
            {
                lastChecked = null;
                shifr = "ERROR";
            }
        }

        WorkingFiles call_WF = new WorkingFiles();
        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textOrFile.Value.ToString()) == 0)
            {
                WorkingFiles call_WF = new WorkingFiles();
                Encrypt input = new Encrypt();
                input.isThree = false;
                input.isShowMe = true;
                input.shifr = shifr;
                Output call_Output = new Output();
                string output;
                var res = DialogResult.Cancel;
                switch (shifr)
                {
                    case "Caesar":
                        input.Text = "Шифр Цезаря";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Caesar call_Caesar = new Caesar();
                            output = call_Caesar.Encrypt(Convert.ToInt32(input.Key), input.Sometext);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Цезаря";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "Gamal":
                        input.isThree = true;
                        input.Text = "Шифр Эль-Гамаля";
                        res = input.ShowDialog();

                        if (res == DialogResult.OK)
                        {
                            Gamal call_Gamal = new Gamal();
                            Tuple<int, int, int> KeysGamal = call_Gamal.CreatKey(Convert.ToInt32(input.Key), Convert.ToInt32(input.KeyP), Convert.ToInt32(input.KeyQ));
                            output = call_Gamal.Encrypt(KeysGamal.Item1, KeysGamal.Item2, KeysGamal.Item3, input.Sometext);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Эль-Гамаля";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "Atbash":
                        input.Text = "Шифр Атбаш";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Atbash call_Atbash = new Atbash();
                            output = call_Atbash.Encrypt(input.Sometext);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Атбаш";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "Visener":
                        input.Text = "Шифр Виженера";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Visener call_Visener = new Visener();
                            output = call_Visener.Encrypt(input.Sometext, input.Key);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Виженера";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "RSA":
                        input.Text = "RSA";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            RSA call_RSA = new RSA();
                            Tuple<int, int, int> KeysRSA = call_RSA.CreatKey(Convert.ToInt32(input.Key));
                            output = call_RSA.Encrypt(input.Sometext, KeysRSA.Item1, KeysRSA.Item2, KeysRSA.Item3);
                            call_WF.ToFile(output);
                            call_Output.Text = "RSA";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "Gronsfeld":
                        input.Text = "Шифр Гронсфельда";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Gronsfeld call_Gronsfeld = new Gronsfeld();
                            output = call_Gronsfeld.Encrypt(Convert.ToInt32(input.Key), input.Sometext);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Гронсфельда";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "DES":
                        input.Text = "DES";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            DES call_DES = new DES();
                            Tuple<string, string> MessaKey = call_DES.Encrypt(input.Sometext, input.Key);
                            call_WF.ToFile(MessaKey.Item1);
                            call_Output.Text = "DES";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = MessaKey.Item1 + Environment.NewLine + "Сгенерированный ключ расшифровки(скопируйте):" + Environment.NewLine + MessaKey.Item2;
                        }
                        break;
                    case "Skitala":
                        input.Text = "Шифр Скитала";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Skitala call_Skitala = new Skitala();
                            output = call_Skitala.Encrypt(Convert.ToInt32(input.Key), input.Sometext);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Скитала";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "Table":
                        input.Text = "Табличная шифровка с ключевым словом";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Table call_Table = new Table();
                            output = call_Table.Encrypt(input.Sometext, input.Key);
                            call_WF.ToFile(output);
                            call_Output.Text = "Табличная шифровка с ключевым словом";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "Rijndael":
                        input.Text = "Rijndael";
                        input.isDouble = true;
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            Rijndael call_Rijndael = new Rijndael();
                            output = call_Rijndael.Encrypt(input.Sometext, input.Key, input.KeyP);
                            call_WF.ToFile(output);
                            call_Output.Text = "Шифр Риндаэля";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    case "RC4":
                        input.Text = "RC4";
                        res = input.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            RC4 call_RC4 = new RC4();
                            output = call_RC4.Do(input.Sometext, input.Key);
                            call_WF.ToFile(output);
                            call_Output.Text = "RC4";
                            call_Output.hat.Text = "Зашифрованный текст:";
                            call_Output.Sometext = output;
                        }
                        break;
                    default :
                        MessageBox.Show("Выберите алгоритм!");
                        break;
                }
                if(res == DialogResult.OK)
                {
                    call_Output.Show();
                }                
            }
            else
            {
                if (shifr == "ERROR")
                {
                    MessageBox.Show("Выберите алгоритм!");
                }
                else
                {
                    string pathFrom = "", pathTo = "";
                    bool isTest = false;
                    using (OpenFileDialog openFile = new OpenFileDialog())
                    {
                        openFile.Title = "Выберите файл, который хотите зашифровать";
                        openFile.Filter = "Txt Файлы| *.txt";

                        if (openFile.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                pathFrom = openFile.FileName;
                                isTest = true;
                            }
                            catch
                            {
                                isTest = false;
                                MessageBox.Show("Ошибка доступа к файлу");
                            }                                                                                                              
                        }
                        else
                        {
                            isTest = false;
                        }
                    }
                    if (pathFrom != "")
                    {
                        using (SaveFileDialog saveFile = new SaveFileDialog())
                        {
                            saveFile.Title = "Выберите файл, в который хотите записать зашифрованый текст";
                            saveFile.Filter = "Txt Файлы| *.txt";

                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {
                                    pathTo = saveFile.FileName;
                                    isTest = true;
                                }
                                catch
                                {
                                    isTest = false;
                                    MessageBox.Show("Ошибка доступа к файлу");
                                }
                                
                            }
                            else
                            {
                                isTest = false;
                            }
                        }
                        if (isTest)
                        {
                            if (pathFrom != pathTo)
                            {
                                Encrypt input = new Encrypt();
                                input.isShowMe = false;
                                EncrypterFile(pathFrom, shifr, pathTo);
                            }
                            else
                            {
                                MessageBox.Show("Нельзя перезаписывать файл");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка доступа к файлам");
                        }
                    }        
                }
            }
        }

        //Асинхронная функция шифровки файла
        async void EncrypterFile(string pathFrom, string shifr, string pathTo)
        {
            await Task.Run(() =>
            {
                call_WF.EncryptFile(pathFrom, shifr, pathTo);
            });
        }

        Dekrypt decrypt = new Dekrypt();
        Output call_output = new Output();
        private void Decrypt_Click(object sender, EventArgs e)
        {
            decrypt.isThree = false;
            decrypt.isDouble = false;
            if (Convert.ToInt32(textOrFile.Value.ToString()) == 0)
            {
                string message = call_WF.FromFiles();
                if (message != null)
                {
                    var res = DialogResult.Cancel;
                    decrypt.shifr = shifr;
                    switch (shifr)
                    {
                        case "Caesar":
                            decrypt.Text = "Шифр Цезаря";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                Caesar call_Caesar = new Caesar();
                                call_output.Text = "Шифр Цезаря";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Caesar.Decrypt(Convert.ToInt32(decrypt.Key), message);
                            }
                            break;
                        case "Visener":
                            decrypt.Text = "Шифр Виженера";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                Visener call_Visener = new Visener();
                                call_output.Text = "Шифр Виженера";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Visener.Decrypt(decrypt.Key, message);
                            }
                            break;
                        case "Atbash":
                            Atbash call_Atbash = new Atbash();
                            call_output.Text = "Шифр Атбаш";
                            call_output.hat.Text = "Расшифрованный текст:";
                            call_output.Sometext = call_Atbash.Decrypt(message);
                            call_output.ShowDialog();
                            break;
                        case "RSA":
                            decrypt.Text = "RSA";
                            decrypt.isDouble = true;
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                RSA call_RSA = new RSA(); call_output.Text = "RSA";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_RSA.Decrypt(Convert.ToInt32(decrypt.Key), Convert.ToInt32(decrypt.KeyP), message);
                            }
                            break;
                        case "Gronsfeld":
                            decrypt.Text = "Шифр Гронсфельда";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                Gronsfeld call_Gronsfeld = new Gronsfeld();
                                call_output.Text = "Шифр Гронсфельда";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Gronsfeld.Decrypt(Convert.ToInt32(decrypt.Key), message);
                            }
                            break;
                        case "Skitala":
                            decrypt.Text = "Шифр Скитала";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                Skitala call_Skitala = new Skitala();
                                call_output.Text = "Шифр Скитала";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Skitala.Decrypt(Convert.ToInt32(decrypt.Key), message);
                            }
                            break;
                        //case "Rijndael":
                        //    decrypt.Text = "Rijndael";
                        //    res = decrypt.ShowDialog();
                        //    decrypt.isDouble = true;
                        //    if (res == DialogResult.OK)
                        //    {
                        //        Rijndael call_Rijndael = new Rijndael();
                        //        call_output.Text = "Rijndael";
                        //        call_output.hat.Text = "Расшифрованный текст:";
                        //        call_output.Sometext = call_Rijndael.Decrypt(message, decrypt.Key, decrypt.KeyP);
                        //    }
                        //    break;
                        case "DES":
                            decrypt.Text = "DES";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                DES call_DES = new DES();
                                call_output.Text = "DES";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_DES.Decrypt(decrypt.Key, message);
                            }
                            break;
                        case "Gamal":
                            decrypt.Text = "Шифр Эль-Гамаля";
                            decrypt.isThree = true;
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                decrypt.isThree = true; Gamal call_Gamal = new Gamal();
                                call_output.Text = "Шифр Эль-Гамаля";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Gamal.Decrypt(Convert.ToInt32(decrypt.Key), Convert.ToInt32(decrypt.KeyP), Convert.ToInt32(decrypt.KeyQ), message);
                            }
                            break;
                        case "Rijndael":
                            decrypt.Text = "Шифр Риндаэля";
                            decrypt.isDouble = true;
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                decrypt.isDouble = true;
                                Rijndael call_Rijndael = new Rijndael();
                                call_output.Text = "Шифр Риндаэля";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Rijndael.Decrypt(message, decrypt.Key, decrypt.KeyP);
                            }
                            break;
                        case "Table":
                            decrypt.Text = "Табличная шифровка с ключевым словом";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                Table call_Table = new Table();
                                call_output.Text = "Табличная шифровка с ключевым словом";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_Table.Decrypt(message, decrypt.Key);
                            }
                            break;
                        case "RC4":
                            decrypt.Text = "RC4";
                            res = decrypt.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                RC4 call_RC4 = new RC4();
                                call_output.Text = "RC4";
                                call_output.hat.Text = "Расшифрованный текст:";
                                call_output.Sometext = call_RC4.Do(message, decrypt.Key);
                                call_output.Text = "RC4";
                                call_output.hat.Text = "Расшифрованный текст:";
                            }
                            break;
                        default:
                            MessageBox.Show("Выберите алгоритм!");
                            break;
                    }
                    if (res == DialogResult.OK)
                    {
                        try
                        {
                            call_output.ShowDialog();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка вызова окна. Перезапустите программу.");
                        }
                    }
                }
            }
            else
            {
                if (shifr == "ERROR")
                {
                    MessageBox.Show("Выберите алгоритм!");
                }
                else
                {
                    string pathFrom = "", pathTo = "";
                    bool isTest = false;
                    using (OpenFileDialog openFile = new OpenFileDialog())
                    {
                        openFile.Title = "Выберите файл, который хотите зашифровать";
                        openFile.Filter = "Txt Файлы| *.txt";

                        if (openFile.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                pathFrom = openFile.FileName;
                                isTest = true;
                            }
                            catch
                            {
                                isTest = false;
                                MessageBox.Show("Ошибка доступа к файлу");
                            }
                        }
                        else
                        {
                            isTest = false;
                        }
                    }
                    if (pathFrom != "")
                    {
                        using (SaveFileDialog saveFile = new SaveFileDialog())
                        {
                            saveFile.Title = "Выберите файл, в который хотите записать зашифрованый текст";
                            saveFile.Filter = "Txt Файлы| *.txt";

                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {
                                    pathTo = saveFile.FileName;
                                    isTest = true;
                                }
                                catch
                                {
                                    isTest = false;
                                    MessageBox.Show("Ошибка доступа к файлу");
                                }
                            }
                            else
                            {
                                isTest = false;
                            }
                        }
                        if (isTest)
                        {
                            if (pathFrom != pathTo)
                            {
                                DecrypterFile(pathFrom, shifr, pathTo);
                            }
                            else
                            {
                                MessageBox.Show("Нельзя перезаписывать файл");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка доступа к файлам");
                        }
                    }
                }                
            }
        }

        async void DecrypterFile(string pathFrom, string shifr, string pathTo)
        {
            await Task.Run(() =>
            {
                call_WF.DecryptFile(pathFrom, shifr, pathTo);
            });
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string password = pass.Text;
            Password chkpas = new Password();
            if (chkpas.CheckPass(password))
            {
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangePass form3 = new ChangePass();
            form3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ResetPass form4 = new ResetPass();
            form4.Show();
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2.PerformClick();
        }

        private void pass_Click(object sender, EventArgs e)
        {
            if (pass.Text == "Введите пароль")
            {
                pass.Clear();
            }
        }
    }
}
