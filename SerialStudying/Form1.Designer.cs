
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
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDTREnable = new System.Windows.Forms.CheckBox();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.chBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chBoxRTSEnable_2 = new System.Windows.Forms.CheckBox();
            this.chBoxDTREnable_2 = new System.Windows.Forms.CheckBox();
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
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength_2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite_2 = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine_2 = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingEnter_2 = new System.Windows.Forms.CheckBox();
            this.chBoxUsingButton_2 = new System.Windows.Forms.CheckBox();
            this.btnClearDataOut_2 = new System.Windows.Forms.Button();
            this.btnSendData_2 = new System.Windows.Forms.Button();
            this.tBoxDataOut_2 = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom_2 = new System.Windows.Forms.Label();
            this.progressBar1_2 = new System.Windows.Forms.ProgressBar();
            this.btnClose_2 = new System.Windows.Forms.Button();
            this.btnOpen_2 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRTSEnable);
            this.groupBox1.Controls.Add(this.chBoxDTREnable);
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
            this.groupBox1.Size = new System.Drawing.Size(227, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Control";
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Font = new System.Drawing.Font("굴림", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxRTSEnable.Location = new System.Drawing.Point(121, 166);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(100, 16);
            this.chBoxRTSEnable.TabIndex = 11;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // chBoxDTREnable
            // 
            this.chBoxDTREnable.AutoSize = true;
            this.chBoxDTREnable.Font = new System.Drawing.Font("굴림", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxDTREnable.Location = new System.Drawing.Point(18, 166);
            this.chBoxDTREnable.Name = "chBoxDTREnable";
            this.chBoxDTREnable.Size = new System.Drawing.Size(100, 16);
            this.chBoxDTREnable.TabIndex = 10;
            this.chBoxDTREnable.Text = "DTR ENABLE";
            this.chBoxDTREnable.UseVisualStyleBackColor = true;
            this.chBoxDTREnable.CheckedChanged += new System.EventHandler(this.chBoxDTREnable_CheckedChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblStatusCom);
            this.groupBox8.Location = new System.Drawing.Point(81, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(140, 132);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "COM PORT STATUS";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.lblStatusCom.Location = new System.Drawing.Point(45, 56);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(52, 27);
            this.lblStatusCom.TabIndex = 3;
            this.lblStatusCom.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 91);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 61);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(69, 61);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 20);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(104, 39);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 20);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(372, 171);
            this.tBoxDataOut.TabIndex = 3;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(239, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 394);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(6, 317);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(372, 71);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDataOutLength.Location = new System.Drawing.Point(241, 35);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(23, 14);
            this.lblDataOutLength.TabIndex = 6;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(113, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data OUT Length : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnClearDataOut);
            this.groupBox4.Controls.Add(this.btnSendData);
            this.groupBox4.Location = new System.Drawing.Point(6, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 114);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(229, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(107, 74);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Location = new System.Drawing.Point(6, 45);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(51, 16);
            this.chBoxWrite.TabIndex = 0;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chBoxWriteLine.Location = new System.Drawing.Point(6, 20);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(81, 17);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxUsingEnter);
            this.groupBox5.Controls.Add(this.chBoxUsingButton);
            this.groupBox5.Location = new System.Drawing.Point(116, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(107, 74);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // chBoxUsingEnter
            // 
            this.chBoxUsingEnter.AutoSize = true;
            this.chBoxUsingEnter.Location = new System.Drawing.Point(6, 45);
            this.chBoxUsingEnter.Name = "chBoxUsingEnter";
            this.chBoxUsingEnter.Size = new System.Drawing.Size(89, 16);
            this.chBoxUsingEnter.TabIndex = 0;
            this.chBoxUsingEnter.Text = "Using Enter";
            this.chBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // chBoxUsingButton
            // 
            this.chBoxUsingButton.AutoSize = true;
            this.chBoxUsingButton.Location = new System.Drawing.Point(6, 20);
            this.chBoxUsingButton.Name = "chBoxUsingButton";
            this.chBoxUsingButton.Size = new System.Drawing.Size(95, 16);
            this.chBoxUsingButton.TabIndex = 0;
            this.chBoxUsingButton.Text = "Using Button";
            this.chBoxUsingButton.UseVisualStyleBackColor = true;
            this.chBoxUsingButton.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_CheckedChanged);
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(6, 64);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(104, 39);
            this.btnClearDataOut.TabIndex = 4;
            this.btnClearDataOut.Text = "Clear Data Out";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox2);
            this.groupBox9.Location = new System.Drawing.Point(12, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(639, 426);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "1";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.groupBox17);
            this.groupBox10.Location = new System.Drawing.Point(657, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(639, 426);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "2";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chBoxRTSEnable_2);
            this.groupBox11.Controls.Add(this.chBoxDTREnable_2);
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
            this.groupBox11.Size = new System.Drawing.Size(227, 191);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "COM Port Control";
            // 
            // chBoxRTSEnable_2
            // 
            this.chBoxRTSEnable_2.AutoSize = true;
            this.chBoxRTSEnable_2.Font = new System.Drawing.Font("굴림", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxRTSEnable_2.Location = new System.Drawing.Point(121, 166);
            this.chBoxRTSEnable_2.Name = "chBoxRTSEnable_2";
            this.chBoxRTSEnable_2.Size = new System.Drawing.Size(100, 16);
            this.chBoxRTSEnable_2.TabIndex = 11;
            this.chBoxRTSEnable_2.Text = "RTS ENABLE";
            this.chBoxRTSEnable_2.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable_2.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_2_CheckedChanged);
            // 
            // chBoxDTREnable_2
            // 
            this.chBoxDTREnable_2.AutoSize = true;
            this.chBoxDTREnable_2.Font = new System.Drawing.Font("굴림", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxDTREnable_2.Location = new System.Drawing.Point(18, 166);
            this.chBoxDTREnable_2.Name = "chBoxDTREnable_2";
            this.chBoxDTREnable_2.Size = new System.Drawing.Size(100, 16);
            this.chBoxDTREnable_2.TabIndex = 10;
            this.chBoxDTREnable_2.Text = "DTR ENABLE";
            this.chBoxDTREnable_2.UseVisualStyleBackColor = true;
            this.chBoxDTREnable_2.CheckedChanged += new System.EventHandler(this.chBoxDTREnable_2_CheckedChanged);
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
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Controls.Add(this.tBoxDataOut_2);
            this.groupBox12.Location = new System.Drawing.Point(239, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(387, 394);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Transmitter Control";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lblDataOutLength_2);
            this.groupBox13.Controls.Add(this.label13);
            this.groupBox13.Location = new System.Drawing.Point(6, 317);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(372, 71);
            this.groupBox13.TabIndex = 6;
            this.groupBox13.TabStop = false;
            // 
            // lblDataOutLength_2
            // 
            this.lblDataOutLength_2.AutoSize = true;
            this.lblDataOutLength_2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDataOutLength_2.Location = new System.Drawing.Point(241, 35);
            this.lblDataOutLength_2.Name = "lblDataOutLength_2";
            this.lblDataOutLength_2.Size = new System.Drawing.Size(23, 14);
            this.lblDataOutLength_2.TabIndex = 6;
            this.lblDataOutLength_2.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(113, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 14);
            this.label13.TabIndex = 5;
            this.label13.Text = "Data OUT Length : ";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox15);
            this.groupBox14.Controls.Add(this.groupBox16);
            this.groupBox14.Controls.Add(this.btnClearDataOut_2);
            this.groupBox14.Controls.Add(this.btnSendData_2);
            this.groupBox14.Location = new System.Drawing.Point(6, 197);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(372, 114);
            this.groupBox14.TabIndex = 5;
            this.groupBox14.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.chBoxWrite_2);
            this.groupBox15.Controls.Add(this.chBoxWriteLine_2);
            this.groupBox15.Location = new System.Drawing.Point(229, 20);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(107, 74);
            this.groupBox15.TabIndex = 6;
            this.groupBox15.TabStop = false;
            // 
            // chBoxWrite_2
            // 
            this.chBoxWrite_2.AutoSize = true;
            this.chBoxWrite_2.Location = new System.Drawing.Point(6, 45);
            this.chBoxWrite_2.Name = "chBoxWrite_2";
            this.chBoxWrite_2.Size = new System.Drawing.Size(51, 16);
            this.chBoxWrite_2.TabIndex = 0;
            this.chBoxWrite_2.Text = "Write";
            this.chBoxWrite_2.UseVisualStyleBackColor = true;
            this.chBoxWrite_2.CheckedChanged += new System.EventHandler(this.chBoxWrite_2_CheckedChanged);
            // 
            // chBoxWriteLine_2
            // 
            this.chBoxWriteLine_2.AutoSize = true;
            this.chBoxWriteLine_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chBoxWriteLine_2.Location = new System.Drawing.Point(6, 20);
            this.chBoxWriteLine_2.Name = "chBoxWriteLine_2";
            this.chBoxWriteLine_2.Size = new System.Drawing.Size(81, 17);
            this.chBoxWriteLine_2.TabIndex = 0;
            this.chBoxWriteLine_2.Text = "WriteLine";
            this.chBoxWriteLine_2.UseVisualStyleBackColor = true;
            this.chBoxWriteLine_2.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_2_CheckedChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.chBoxUsingEnter_2);
            this.groupBox16.Controls.Add(this.chBoxUsingButton_2);
            this.groupBox16.Location = new System.Drawing.Point(116, 20);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(107, 74);
            this.groupBox16.TabIndex = 5;
            this.groupBox16.TabStop = false;
            // 
            // chBoxUsingEnter_2
            // 
            this.chBoxUsingEnter_2.AutoSize = true;
            this.chBoxUsingEnter_2.Location = new System.Drawing.Point(6, 45);
            this.chBoxUsingEnter_2.Name = "chBoxUsingEnter_2";
            this.chBoxUsingEnter_2.Size = new System.Drawing.Size(89, 16);
            this.chBoxUsingEnter_2.TabIndex = 0;
            this.chBoxUsingEnter_2.Text = "Using Enter";
            this.chBoxUsingEnter_2.UseVisualStyleBackColor = true;
            // 
            // chBoxUsingButton_2
            // 
            this.chBoxUsingButton_2.AutoSize = true;
            this.chBoxUsingButton_2.Location = new System.Drawing.Point(6, 20);
            this.chBoxUsingButton_2.Name = "chBoxUsingButton_2";
            this.chBoxUsingButton_2.Size = new System.Drawing.Size(95, 16);
            this.chBoxUsingButton_2.TabIndex = 0;
            this.chBoxUsingButton_2.Text = "Using Button";
            this.chBoxUsingButton_2.UseVisualStyleBackColor = true;
            this.chBoxUsingButton_2.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_2_CheckedChanged);
            // 
            // btnClearDataOut_2
            // 
            this.btnClearDataOut_2.Location = new System.Drawing.Point(6, 64);
            this.btnClearDataOut_2.Name = "btnClearDataOut_2";
            this.btnClearDataOut_2.Size = new System.Drawing.Size(104, 39);
            this.btnClearDataOut_2.TabIndex = 4;
            this.btnClearDataOut_2.Text = "Clear Data Out";
            this.btnClearDataOut_2.UseVisualStyleBackColor = true;
            this.btnClearDataOut_2.Click += new System.EventHandler(this.btnClearDataOut_2_Click);
            // 
            // btnSendData_2
            // 
            this.btnSendData_2.Location = new System.Drawing.Point(6, 20);
            this.btnSendData_2.Name = "btnSendData_2";
            this.btnSendData_2.Size = new System.Drawing.Size(104, 39);
            this.btnSendData_2.TabIndex = 2;
            this.btnSendData_2.Text = "Send Data";
            this.btnSendData_2.UseVisualStyleBackColor = true;
            this.btnSendData_2.Click += new System.EventHandler(this.btnSendData_2_Click);
            // 
            // tBoxDataOut_2
            // 
            this.tBoxDataOut_2.Location = new System.Drawing.Point(6, 20);
            this.tBoxDataOut_2.Multiline = true;
            this.tBoxDataOut_2.Name = "tBoxDataOut_2";
            this.tBoxDataOut_2.Size = new System.Drawing.Size(372, 171);
            this.tBoxDataOut_2.TabIndex = 3;
            this.tBoxDataOut_2.TextChanged += new System.EventHandler(this.tBoxDataOut_2_TextChanged);
            this.tBoxDataOut_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.progressBar1_2);
            this.groupBox17.Controls.Add(this.btnClose_2);
            this.groupBox17.Controls.Add(this.btnOpen_2);
            this.groupBox17.Location = new System.Drawing.Point(6, 217);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(227, 197);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.lblStatusCom_2);
            this.groupBox18.Location = new System.Drawing.Point(81, 20);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(140, 132);
            this.groupBox18.TabIndex = 5;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "COM PORT STATUS";
            // 
            // lblStatusCom_2
            // 
            this.lblStatusCom_2.AutoSize = true;
            this.lblStatusCom_2.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.lblStatusCom_2.Location = new System.Drawing.Point(45, 56);
            this.lblStatusCom_2.Name = "lblStatusCom_2";
            this.lblStatusCom_2.Size = new System.Drawing.Size(52, 27);
            this.lblStatusCom_2.TabIndex = 3;
            this.lblStatusCom_2.Text = "OFF";
            // 
            // progressBar1_2
            // 
            this.progressBar1_2.Location = new System.Drawing.Point(6, 168);
            this.progressBar1_2.Name = "progressBar1_2";
            this.progressBar1_2.Size = new System.Drawing.Size(215, 23);
            this.progressBar1_2.TabIndex = 2;
            // 
            // btnClose_2
            // 
            this.btnClose_2.Location = new System.Drawing.Point(6, 91);
            this.btnClose_2.Name = "btnClose_2";
            this.btnClose_2.Size = new System.Drawing.Size(69, 61);
            this.btnClose_2.TabIndex = 1;
            this.btnClose_2.Text = "Close";
            this.btnClose_2.UseVisualStyleBackColor = true;
            this.btnClose_2.Click += new System.EventHandler(this.btnClose_2_Click);
            // 
            // btnOpen_2
            // 
            this.btnOpen_2.Location = new System.Drawing.Point(6, 20);
            this.btnOpen_2.Name = "btnOpen_2";
            this.btnOpen_2.Size = new System.Drawing.Size(69, 61);
            this.btnOpen_2.TabIndex = 0;
            this.btnOpen_2.Text = "Open";
            this.btnOpen_2.UseVisualStyleBackColor = true;
            this.btnOpen_2.Click += new System.EventHandler(this.btnOpen_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 448);
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
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
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDTREnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxUsingEnter;
        private System.Windows.Forms.CheckBox chBoxUsingButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox chBoxRTSEnable_2;
        private System.Windows.Forms.CheckBox chBoxDTREnable_2;
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
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label lblDataOutLength_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox chBoxWrite_2;
        private System.Windows.Forms.CheckBox chBoxWriteLine_2;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox chBoxUsingEnter_2;
        private System.Windows.Forms.CheckBox chBoxUsingButton_2;
        private System.Windows.Forms.Button btnClearDataOut_2;
        private System.Windows.Forms.Button btnSendData_2;
        private System.Windows.Forms.TextBox tBoxDataOut_2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label lblStatusCom_2;
        private System.Windows.Forms.ProgressBar progressBar1_2;
        private System.Windows.Forms.Button btnClose_2;
        private System.Windows.Forms.Button btnOpen_2;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

