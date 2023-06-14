using System;
using System.Windows.Forms;

namespace Veles
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Password chkpas = new Password();
            if(chkpas.Reset(pass.Text))
            {
                MessageBox.Show("Пароль был Сброшен");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void pass_Click(object sender, EventArgs e)
        {
            if (pass.Text == "Введите стандартный пароль")
            {
                pass.Clear();
            }
        }
    }
}
