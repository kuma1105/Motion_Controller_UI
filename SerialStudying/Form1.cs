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


        public Form1()
        {
            InitializeComponent();
            //this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        // 'Form1'을 불러오면 컴퓨터에 있는 포트 이름을 콤보박스에 넣는다
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();


            // 1
            cBoxComport.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            // For initialize condition
            //chBoxDTREnable.Checked = false; // DTR 상태 초기화
            serialPort1.DtrEnable = false;
            //chBoxRTSEnable.Checked = false; // RTS 상태 초기화
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;    // 데이터 전송 버튼 활성화, 비활성화
            //chBoxWriteLine.Checked = false;
            //chBoxWrite.Checked = true;
            //sendWith = "Write";


            // 2
            cBoxComport_2.Items.AddRange(ports);

            btnOpen_2.Enabled = true;
            btnClose_2.Enabled = false;

            // For initialize condition
            //chBoxDTREnable_2.Checked = false; // DTR 상태 초기화
            serialPort2.DtrEnable = false;
            //chBoxRTSEnable_2.Checked = false; // RTS 상태 초기화
            serialPort2.RtsEnable = false;
            btnSendData_2.Enabled = false;    // 
            //chBoxWriteLine_2.Checked = false;
            //chBoxWrite_2.Checked = true;
            //sendWith_2 = "Write";
        }


        /// <summary>
        /// 1
        /// </summary>
        string dataOUT; // 전송할 데이터가 담긴 변수
        //string sendWith; // "WriteLine" or "Write"

        // 'Open' 버튼을 클릭하면 상태막대를 100으로 설정하고 시리얼 포트를 엽니다
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);                          // 2400, 4800, 9600, 19200, 38400, 57600, 115200
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);                          // 6, 7, 8
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);   // "One", "Two"
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);       // "None", "Odd", "Even"

                serialPort1.Open();
                progressBar1.Value = 100;

                // This is for prevent "Open" button clicked when serial port already active
                btnOpen.Enabled = false;
                btnClose.Enabled = true;

                lblStatusCom.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
        }

        // 'Close'버튼을 누르면 시리얼 포트를 닫고 진행막대를 0으로 초기화한다
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
        }

        // TextBox에 있는 텍스트 데이터를 보낸다
        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.Write(dataOUT);

                //if (sendWith == "WriteLine")
                //{
                //    serialPort1.WriteLine(dataOUT); // 개행한다
                //}
                //else if (sendWith == "Write")
                //{
                //    serialPort1.Write(dataOUT); // 개행하지 않는다
                //}
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("hello world!");
        //}

        // Data Terminal Ready
        //private void chBoxDTREnable_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxDTREnable.Checked)
        //    {
        //        serialPort1.DtrEnable = true;
        //    }
        //    else
        //    {
        //        serialPort1.DtrEnable = false;
        //    }
        //}

        // Request To Send
        //private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxRTSEnable.Checked)
        //    {
        //        serialPort1.RtsEnable = true;
        //    }
        //    else
        //    {
        //        serialPort1.RtsEnable = false;
        //    }
        //}

        // 'Clear Data Out' 버튼을 눌렀을 때 TextBox에 있는 모든 텍스트를 지운다
        //private void btnClearDataOut_Click(object sender, EventArgs e)
        //{
        //    if (tBoxDataOut.Text != "")
        //    {
        //        tBoxDataOut.Text = "";
        //    }
        //}

        // 입력한 명령어 길이를 알려주는 코드
        //private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        //{
        //    int dataOUTLength = tBoxDataOut.TextLength;
        //    //lblDataOutLength.Text = string.Format("{0:00}", dataOUTLength);

        //    // This is for prevent 'Enter' Key to create new line
        //    if (chBoxUsingEnter.Checked)
        //    {
        //        tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
        //    }
        //}

        // 'Using Button'이 체크되어 있으면 'Send Data' 버튼을 활성화시킨다
        //private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxUsingButton.Checked)
        //    {
        //        btnSendData.Enabled = true;
        //    }
        //    else
        //    {
        //        btnSendData.Enabled = false;
        //    }
        //}

        // 텍스트 박스에서 Enter키를 누르면 데이터를 전송한다
        //private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (chBoxUsingEnter.Checked)
        //    {
        //        if (e.KeyCode == Keys.Enter)
        //        {
        //            if (serialPort1.IsOpen)
        //            {
        //                dataOUT = tBoxDataOut.Text;
        //                if (sendWith == "WriteLine")
        //                {
        //                    serialPort1.WriteLine(dataOUT); // 개행한다
        //                }
        //                else if (sendWith == "Write")
        //                {
        //                    serialPort1.Write(dataOUT); // 개행하지 않는다
        //                }
        //            }
        //        }
        //    }
        //}

        //private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxWriteLine.Checked)
        //    {
        //        sendWith = "WriteLine";
        //        chBoxWrite.Checked = false;
        //        chBoxWriteLine.Checked = true;
        //    }
        //}

        //private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxWrite.Checked)
        //    {
        //        sendWith = "Write";
        //        chBoxWrite.Checked = true;
        //        chBoxWriteLine.Checked = false;
        //    }
        //}





        /// <summary>
        /// 2
        /// </summary>
        string dataOUT_2; // 전송할 데이터가 담긴 변수
        //string sendWith_2; // "WriteLine" or "Write"

        // 'Open' 버튼을 클릭하면 상태막대를 100으로 설정하고 시리얼 포트를 엽니다
        private void btnOpen_2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.PortName = cBoxComport_2.Text;
                serialPort2.BaudRate = Convert.ToInt32(cBoxBaudRate_2.Text);
                serialPort2.DataBits = Convert.ToInt32(cBoxDataBits_2.Text);
                serialPort2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits_2.Text);
                serialPort2.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits_2.Text);

                serialPort2.Open();
                progressBar1_2.Value = 100;

                // This is for prevent "Open" button clicked when serial port already active
                btnOpen_2.Enabled = false;
                btnClose_2.Enabled = true;

                lblStatusCom_2.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen_2.Enabled = true;
                btnClose_2.Enabled = false;
                lblStatusCom_2.Text = "OFF";
            }
        }

        // 'Close'버튼을 누르면 시리얼 포트를 닫고 진행막대를 0으로 초기화한다
        private void btnClose_2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                progressBar1_2.Value = 0;
                btnOpen_2.Enabled = true;
                btnClose_2.Enabled = false;
                lblStatusCom_2.Text = "OFF";
            }
        }

        // 'Send' 버튼을 누르면 TextBox에 있는 텍스트 데이터를 보낸다
        private void btnSendData_2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                dataOUT_2 = tBoxDataOut_2.Text;
                serialPort2.Write(dataOUT_2);

                //if (sendWith == "WriteLine")
                //{
                //    serialPort2.WriteLine(dataOUT_2); // 개행한다
                //}
                //else if (sendWith == "Write")
                //{
                //    serialPort2.Write(dataOUT_2); // 개행하지 않는다
                //}
            }
        }

        // Data Terminal Ready
        //private void chBoxDTREnable_2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxDTREnable_2.Checked)
        //    {
        //        serialPort2.DtrEnable = true;
        //    }
        //    else
        //    {
        //        serialPort2.DtrEnable = false;
        //    }
        //}

        // Request To Send
        //private void chBoxRTSEnable_2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxRTSEnable.Checked)
        //    {
        //        serialPort2.RtsEnable = true;
        //    }
        //    else
        //    {
        //        serialPort2.RtsEnable = false;
        //    }
        //}

        // 'Clear Data Out' 버튼을 눌렀을 때 TextBox에 있는 모든 텍스트를 지운다
        //private void btnClearDataOut_2_Click(object sender, EventArgs e)
        //{
        //    if (tBoxDataOut_2.Text != "")
        //    {
        //        tBoxDataOut_2.Text = "";
        //    }
        //}

        // 입력한 명령어 길이를 알려주는 코드
        //private void tBoxDataOut_2_TextChanged(object sender, EventArgs e)
        //{
        //    int dataOUTLength_2 = tBoxDataOut_2.TextLength;
        //    //lblDataOutLength_2.Text = string.Format("{0:00}", dataOUTLength_2);

        //    // This is for prevent 'Enter' Key to create new line
        //    if (chBoxUsingEnter_2.Checked)
        //    {
        //        tBoxDataOut_2.Text = tBoxDataOut_2.Text.Replace(Environment.NewLine, "");
        //    }
        //}

        // 'Using Button'이 체크되어 있으면 'Send Data' 버튼을 활성화시킨다
        //private void chBoxUsingButton_2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxUsingButton_2.Checked)
        //    {
        //        btnSendData_2.Enabled = true;
        //    }
        //    else
        //    {
        //        btnSendData_2.Enabled = false;
        //    }
        //}

        // 텍스트 박스에서 Enter키를 누르면 데이터를 전송한다
        //private void tBoxDataOut_2_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (chBoxUsingEnter_2.Checked)
        //    {
        //        if (e.KeyCode == Keys.Enter)
        //        {
        //            if (serialPort2.IsOpen)
        //            {
        //                dataOUT_2 = tBoxDataOut_2.Text;
        //                if (sendWith == "WriteLine_2")
        //                {
        //                    serialPort2.WriteLine(dataOUT_2); // 개행한다
        //                }
        //                else if (sendWith == "Write_2")
        //                {
        //                    serialPort2.Write(dataOUT_2); // 개행하지 않는다
        //                }
        //            }
        //        }
        //    }
        //}

        //private void chBoxWriteLine_2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxWriteLine_2.Checked)
        //    {
        //        sendWith_2 = "WriteLine_2";
        //        chBoxWrite_2.Checked = false;
        //        chBoxWriteLine_2.Checked = true;
        //    }
        //}

        //private void chBoxWrite_2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxWrite_2.Checked)
        //    {
        //        sendWith_2 = "Write_2";
        //        chBoxWrite_2.Checked = true;
        //        chBoxWriteLine_2.Checked = false;
        //    }
        //}
    }
}
