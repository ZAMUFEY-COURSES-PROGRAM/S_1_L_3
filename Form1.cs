using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_l_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //HERE
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MESSAGEBOX
            //MessageBox.Show("This is simple messagebox!");
            MessageBox.Show("This is a Message", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                MessageBox.Show("Cltr and X is clicked");
            }
        }
    }
}
