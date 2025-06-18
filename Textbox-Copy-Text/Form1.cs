using System;
using System.Windows.Forms;

namespace TextboxCopyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            textBoxB.Text = textBoxA.Text;
        }
    }
}