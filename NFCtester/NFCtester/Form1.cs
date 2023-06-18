using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using System.IO.Ports;
using System.IO;

namespace NFCtester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // For Example

            SerialPort mySerial = new SerialPort("COM1", 128000, Parity.None);

            // then you open it

            mySerial.Open();

            // then you send or read data to buffers that you create and name write_buff or read_buff

            mySerial.Write("12312");

            // then you close

            mySerial.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
