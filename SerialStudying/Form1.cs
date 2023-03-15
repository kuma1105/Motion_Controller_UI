using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace SerialStudying
{
    public partial class Form1 : Form
    {
        string dataOUT;
        public Form1()
        {
            InitializeComponent();
            //this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("hello world!");
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendBar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComport.Items.AddRange(ports);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void cBoxComport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                //serialPort1.WriteLine(dataOUT); // 엔터 키 값이 포함되어 있다.
                serialPort1.Write(dataOUT); // 엔터 키 값이 포함되어 있다.
            }
        }
    }
}
