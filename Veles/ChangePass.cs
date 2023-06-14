using System;
using System.Windows.Forms;

namespace Veles
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
            this.KeyPreview = true; // Говорим, что следим за нажатием клавиши в данной форме
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
        }

        private void change_Click(object sender, EventArgs e)
        {
            Password chkpas = new Password();
            if (chkpas.CheckPass(oldPass.Text))
            {
                chkpas.NewPass(newPass.Text);
                MessageBox.Show("Пароль был изменён");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void oldPass_Click(object sender, EventArgs e)
        {
            if (oldPass.Text == "Введите старый пароль")
            {
                oldPass.Clear();
            }
        }

        private void newPass_Click(object sender, EventArgs e)
        {
            if (newPass.Text == "Введите новый пароль")
            {
                newPass.Clear();
            }
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) change.PerformClick();
        }
    }
}
