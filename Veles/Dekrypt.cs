using System;
using System.Windows.Forms;

namespace Veles
{
    public partial class Dekrypt : Form
    {
        public Dekrypt()
        {
            InitializeComponent();
            this.KeyPreview = true; // Говорим, что следим за нажатием клавиши в данной форме
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
        }
        public string Key { get; set; }
        public string KeyP { get; set; }
        public string KeyQ { get; set; }
        public bool isDouble { get; set; }
        public bool isThree { get; set; }

        private void enter_Click(object sender, EventArgs e)
        {
            this.Key = key.Text;
            this.KeyP = keyP.Text;
            this.KeyQ = keyQ.Text;

            switch (shifr)
            {
                case "Caesar":
                    if (int.TryParse(Key, out int key))
                    {
                        if (key > 0 && key < 8000)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.None;
                            MessageBox.Show("Ключ должен быть положительным целым числом\nв диапазоне от 0 до 8000");
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Ключ должен быть положительным целым числом\nв диапазоне от 0 до 8000");
                    }
                    break;
                case "Visener":
                    if(Key.Length != 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Введите ключ");
                    }
                    break;
                case "Table":
                    if (Key.Length != 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Введите ключ");
                    }
                    break;
                case "Gamal":
                    if (int.TryParse(Key, out int key1) && int.TryParse(KeyP, out int keyP) && int.TryParse(KeyQ, out int keyQ))
                    {
                        if (key1 > 0 && keyP > 0 && keyQ > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.None;
                            MessageBox.Show("Ключ должен быть положительным целым числом, \nили вы привысили допустимый размер ключа");
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Ключ должен быть положительным целым числом, \nили вы привысили допустимый размер ключа");
                    }
                    break;
                case "RSA":
                    if (int.TryParse(Key, out int keyR))
                    {
                        if (keyR > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.None;
                            MessageBox.Show("Ключ должен быть положительным целым числом, \nили вы привысили допустимый размер ключа");
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Ключ должен быть положительным целым числом, \nили вы привысили допустимый размер ключа");
                    }
                    break;
                case "DES":
                    if (Key.Length > 3 && Key.Length < 17)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Ключь должен содержать не менее 4-х символов\n и не более 16-ти");
                    }
                    break;
                case "Rijndael":
                    if (Key.Length == 8 && KeyP.Length == 8)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Ключи должны состоять из 8-ми символов");
                    }
                    break;
                default:
                    if (int.TryParse(Key, out int keyD))
                    {
                        if (keyD > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.None;
                            MessageBox.Show("Ключ должен быть положительным целым числом, \nили вы привысили допустимый размер ключа");
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                        MessageBox.Show("Ключ должен быть положительным целым числом, \nили вы привысили допустимый размер ключа");
                    }
                    break;
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) enter.PerformClick();
        }

        private void canel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        

        private void key_Click(object sender, EventArgs e)
        {
            if (key.Text == "Введите ключ")
            {
                key.Clear();
            }
        }

        private void keyP_Click(object sender, EventArgs e)
        {
            if (keyP.Text == "Введите ключ p")
            {
                keyP.Clear();
            }
        }

        private void keyQ_Click(object sender, EventArgs e)
        {
            if (keyQ.Text == "Введите ключ q")
            {
                keyQ.Clear();
            }
        }

        public string shifr { get; set; }

        private void Dekrypt_Load(object sender, EventArgs e)
        {
            key.Text = "Введите ключ";
            keyP.Text = "Введите ключ p";
            keyQ.Text = "Введите ключ q";
            ToolTip toolTip = new ToolTip();

            if (shifr == "Visener" || shifr == "Table")
            {
                toolTip.SetToolTip(isKey, "Необходимо ввести ключ состоящий из слова или набора символов");
            }
            //else if (shifr == "Atbash")
            //{
            //    toolTip.SetToolTip(isKey, "Необходимо ввести ключ состоящий из слова или набора символов");
            //    key.Visible = false;
            //    isKey.Visible = false;
            //}
            else if (shifr == "Caeser")
            {
                toolTip.SetToolTip(isKey, "Необходимо ввести положительное число меньше 8000");
            }
            else if (shifr == "DES")
            {
                toolTip.SetToolTip(isKey, "Ключь должен содержать не менее 4-х символов\n и не более 16-ти");
            }
            else if (shifr == "Rijndael")
            {
                toolTip.SetToolTip(isKey, "Необходимо ввести ключ состоящий из слова или набора не менее 8-ми символов");
                toolTip.SetToolTip(isKeyP, "Необходимо ввести ключ состоящий из слова или набора не менее 8-ми символов");
            }
            else
            {
                toolTip.SetToolTip(isKey, "Необходимо ввести положительное число");
            }

            if (isDouble)
            {
                keyP.Visible = true;
                isKeyP.Visible = true;
            }
            else if (isThree)
            {
                keyP.Visible = true;
                keyQ.Visible = true;
                isKeyP.Visible = true;
                isKeyQ.Visible = true;
            }
            else
            {
                keyP.Visible = false;
                keyQ.Visible = false;
                isKeyP.Visible = false;
                isKeyQ.Visible = false;
            }
        }
    }
}
