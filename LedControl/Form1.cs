using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace LedControl
{
    public partial class Form1 : Form
    {

        private TcpClient client = new TcpClient();
        private int rVal, gVal, bVal;
        private byte[] arr = new byte[16];
        private NetworkStream stream;
        private String message;
        public Form1()
        {
            InitializeComponent();
            rVal = bVal = gVal = 0;
            textBox1.Text = rVal.ToString();
            textBox2.Text = gVal.ToString();
            textBox3.Text = bVal.ToString();
            if (tcpConnect()==0)
                textBox4.Text = "Connected!";
        }

        private int tcpConnect()
        {

            try
            {

                client.Connect("192.168.1.74", 7);
                stream = client.GetStream();

            }
            catch(Exception e)
            {
                textBox4.Text = "Connection failed";
                return 1;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset Control
            bVal = Blue.Value;
            message = "S0";
            //arr = System.Text.Encoding.ASCII.GetBytes(message);
            arr[0] = (byte)'S';
            arr[1] = 0;
            stream.Write(arr, 0, 2);
            message = "";
        }

        private void Red_Scroll(object sender, ScrollEventArgs e)
        {
            //Red Control
            rVal = Red.Value;
            textBox1.Text = rVal.ToString();
            //message="R"+ rVal.ToString();
            //arr = System.Text.Encoding.ASCII.GetBytes(message);
            arr[0] = (byte)'R';
            arr[1] = (byte)rVal;
            stream.Write(arr, 0, 2);
            //message = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Green_Scroll(object sender, ScrollEventArgs e)
        {
            //Green Control
            gVal = Green.Value;
            textBox2.Text = gVal.ToString();
            //message = "G" + gVal.ToString();
            //arr = System.Text.Encoding.ASCII.GetBytes(message);
            arr[0] = (byte)'G';
            arr[1] = (byte)gVal;
            stream.Write(arr, 0, 2);
            //message = "";
        }

        private void Blue_Scroll(object sender, ScrollEventArgs e)
        {
            //Blue Control
            bVal = Blue.Value;
            textBox3.Text = bVal.ToString();
            //message = "B" + bVal.ToString();
            //arr = System.Text.Encoding.ASCII.GetBytes(message);
            arr[0] = (byte)'B';
            arr[1] = (byte)bVal;
            stream.Write(arr, 0, arr.Length);
            //message = "";
        }
    }
}
