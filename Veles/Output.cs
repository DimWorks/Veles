using System;
using System.Windows.Forms;

namespace Veles
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }
        private void Output_Load(object sender, EventArgs e)
        {
            sometext.Text = Sometext;
        }
        public string Sometext { get; set; }
    }
}
