using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ConsoleApp4.usermethods.getPassword(textBox1.Text))
                MessageBox.Show("true");

            else
                MessageBox.Show(" no true");
        }
    }
}
