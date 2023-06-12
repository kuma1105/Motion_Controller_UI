
namespace SerialStudying
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chBoxAddToOldData1 = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate1 = new System.Windows.Forms.CheckBox();
            this.btnClearDataIN1 = new System.Windows.Forms.Button();
            this.tBoxDataIN1 = new System.Windows.Forms.RichTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chBoxAddToOldData2 = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxDataBits_2 = new System.Windows.Forms.ComboBox();
            this.cBoxParityBits_2 = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits_2 = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate_2 = new System.Windows.Forms.ComboBox();
            this.cBoxComport_2 = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnSendData_2 = new System.Windows.Forms.Button();
            this.tBoxDataOut_2 = new System.Windows.Forms.TextBox();
            this.chBoxAlwaysUpdate2 = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom_2 = new System.Windows.Forms.Label();
            this.progressBar1_2 = new System.Windows.Forms.ProgressBar();
            this.btnClose_2 = new System.Windows.Forms.Button();
            this.btnOpen_2 = new System.Windows.Forms.Button();
            this.btnClearDataIN2 = new System.Windows.Forms.Button();
            this.tBoxDataIN2 = new System.Windows.Forms.RichTextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComport);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(89, 78);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 20);
            this.cBoxDataBits.TabIndex = 4;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(89, 131);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 20);
            this.cBoxParityBits.TabIndex = 3;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(89, 105);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 20);
            this.cBoxStopBits.TabIndex = 2;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(89, 52);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxComport
            // 
            this.cBoxComport.FormattingEnabled = true;
            this.cBoxComport.Location = new System.Drawing.Point(89, 26);
            this.cBoxComport.Name = "cBoxComport";
            this.cBoxComport.Size = new System.Drawing.Size(121, 20);
            this.cBoxComport.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(239, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM Port Status";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblStatusCom);
            this.groupBox8.Location = new System.Drawing.Point(81, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(103, 105);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.lblStatusCom.Location = new System.Drawing.Point(26, 42);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(52, 27);
            this.lblStatusCom.TabIndex = 3;
            this.lblStatusCom.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(178, 20);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(69, 46);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(347, 21);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(70, 20);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(335, 20);
            this.tBoxDataOut.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(6, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 54);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chBoxAddToOldData1);
            this.groupBox9.Controls.Add(this.chBoxAlwaysUpdate1);
            this.groupBox9.Controls.Add(this.btnClearDataIN1);
            this.groupBox9.Controls.Add(this.tBoxDataIN1);
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox2);
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(753, 249);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "1";
            // 
            // chBoxAddToOldData1
            // 
            this.chBoxAddToOldData1.AutoSize = true;
            this.chBoxAddToOldData1.Location = new System.Drawing.Point(552, 222);
            this.chBoxAddToOldData1.Name = "chBoxAddToOldData1";
            this.chBoxAddToOldData1.Size = new System.Drawing.Size(112, 16);
            this.chBoxAddToOldData1.TabIndex = 9;
            this.chBoxAddToOldData1.Text = "Add to Old Data";
            this.chBoxAddToOldData1.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData1.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData1_CheckedChanged);
            // 
            // chBoxAlwaysUpdate1
            // 
            this.chBoxAlwaysUpdate1.AutoSize = true;
            this.chBoxAlwaysUpdate1.Location = new System.Drawing.Point(437, 222);
            this.chBoxAlwaysUpdate1.Name = "chBoxAlwaysUpdate1";
            this.chBoxAlwaysUpdate1.Size = new System.Drawing.Size(109, 16);
            this.chBoxAlwaysUpdate1.TabIndex = 9;
            this.chBoxAlwaysUpdate1.Text = "Always Update";
            this.chBoxAlwaysUpdate1.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate1.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate1_CheckedChanged);
            // 
            // btnClearDataIN1
            // 
            this.btnClearDataIN1.Location = new System.Drawing.Point(670, 219);
            this.btnClearDataIN1.Name = "btnClearDataIN1";
            this.btnClearDataIN1.Size = new System.Drawing.Size(75, 20);
            this.btnClearDataIN1.TabIndex = 8;
            this.btnClearDataIN1.Text = "clear";
            this.btnClearDataIN1.UseVisualStyleBackColor = true;
            this.btnClearDataIN1.Click += new System.EventHandler(this.btnClearDataIN1_Click);
            // 
            // tBoxDataIN1
            // 
            this.tBoxDataIN1.Location = new System.Drawing.Point(437, 20);
            this.tBoxDataIN1.Name = "tBoxDataIN1";
            this.tBoxDataIN1.Size = new System.Drawing.Size(309, 196);
            this.tBoxDataIN1.TabIndex = 7;
            this.tBoxDataIN1.Text = "";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chBoxAddToOldData2);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.chBoxAlwaysUpdate2);
            this.groupBox10.Controls.Add(this.groupBox17);
            this.groupBox10.Controls.Add(this.btnClearDataIN2);
            this.groupBox10.Controls.Add(this.tBoxDataIN2);
            this.groupBox10.Location = new System.Drawing.Point(12, 267);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(753, 250);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "2";
            // 
            // chBoxAddToOldData2
            // 
            this.chBoxAddToOldData2.AutoSize = true;
            this.chBoxAddToOldData2.Location = new System.Drawing.Point(552, 222);
            this.chBoxAddToOldData2.Name = "chBoxAddToOldData2";
            this.chBoxAddToOldData2.Size = new System.Drawing.Size(112, 16);
            this.chBoxAddToOldData2.TabIndex = 9;
            this.chBoxAddToOldData2.Text = "Add to Old Data";
            this.chBoxAddToOldData2.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData2.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData2_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.cBoxDataBits_2);
            this.groupBox11.Controls.Add(this.cBoxParityBits_2);
            this.groupBox11.Controls.Add(this.cBoxStopBits_2);
            this.groupBox11.Controls.Add(this.cBoxBaudRate_2);
            this.groupBox11.Controls.Add(this.cBoxComport_2);
            this.groupBox11.Location = new System.Drawing.Point(6, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(227, 162);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "COM Port Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Parity Bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stop Bits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data Bits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "Baud Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "COM Port";
            // 
            // cBoxDataBits_2
            // 
            this.cBoxDataBits_2.FormattingEnabled = true;
            this.cBoxDataBits_2.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits_2.Location = new System.Drawing.Point(89, 78);
            this.cBoxDataBits_2.Name = "cBoxDataBits_2";
            this.cBoxDataBits_2.Size = new System.Drawing.Size(121, 20);
            this.cBoxDataBits_2.TabIndex = 4;
            this.cBoxDataBits_2.Text = "8";
            // 
            // cBoxParityBits_2
            // 
            this.cBoxParityBits_2.FormattingEnabled = true;
            this.cBoxParityBits_2.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits_2.Location = new System.Drawing.Point(89, 131);
            this.cBoxParityBits_2.Name = "cBoxParityBits_2";
            this.cBoxParityBits_2.Size = new System.Drawing.Size(121, 20);
            this.cBoxParityBits_2.TabIndex = 3;
            this.cBoxParityBits_2.Text = "None";
            // 
            // cBoxStopBits_2
            // 
            this.cBoxStopBits_2.FormattingEnabled = true;
            this.cBoxStopBits_2.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits_2.Location = new System.Drawing.Point(89, 105);
            this.cBoxStopBits_2.Name = "cBoxStopBits_2";
            this.cBoxStopBits_2.Size = new System.Drawing.Size(121, 20);
            this.cBoxStopBits_2.TabIndex = 2;
            this.cBoxStopBits_2.Text = "One";
            // 
            // cBoxBaudRate_2
            // 
            this.cBoxBaudRate_2.FormattingEnabled = true;
            this.cBoxBaudRate_2.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.cBoxBaudRate_2.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudRate_2.Location = new System.Drawing.Point(89, 52);
            this.cBoxBaudRate_2.Name = "cBoxBaudRate_2";
            this.cBoxBaudRate_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBoxBaudRate_2.Size = new System.Drawing.Size(121, 20);
            this.cBoxBaudRate_2.TabIndex = 1;
            this.cBoxBaudRate_2.Text = "9600";
            // 
            // cBoxComport_2
            // 
            this.cBoxComport_2.FormattingEnabled = true;
            this.cBoxComport_2.Location = new System.Drawing.Point(89, 26);
            this.cBoxComport_2.Name = "cBoxComport_2";
            this.cBoxComport_2.Size = new System.Drawing.Size(121, 20);
            this.cBoxComport_2.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnSendData_2);
            this.groupBox12.Controls.Add(this.tBoxDataOut_2);
            this.groupBox12.Location = new System.Drawing.Point(6, 188);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(425, 54);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Send Data";
            // 
            // btnSendData_2
            // 
            this.btnSendData_2.Location = new System.Drawing.Point(347, 21);
            this.btnSendData_2.Name = "btnSendData_2";
            this.btnSendData_2.Size = new System.Drawing.Size(70, 20);
            this.btnSendData_2.TabIndex = 2;
            this.btnSendData_2.Text = "Send";
            this.btnSendData_2.UseVisualStyleBackColor = true;
            this.btnSendData_2.Click += new System.EventHandler(this.btnSendData_2_Click);
            // 
            // tBoxDataOut_2
            // 
            this.tBoxDataOut_2.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataOut_2.Multiline = true;
            this.tBoxDataOut_2.Name = "tBoxDataOut_2";
            this.tBoxDataOut_2.Size = new System.Drawing.Size(335, 20);
            this.tBoxDataOut_2.TabIndex = 3;
            // 
            // chBoxAlwaysUpdate2
            // 
            this.chBoxAlwaysUpdate2.AutoSize = true;
            this.chBoxAlwaysUpdate2.Location = new System.Drawing.Point(437, 222);
            this.chBoxAlwaysUpdate2.Name = "chBoxAlwaysUpdate2";
            this.chBoxAlwaysUpdate2.Size = new System.Drawing.Size(109, 16);
            this.chBoxAlwaysUpdate2.TabIndex = 9;
            this.chBoxAlwaysUpdate2.Text = "Always Update";
            this.chBoxAlwaysUpdate2.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate2.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate2_CheckedChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.progressBar1_2);
            this.groupBox17.Controls.Add(this.btnClose_2);
            this.groupBox17.Controls.Add(this.btnOpen_2);
            this.groupBox17.Location = new System.Drawing.Point(239, 20);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(192, 162);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "COM Port Status";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.lblStatusCom_2);
            this.groupBox18.Location = new System.Drawing.Point(81, 20);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(103, 105);
            this.groupBox18.TabIndex = 5;
            this.groupBox18.TabStop = false;
            // 
            // lblStatusCom_2
            // 
            this.lblStatusCom_2.AutoSize = true;
            this.lblStatusCom_2.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.lblStatusCom_2.Location = new System.Drawing.Point(26, 40);
            this.lblStatusCom_2.Name = "lblStatusCom_2";
            this.lblStatusCom_2.Size = new System.Drawing.Size(52, 27);
            this.lblStatusCom_2.TabIndex = 3;
            this.lblStatusCom_2.Text = "OFF";
            // 
            // progressBar1_2
            // 
            this.progressBar1_2.Location = new System.Drawing.Point(6, 131);
            this.progressBar1_2.Name = "progressBar1_2";
            this.progressBar1_2.Size = new System.Drawing.Size(178, 20);
            this.progressBar1_2.TabIndex = 2;
            // 
            // btnClose_2
            // 
            this.btnClose_2.Location = new System.Drawing.Point(6, 78);
            this.btnClose_2.Name = "btnClose_2";
            this.btnClose_2.Size = new System.Drawing.Size(69, 47);
            this.btnClose_2.TabIndex = 1;
            this.btnClose_2.Text = "Close";
            this.btnClose_2.UseVisualStyleBackColor = true;
            this.btnClose_2.Click += new System.EventHandler(this.btnClose_2_Click);
            // 
            // btnOpen_2
            // 
            this.btnOpen_2.Location = new System.Drawing.Point(6, 26);
            this.btnOpen_2.Name = "btnOpen_2";
            this.btnOpen_2.Size = new System.Drawing.Size(69, 46);
            this.btnOpen_2.TabIndex = 0;
            this.btnOpen_2.Text = "Open";
            this.btnOpen_2.UseVisualStyleBackColor = true;
            this.btnOpen_2.Click += new System.EventHandler(this.btnOpen_2_Click);
            // 
            // btnClearDataIN2
            // 
            this.btnClearDataIN2.Location = new System.Drawing.Point(670, 219);
            this.btnClearDataIN2.Name = "btnClearDataIN2";
            this.btnClearDataIN2.Size = new System.Drawing.Size(75, 20);
            this.btnClearDataIN2.TabIndex = 8;
            this.btnClearDataIN2.Text = "clear";
            this.btnClearDataIN2.UseVisualStyleBackColor = true;
            this.btnClearDataIN2.Click += new System.EventHandler(this.btnClearDataIN1_Click);
            // 
            // tBoxDataIN2
            // 
            this.tBoxDataIN2.Location = new System.Drawing.Point(437, 20);
            this.tBoxDataIN2.Name = "tBoxDataIN2";
            this.tBoxDataIN2.Size = new System.Drawing.Size(309, 196);
            this.tBoxDataIN2.TabIndex = 7;
            this.tBoxDataIN2.Text = "";
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 530);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Name = "Form1";
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBoxDataBits_2;
        private System.Windows.Forms.ComboBox cBoxParityBits_2;
        private System.Windows.Forms.ComboBox cBoxStopBits_2;
        private System.Windows.Forms.ComboBox cBoxBaudRate_2;
        private System.Windows.Forms.ComboBox cBoxComport_2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnSendData_2;
        private System.Windows.Forms.TextBox tBoxDataOut_2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label lblStatusCom_2;
        private System.Windows.Forms.ProgressBar progressBar1_2;
        private System.Windows.Forms.Button btnClose_2;
        private System.Windows.Forms.Button btnOpen_2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btnClearDataIN1;
        private System.Windows.Forms.RichTextBox tBoxDataIN1;
        private System.Windows.Forms.CheckBox chBoxAddToOldData1;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate1;
        private System.Windows.Forms.CheckBox chBoxAddToOldData2;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate2;
        private System.Windows.Forms.Button btnClearDataIN2;
        private System.Windows.Forms.RichTextBox tBoxDataIN2;
    }
}

