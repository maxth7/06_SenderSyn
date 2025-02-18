using System;

namespace emulator
{
    partial class FormEmulator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmulator));
            this.tabControlEmulator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.labelReceiverData = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxSendingPort = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboBoxHandShake = new System.Windows.Forms.ComboBox();
            this.labelHandShake = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxDataSize = new System.Windows.Forms.ComboBox();
            this.labelDataSize = new System.Windows.Forms.Label();
            this.comboBoxBaund = new System.Windows.Forms.ComboBox();
            this.labelBaund = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxNameSendingPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSendInterval = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSendInterval = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxLogFile = new System.Windows.Forms.TextBox();
            this.groupBoxSender = new System.Windows.Forms.GroupBox();
            this.customCheckBoxTI = new emulator.CustomCheckBox();
            this.customCheckBoxRI = new emulator.CustomCheckBox();
            this.customCheckBoxDSR = new emulator.CustomCheckBox();
            this.customCheckBoxCTS = new emulator.CustomCheckBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.customCheckBoxCD = new emulator.CustomCheckBox();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.groupBoxReceivingPort = new System.Windows.Forms.GroupBox();
            this.comboBoxReceivingPort = new System.Windows.Forms.ComboBox();
            this.labelReceivingPort = new System.Windows.Forms.Label();
            this.tabControlEmulator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSendingPort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSendInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxSender.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            this.groupBoxReceivingPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEmulator
            // 
            this.tabControlEmulator.Controls.Add(this.tabPage1);
            this.tabControlEmulator.Controls.Add(this.tabPage2);
            this.tabControlEmulator.Location = new System.Drawing.Point(4, 0);
            this.tabControlEmulator.Name = "tabControlEmulator";
            this.tabControlEmulator.SelectedIndex = 0;
            this.tabControlEmulator.Size = new System.Drawing.Size(446, 326);
            this.tabControlEmulator.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSender);
            this.tabPage1.Controls.Add(this.labelReceiverData);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSender
            // 
            this.textBoxSender.Enabled = false;
            this.textBoxSender.ForeColor = System.Drawing.Color.Green;
            this.textBoxSender.Location = new System.Drawing.Point(15, 23);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSender.Size = new System.Drawing.Size(417, 276);
            this.textBoxSender.TabIndex = 1;
            this.textBoxSender.Text = "From port";
            // 
            // labelReceiverData
            // 
            this.labelReceiverData.AutoSize = true;
            this.labelReceiverData.Location = new System.Drawing.Point(3, 3);
            this.labelReceiverData.Name = "labelReceiverData";
            this.labelReceiverData.Size = new System.Drawing.Size(84, 18);
            this.labelReceiverData.TabIndex = 0;
            this.labelReceiverData.Text = "Sent  data";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP Сlient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxSendingPort
            // 
            this.groupBoxSendingPort.Controls.Add(this.buttonStart);
            this.groupBoxSendingPort.Controls.Add(this.comboBoxMode);
            this.groupBoxSendingPort.Controls.Add(this.labelMode);
            this.groupBoxSendingPort.Controls.Add(this.comboBoxHandShake);
            this.groupBoxSendingPort.Controls.Add(this.labelHandShake);
            this.groupBoxSendingPort.Controls.Add(this.comboBox1);
            this.groupBoxSendingPort.Controls.Add(this.labelParity);
            this.groupBoxSendingPort.Controls.Add(this.comboBoxDataSize);
            this.groupBoxSendingPort.Controls.Add(this.labelDataSize);
            this.groupBoxSendingPort.Controls.Add(this.comboBoxBaund);
            this.groupBoxSendingPort.Controls.Add(this.labelBaund);
            this.groupBoxSendingPort.Controls.Add(this.labelName);
            this.groupBoxSendingPort.Controls.Add(this.comboBoxNameSendingPort);
            this.groupBoxSendingPort.Location = new System.Drawing.Point(456, 27);
            this.groupBoxSendingPort.Name = "groupBoxSendingPort";
            this.groupBoxSendingPort.Size = new System.Drawing.Size(258, 295);
            this.groupBoxSendingPort.TabIndex = 1;
            this.groupBoxSendingPort.TabStop = false;
            this.groupBoxSendingPort.Text = "Sending port";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 240);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(245, 38);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Free",
            "PortStore test",
            "Data",
            "Setup"});
            this.comboBoxMode.Location = new System.Drawing.Point(131, 208);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMode.TabIndex = 11;
            this.comboBoxMode.Text = "Free";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(7, 212);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(50, 18);
            this.labelMode.TabIndex = 10;
            this.labelMode.Text = "Mode";
            // 
            // comboBoxHandShake
            // 
            this.comboBoxHandShake.FormattingEnabled = true;
            this.comboBoxHandShake.Items.AddRange(new object[] {
            "OFF",
            "RTS/CTS",
            "Xon/Xoff"});
            this.comboBoxHandShake.Location = new System.Drawing.Point(131, 176);
            this.comboBoxHandShake.Name = "comboBoxHandShake";
            this.comboBoxHandShake.Size = new System.Drawing.Size(121, 26);
            this.comboBoxHandShake.TabIndex = 9;
            this.comboBoxHandShake.Text = "OFF";
            // 
            // labelHandShake
            // 
            this.labelHandShake.AutoSize = true;
            this.labelHandShake.Location = new System.Drawing.Point(7, 176);
            this.labelHandShake.Name = "labelHandShake";
            this.labelHandShake.Size = new System.Drawing.Size(92, 18);
            this.labelHandShake.TabIndex = 8;
            this.labelHandShake.Text = "Handshake";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "none",
            "even",
            "odd",
            "mark"});
            this.comboBox1.Location = new System.Drawing.Point(131, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "none";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(7, 133);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(51, 18);
            this.labelParity.TabIndex = 6;
            this.labelParity.Text = "Parity";
            // 
            // comboBoxDataSize
            // 
            this.comboBoxDataSize.FormattingEnabled = true;
            this.comboBoxDataSize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataSize.Location = new System.Drawing.Point(131, 101);
            this.comboBoxDataSize.Name = "comboBoxDataSize";
            this.comboBoxDataSize.Size = new System.Drawing.Size(121, 26);
            this.comboBoxDataSize.TabIndex = 5;
            this.comboBoxDataSize.Text = "8";
            // 
            // labelDataSize
            // 
            this.labelDataSize.AutoSize = true;
            this.labelDataSize.Location = new System.Drawing.Point(7, 101);
            this.labelDataSize.Name = "labelDataSize";
            this.labelDataSize.Size = new System.Drawing.Size(79, 18);
            this.labelDataSize.TabIndex = 4;
            this.labelDataSize.Text = "Data size";
            // 
            // comboBoxBaund
            // 
            this.comboBoxBaund.FormattingEnabled = true;
            this.comboBoxBaund.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400"});
            this.comboBoxBaund.Location = new System.Drawing.Point(131, 58);
            this.comboBoxBaund.Name = "comboBoxBaund";
            this.comboBoxBaund.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBaund.TabIndex = 3;
            this.comboBoxBaund.Text = "9600";
            // 
            // labelBaund
            // 
            this.labelBaund.AutoSize = true;
            this.labelBaund.Location = new System.Drawing.Point(7, 61);
            this.labelBaund.Name = "labelBaund";
            this.labelBaund.Size = new System.Drawing.Size(55, 18);
            this.labelBaund.TabIndex = 2;
            this.labelBaund.Text = "Baund";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // comboBoxNameSendingPort
            // 
            this.comboBoxNameSendingPort.FormattingEnabled = true;
            this.comboBoxNameSendingPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBoxNameSendingPort.Location = new System.Drawing.Point(131, 23);
            this.comboBoxNameSendingPort.Name = "comboBoxNameSendingPort";
            this.comboBoxNameSendingPort.Size = new System.Drawing.Size(121, 26);
            this.comboBoxNameSendingPort.TabIndex = 0;
            this.comboBoxNameSendingPort.Text = "COM4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxSendInterval);
            this.groupBox1.Controls.Add(this.comboBoxDataType);
            this.groupBox1.Location = new System.Drawing.Point(456, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // groupBoxSendInterval
            // 
            this.groupBoxSendInterval.Controls.Add(this.label1);
            this.groupBoxSendInterval.Controls.Add(this.numericUpDownSendInterval);
            this.groupBoxSendInterval.Location = new System.Drawing.Point(3, 63);
            this.groupBoxSendInterval.Name = "groupBoxSendInterval";
            this.groupBoxSendInterval.Size = new System.Drawing.Size(248, 52);
            this.groupBoxSendInterval.TabIndex = 5;
            this.groupBoxSendInterval.TabStop = false;
            this.groupBoxSendInterval.Text = "Sending interval (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max=4000 ms";
            // 
            // numericUpDownSendInterval
            // 
            this.numericUpDownSendInterval.Location = new System.Drawing.Point(10, 22);
            this.numericUpDownSendInterval.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownSendInterval.Name = "numericUpDownSendInterval";
            this.numericUpDownSendInterval.Size = new System.Drawing.Size(85, 24);
            this.numericUpDownSendInterval.TabIndex = 2;
            this.numericUpDownSendInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "Random text",
            "Text string",
            "Text file",
            "Binary file",
            "",
            "",
            ""});
            this.comboBoxDataType.Location = new System.Drawing.Point(9, 23);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(236, 26);
            this.comboBoxDataType.TabIndex = 0;
            this.comboBoxDataType.Text = "Text string";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBoxLogFile);
            this.groupBox2.Location = new System.Drawing.Point(456, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LogFile name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxLogFile
            // 
            this.textBoxLogFile.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogFile.Name = "textBoxLogFile";
            this.textBoxLogFile.Size = new System.Drawing.Size(239, 24);
            this.textBoxLogFile.TabIndex = 0;
            this.textBoxLogFile.Text = "LogFile.txt";
            // 
            // groupBoxSender
            // 
            this.groupBoxSender.Controls.Add(this.customCheckBoxTI);
            this.groupBoxSender.Controls.Add(this.customCheckBoxRI);
            this.groupBoxSender.Controls.Add(this.customCheckBoxDSR);
            this.groupBoxSender.Controls.Add(this.customCheckBoxCTS);
            this.groupBoxSender.Controls.Add(this.checkBoxRTS);
            this.groupBoxSender.Controls.Add(this.checkBoxDTR);
            this.groupBoxSender.Controls.Add(this.customCheckBoxCD);
            this.groupBoxSender.Location = new System.Drawing.Point(3, 331);
            this.groupBoxSender.Name = "groupBoxSender";
            this.groupBoxSender.Size = new System.Drawing.Size(443, 49);
            this.groupBoxSender.TabIndex = 4;
            this.groupBoxSender.TabStop = false;
            this.groupBoxSender.Text = "Modem lines";
            // 
            // customCheckBoxTI
            // 
            this.customCheckBoxTI.AutoSize = true;
            this.customCheckBoxTI.CircleColor = System.Drawing.Color.Black;
            this.customCheckBoxTI.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBoxTI.InnerCircleSize = 10;
            this.customCheckBoxTI.Location = new System.Drawing.Point(385, 19);
            this.customCheckBoxTI.Name = "customCheckBoxTI";
            this.customCheckBoxTI.Size = new System.Drawing.Size(41, 22);
            this.customCheckBoxTI.TabIndex = 10;
            this.customCheckBoxTI.Text = "TI";
            this.customCheckBoxTI.TextWidth = 100;
            this.customCheckBoxTI.UseVisualStyleBackColor = true;
            // 
            // customCheckBoxRI
            // 
            this.customCheckBoxRI.AutoSize = true;
            this.customCheckBoxRI.CircleColor = System.Drawing.Color.Black;
            this.customCheckBoxRI.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBoxRI.InnerCircleSize = 10;
            this.customCheckBoxRI.Location = new System.Drawing.Point(69, 19);
            this.customCheckBoxRI.Name = "customCheckBoxRI";
            this.customCheckBoxRI.Size = new System.Drawing.Size(43, 22);
            this.customCheckBoxRI.TabIndex = 9;
            this.customCheckBoxRI.Text = "RI";
            this.customCheckBoxRI.TextWidth = 100;
            this.customCheckBoxRI.UseVisualStyleBackColor = true;
            // 
            // customCheckBoxDSR
            // 
            this.customCheckBoxDSR.AutoSize = true;
            this.customCheckBoxDSR.CircleColor = System.Drawing.Color.Black;
            this.customCheckBoxDSR.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBoxDSR.InnerCircleSize = 10;
            this.customCheckBoxDSR.Location = new System.Drawing.Point(118, 19);
            this.customCheckBoxDSR.Name = "customCheckBoxDSR";
            this.customCheckBoxDSR.Size = new System.Drawing.Size(62, 22);
            this.customCheckBoxDSR.TabIndex = 8;
            this.customCheckBoxDSR.Text = "DSR";
            this.customCheckBoxDSR.TextWidth = 100;
            this.customCheckBoxDSR.UseVisualStyleBackColor = true;
            // 
            // customCheckBoxCTS
            // 
            this.customCheckBoxCTS.AutoSize = true;
            this.customCheckBoxCTS.CircleColor = System.Drawing.Color.Black;
            this.customCheckBoxCTS.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBoxCTS.InnerCircleSize = 10;
            this.customCheckBoxCTS.Location = new System.Drawing.Point(186, 19);
            this.customCheckBoxCTS.Name = "customCheckBoxCTS";
            this.customCheckBoxCTS.Size = new System.Drawing.Size(60, 22);
            this.customCheckBoxCTS.TabIndex = 7;
            this.customCheckBoxCTS.Text = "CTS";
            this.customCheckBoxCTS.TextWidth = 100;
            this.customCheckBoxCTS.UseVisualStyleBackColor = true;
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Enabled = false;
            this.checkBoxRTS.Location = new System.Drawing.Point(319, 19);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(60, 22);
            this.checkBoxRTS.TabIndex = 5;
            this.checkBoxRTS.Text = "RTS";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Enabled = false;
            this.checkBoxDTR.Location = new System.Drawing.Point(252, 19);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(61, 22);
            this.checkBoxDTR.TabIndex = 4;
            this.checkBoxDTR.Text = "DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            // 
            // customCheckBoxCD
            // 
            this.customCheckBoxCD.AutoSize = true;
            this.customCheckBoxCD.CircleColor = System.Drawing.Color.Black;
            this.customCheckBoxCD.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBoxCD.InnerCircleSize = 10;
            this.customCheckBoxCD.Location = new System.Drawing.Point(12, 19);
            this.customCheckBoxCD.Name = "customCheckBoxCD";
            this.customCheckBoxCD.Size = new System.Drawing.Size(51, 22);
            this.customCheckBoxCD.TabIndex = 0;
            this.customCheckBoxCD.Text = "CD";
            this.customCheckBoxCD.TextWidth = 100;
            this.customCheckBoxCD.UseVisualStyleBackColor = true;
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.textBoxMessages);
            this.groupBoxMessages.Location = new System.Drawing.Point(4, 386);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(436, 172);
            this.groupBoxMessages.TabIndex = 7;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.ForeColor = System.Drawing.Color.Blue;
            this.textBoxMessages.Location = new System.Drawing.Point(4, 21);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessages.Size = new System.Drawing.Size(426, 145);
            this.textBoxMessages.TabIndex = 0;
            this.textBoxMessages.Text = "Messages";
            // 
            // groupBoxReceivingPort
            // 
            this.groupBoxReceivingPort.Controls.Add(this.comboBoxReceivingPort);
            this.groupBoxReceivingPort.Controls.Add(this.labelReceivingPort);
            this.groupBoxReceivingPort.Location = new System.Drawing.Point(456, 331);
            this.groupBoxReceivingPort.Name = "groupBoxReceivingPort";
            this.groupBoxReceivingPort.Size = new System.Drawing.Size(258, 54);
            this.groupBoxReceivingPort.TabIndex = 8;
            this.groupBoxReceivingPort.TabStop = false;
            this.groupBoxReceivingPort.Text = "Receiving port";
            // 
            // comboBoxReceivingPort
            // 
            this.comboBoxReceivingPort.FormattingEnabled = true;
            this.comboBoxReceivingPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBoxReceivingPort.Location = new System.Drawing.Point(129, 17);
            this.comboBoxReceivingPort.Name = "comboBoxReceivingPort";
            this.comboBoxReceivingPort.Size = new System.Drawing.Size(121, 26);
            this.comboBoxReceivingPort.TabIndex = 3;
            this.comboBoxReceivingPort.Text = "COM3";
            // 
            // labelReceivingPort
            // 
            this.labelReceivingPort.AutoSize = true;
            this.labelReceivingPort.Location = new System.Drawing.Point(10, 20);
            this.labelReceivingPort.Name = "labelReceivingPort";
            this.labelReceivingPort.Size = new System.Drawing.Size(52, 18);
            this.labelReceivingPort.TabIndex = 2;
            this.labelReceivingPort.Text = "Name";
            // 
            // FormEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 571);
            this.Controls.Add(this.groupBoxReceivingPort);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.groupBoxSender);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSendingPort);
            this.Controls.Add(this.tabControlEmulator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormEmulator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sender";
            this.tabControlEmulator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxSendingPort.ResumeLayout(false);
            this.groupBoxSendingPort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxSendInterval.ResumeLayout(false);
            this.groupBoxSendInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSendInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSender.ResumeLayout(false);
            this.groupBoxSender.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBoxReceivingPort.ResumeLayout(false);
            this.groupBoxReceivingPort.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.TabControl tabControlEmulator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Label labelReceiverData;
        private System.Windows.Forms.GroupBox groupBoxSendingPort;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxNameSendingPort;
        private System.Windows.Forms.ComboBox comboBoxDataSize;
        private System.Windows.Forms.Label labelDataSize;
        private System.Windows.Forms.ComboBox comboBoxBaund;
        private System.Windows.Forms.Label labelBaund;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboBoxHandShake;
        private System.Windows.Forms.Label labelHandShake;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxSender;
        private System.Windows.Forms.TextBox textBoxLogFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.NumericUpDown numericUpDownSendInterval;
        private System.Windows.Forms.GroupBox groupBoxSendInterval;
        private System.Windows.Forms.Label label1;
        private CustomCheckBox customCheckBoxCD;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private CustomCheckBox customCheckBoxTI;
        private CustomCheckBox customCheckBoxRI;
        private CustomCheckBox customCheckBoxDSR;
        private CustomCheckBox customCheckBoxCTS;
        private System.Windows.Forms.GroupBox groupBoxReceivingPort;
        private System.Windows.Forms.ComboBox comboBoxReceivingPort;
        private System.Windows.Forms.Label labelReceivingPort;
    }
}

