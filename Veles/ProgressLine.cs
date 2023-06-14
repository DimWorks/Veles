using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Veles
{
    public partial class ProgressLine : Form
    {
        public ProgressLine()
        {
            InitializeComponent();
        }

        public void ProgressingWork( int value)
        {
            progressBar1.Value = value;
            progressBar1.Update();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }
        private void ProgressLine_Load(object sender, EventArgs e)
        {
            progressBar1.Step = 10;

           // WorkingFiles WF = new WorkingFiles();

            //label1.Text = "Test" + WF.DONE;

            //while(true)
            //{
            //    label1.Text = "Test" + WF.DONE;
            //}

        }
    }
}
