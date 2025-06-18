using System;
using System.Windows.Forms;

namespace TextboxCheckSameTextApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == textBoxB.Text)
            {
                lblResult.Text = "Both text are same";
            }
            else
            {
                lblResult.Text = "Text not same";
            }
        }

    }
}
