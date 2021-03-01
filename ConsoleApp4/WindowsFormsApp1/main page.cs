using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp4;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        log_in f1 = new log_in();
       signup f2 = new signup();

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();

               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}
