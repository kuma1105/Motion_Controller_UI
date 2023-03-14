using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialStudying
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
