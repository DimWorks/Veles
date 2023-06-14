using System;
using System.Windows.Forms;

namespace Veles
{
    public partial class KeysRSA : Form
    {
        public KeysRSA()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public string KeyD;
        public string KeyP;
        private void KeysRSA_Load(object sender, EventArgs e)
        {
            keyD.Text = KeyD;
            keyP.Text = KeyP;
        }
    }
}
