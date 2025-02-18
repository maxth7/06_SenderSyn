using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Xml.Linq;



namespace emulator
{
    internal class SerialPortSender
    {
        private readonly TextBox _outputTextBox;
        private readonly SerialPort _SerialPortSender;

        public SerialPortSender(TextBox outputTextBox, string PortName) 
        {
            _outputTextBox = outputTextBox;
            
            _SerialPortSender = new SerialPort(PortName)
               {
            BaudRate = 9600,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };
           
        }

        public bool IsOpen => _SerialPortSender.IsOpen;

        public void Open()
        {
            if (!_SerialPortSender.IsOpen)
            {
                _SerialPortSender.Open();
            }
        }
        public void Close()
        {
            if (_SerialPortSender.IsOpen)
            {
                _SerialPortSender.Close();
            }
        }

        public void SendString(string data)
        {
            if (_SerialPortSender.IsOpen)
            {
                _SerialPortSender.WriteLine(data);
                UpdateTextBox($"Line sent: {data}\r\n");
            }
            else
            {
                throw new InvalidOperationException("Serial port is not open.");
            }
          
        }

        public void SendBytes(byte[] data)
        {
            if (_SerialPortSender.IsOpen)
            {
                _SerialPortSender.Write(data, 0, data.Length);
                UpdateTextBox($"Bytes sent: {BitConverter.ToString(data)}\r\n");
            }
            else
            {
                throw new InvalidOperationException("Serial port is not open.");
            }
        }
        private void UpdateTextBox(string message)
        {
            if (_outputTextBox.InvokeRequired)
            {
                _outputTextBox.Invoke(new Action(() => _outputTextBox.AppendText(message)));
            }
            else
            {
                _outputTextBox.AppendText(message);
            }
        }
        
    }

}
