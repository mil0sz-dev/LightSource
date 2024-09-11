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
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices.ComTypes;

namespace connectionPCB
{
    public partial class Form1 : Form
    {
        string[] ports;

        byte[] dataFrame = { 0xF0, 0x09, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA };
                
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public byte CalculateCrc(byte[] data)
        {
            byte crc = 0;

            for (byte i = 0; i< ((byte)data.Length); i++){
                crc += data[i];
            }

            return crc;
        }
        public void DataTx(byte[] data, int length)
        {
            try
            {
                serialPort1.Write(data, 0, length);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Data transmit timeout.\nPlease check if device is still connected to PC and powered.",
                                "Connection error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //listBoxAvailablePorts.Enabled = true;
                return;
            }
        }

        public byte[] DataRx()
        {
            int bytesInBuffer = serialPort1.BytesToRead;
            byte[] responseBuffer = new byte[bytesInBuffer];
            int bytesRead = 0;


            while (bytesRead < bytesInBuffer)
            {
                int bytesToRead = serialPort1.Read(responseBuffer, bytesRead, bytesInBuffer - bytesRead);
                bytesRead += bytesToRead;
            }
            return responseBuffer;
        }

        public void SendData(byte[] data)
        {
            byte[] dataToSend = new byte[256];
            int dataPtr = 0;
            // Frame to send init
            Array.Copy(dataFrame, dataToSend, dataFrame.Length);
            dataToSend[dataFrame.Length] = ((byte)data.Length);
            for (dataPtr = dataFrame.Length+1; dataPtr <= dataFrame.Length+data.Length; dataPtr++)
            {
                dataToSend[dataPtr] = data[dataPtr - dataFrame.Length -1];
            }
            dataToSend[dataPtr] = CalculateCrc(data);
            DataTx(dataToSend, dataPtr+1);
        }

        private void scanPortsButton_Click(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();

            listBoxAvailablePorts.Items.Clear();
            foreach (string port in ports)
            {
                listBoxAvailablePorts.Items.Add(port);
            }
        }
        private void allowConnection(object sender, EventArgs e)
        {
            buttonConnect.Enabled = true;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonConnect.Text = "Connect";
                listBoxAvailablePorts.Enabled = true;
                comboBoxRange.Enabled = false;
                buttonGetFirmwareVersion.Enabled = false;
                numericUpDownLightValue.Enabled = false;
                buttonSetLight.Enabled = false;
            }
            else
            {
                serialPort1.PortName = ports[listBoxAvailablePorts.SelectedIndex];
                listBoxAvailablePorts.Enabled = false;
                try
                {
                    serialPort1.Open();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ports[listBoxAvailablePorts.SelectedIndex]} port connection timeout.\nTry another port.",
                                    "COM port error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    listBoxAvailablePorts.Enabled = true;
                    return;
                }
                buttonConnect.Text = "Disconnect";
                buttonGetFirmwareVersion.Enabled = true;
                comboBoxRange.Enabled = true;
                numericUpDownLightValue.Enabled = true;
                buttonSetLight.Enabled = true;
            }
        }

        private void buttonGetFirmwareVersion_Click(object sender, EventArgs e)
        {
            labelFirmwareVersion.Text = "";
            byte[] dataToSend = { Commands.GET_DEVICE_NAME};
            SendData(dataToSend);
            int bytesInBuffer = serialPort1.BytesToRead;
            byte[] responseBuffer = new byte[bytesInBuffer];
            int bytesRead = 0;

            
            while (bytesRead < bytesInBuffer)
            {
                int bytesToRead = serialPort1.Read(responseBuffer, bytesRead, bytesInBuffer - bytesRead);
                bytesRead += bytesToRead;
            }
            for(bytesRead = 0; bytesRead < bytesInBuffer; bytesRead++)
            {
                if (responseBuffer[bytesRead] == 0x00) responseBuffer[bytesRead] = 0xAA;
                if (responseBuffer[bytesRead] == 0x09) responseBuffer[bytesRead] = 0xAA;
            }
            string asciiOutput = Encoding.ASCII.GetString(responseBuffer);

            // Wyświetlenie tekstu w Label
            labelFirmwareVersion.Text = asciiOutput;
        }

        private void setLight(object sender, EventArgs e)
        {
            string selectRange = comboBoxRange.SelectedItem.ToString();
            byte range = byte.Parse(selectRange);
            int temp = (int)numericUpDownLightValue.Value>>8;
            int temp2 = (int)numericUpDownLightValue.Value & 0x00FF;
            byte[] dataToSend = {Commands.SET_LIGHT, 0x00, 0x00, 0x00, range, (byte)temp2, (byte)temp };
            SendData(dataToSend);
        }

        private void timerGetParameters_Tick(object sender, EventArgs e)
        {
            byte[] dataToSend = { Commands.GET_LIGHT, 0x00, 0x00, 0x00};
            SendData(dataToSend);

        }
    }
    public class Commands
    {
        public const byte GET_DEVICE_NAME = 0x3F;
        public const byte SET_LIGHT = 0x10;
        public const byte GET_LIGHT = 0x90;
        public const byte TURN_OFF_LIGHT = 0x11;
    }
}
