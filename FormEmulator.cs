using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace emulator
{
    public partial class FormEmulator : Form
    {

        private System.Windows.Forms.Timer blinkTimer;
        private readonly Color originalCircleColor; 
        private readonly Color originalInnerCircleColor;

        private  SerialPortSender _serialPortSender;
     
        string dataToSend = "Hello port 3 from port 4!";
        byte[] byteData = { 0x01, 0x02, 0x03 }; 
        string NameReceivingPort;
        string NameSendingPort="";
        public FormEmulator()
        {
            InitializeComponent();
                        
            NameSendingPort = comboBoxNameSendingPort.Text;

            textBoxSender.Enabled = true;

            textBoxMessages.Text = "";
            textBoxSender.Text = "";

            customCheckBoxCD.Checked = true;
            customCheckBoxCD.CircleColor = Color.Green;
            customCheckBoxCD.InnerCircleColor = Color.Green; 

            customCheckBoxRI.Checked = true;
            customCheckBoxRI.CircleColor = Color.Green; 
            customCheckBoxRI.InnerCircleColor = Color.Green;
            
            customCheckBoxDSR.Checked = true;
            customCheckBoxDSR.CircleColor = Color.Green; 
            customCheckBoxDSR.InnerCircleColor = Color.Green; 
            
            customCheckBoxCTS.Checked = true;
            customCheckBoxCTS.CircleColor = Color.Green; 
            customCheckBoxCTS.InnerCircleColor = Color.Green; 
            
            customCheckBoxTI.Checked = true;
            customCheckBoxTI.CircleColor = Color.Black; 
            customCheckBoxTI.InnerCircleColor = Color.Black;

            checkBoxDTR.Enabled = true;
            checkBoxRTS.Enabled = true;

            originalCircleColor = customCheckBoxTI.CircleColor;
            originalInnerCircleColor = customCheckBoxTI.InnerCircleColor;

            blinkTimer = new System.Windows.Forms.Timer();
            int intValue = (int)numericUpDownSendInterval.Value;
            blinkTimer.Interval = intValue;
            blinkTimer.Tick += BlinkTimer_Tick;

        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            customCheckBoxTI.CircleColor = customCheckBoxTI.CircleColor == originalCircleColor
                ? Color.Green
                : originalCircleColor;

            customCheckBoxTI.InnerCircleColor = customCheckBoxTI.InnerCircleColor == originalInnerCircleColor
                    ? Color.Green
                : originalInnerCircleColor;

            if (IsPortAvailable(NameReceivingPort))
            {
                blinkTimer.Stop();

                customCheckBoxTI.CircleColor = Color.Black;
                customCheckBoxTI.InnerCircleColor = Color.Black;

                if (_serialPortSender != null && _serialPortSender.IsOpen)
                {
                    _serialPortSender.Close();
                    buttonStart.Text = "Start";
                }
            }
            
            if (_serialPortSender.IsOpen)
                {
                    string selectedText = comboBoxDataType.Text;
                    if ("Text string" == selectedText)
                    {
                        _serialPortSender.SendString(dataToSend);
                        textBoxMessages.Text = "The data is sent as a string.";
                    }
                
                    else
                    {
                        _serialPortSender.SendBytes(byteData);
                        textBoxMessages.Text = "The data is sent as bytes.";
                    
                    }
                }
                else
                {
                    textBoxMessages.Text= "The port "
                            + NameReceivingPort
                            + " was closed."
                            + Environment.NewLine
                            + "Open the port before sending data.";
                }

        }

       bool IsPortAvailable(string portName)
        {
            try
            {
                using (var testPort = new SerialPort(portName))
                {
                    testPort.Open();
                    testPort.Close();
                }
                textBoxMessages.ForeColor = Color.Red;
                textBoxMessages.AppendText("Checking the recipient's port for availability."
                    + Environment.NewLine
                    + "The port " + portName + "is not open."
                    + Environment.NewLine
                    + "Open the port to Receiver."
                    + Environment.NewLine);

                return true;
            }
            catch
            {
                textBoxMessages.ForeColor = Color.Blue;
                textBoxMessages.AppendText("Checking the recipient's port for availability."
                    + Environment.NewLine
                    + "The port " + portName + "is open."
                    + Environment.NewLine
                    + "Data transfer can be started."
                    + Environment.NewLine);

                return false; 
            }
        }
       
        private void ButtonStartClick(object sender, EventArgs e)
        {
            this.Refresh(); 

            NameReceivingPort = comboBoxReceivingPort.Text;
            if (buttonStart.Text == "Start")
            {
                if (IsPortAvailable(NameReceivingPort))
                {
                  return;
                }
                   
            }
            NameSendingPort = comboBoxNameSendingPort.Text;

            if (buttonStart.Text == "Start")
            {
                if (_serialPortSender != null && _serialPortSender.IsOpen)
                {
                    _serialPortSender.Close();
                }
                _serialPortSender = new SerialPortSender(textBoxSender, NameSendingPort);
               

                if (!_serialPortSender.IsOpen)
                {
                    
                    _serialPortSender.Open();
                    if (_serialPortSender.IsOpen)
                    {
                        textBoxMessages.AppendText("The port "
                        + NameSendingPort
                        + " has just been opened"
                         + Environment.NewLine);
                    }
                    buttonStart.Text = "Stop";
                    buttonStart.Refresh();

                    groupBoxSendInterval.Enabled = false;

                    if (!blinkTimer.Enabled)
                    {

                        blinkTimer.Start();
                        groupBoxSendInterval.Enabled = false;
                    }

                }
                else
                {
                    textBoxMessages.Text = "The port "
                                           + NameSendingPort
                                           + "is already open."
                                           + Environment.NewLine;

                }
            }
            else//  Close
            {
              if (blinkTimer.Enabled)
                {
                    blinkTimer.Stop();
                    customCheckBoxTI.CircleColor = Color.Black;
                    customCheckBoxTI.InnerCircleColor = Color.Black;

                }
                groupBoxSendInterval.Enabled = true;
                try
                {
                    if (_serialPortSender.IsOpen)
                    {
                        _serialPortSender.Close();
                
                        textBoxMessages.Text = "The port "
                                                + NameSendingPort
                                                + " is now closed."
                                                 + Environment.NewLine;
                    }
                    else
                    {
                        textBoxMessages.Text = "The port  "
                                               + NameSendingPort
                                               + "is already closed."
                                                + Environment.NewLine;
                    }
                 
                    buttonStart.Text = "Start";
                    textBoxSender.Text = "";
                    textBoxMessages.Text = "Data transmission stopped"
                                            + Environment.NewLine;
                }
                catch (OperationCanceledException)
                {
                    textBoxMessages.AppendText("Data transmission has been stopped."
                                              + Environment.NewLine);
                }
               
            }
        }
    }
}
