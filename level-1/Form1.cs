using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace level_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textbox1.Text = textbox.Text.Split(' ').Select(int.Parse).ToArray().Max().ToString();
        }
    }
}
