using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.PortName = "COM12";
            serialPort.BaudRate = (int)9600;

            serialPort.Open();
            if (serialPort.IsOpen)
            {
            }
            else
            {

            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived));
        }

        private void SerialReceived(object sender, EventArgs e)
        {
            String strReceive = serialPort.ReadExisting();
            nmeaText.Text = strReceive;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }
    }
}
