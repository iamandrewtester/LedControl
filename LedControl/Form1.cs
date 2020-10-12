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
        private string ip = "192.168.1.74";
        private NetworkStream stream;
        //private String message;
        public Form1()
        {
            InitializeComponent();
            rVal = bVal = gVal = 0;
            redBox.Text = rVal.ToString();
            greenBox.Text = gVal.ToString();
            blueBox.Text = bVal.ToString();
            if (tcpConnect()==0)
                statusBox.Text = "Connected!";
        }

        private int tcpConnect()
        {

            try
            {

                client.Connect(ip, 7);
                stream = client.GetStream();

            }
            catch(Exception e)
            {
                statusBox.Text = "Connection failed";
                return 1;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset Control
            bVal = BlueBar.Value;
            arr[0] = (byte)'S';
            arr[1] = 0;
            stream.Write(arr, 0, 2);
        }

        private void Red_Scroll(object sender, ScrollEventArgs e)
        {
            //Red Control
            rVal = RedBar.Value;
            redBox.Text = rVal.ToString();
            arr[0] = (byte)'R';
            arr[1] = (byte)rVal;
            stream.Write(arr, 0, 2);
        }


        private void Green_Scroll(object sender, ScrollEventArgs e)
        {
            //Green Control
            gVal = GreenBar.Value;
            greenBox.Text = gVal.ToString();
            arr[0] = (byte)'G';
            arr[1] = (byte)gVal;
            stream.Write(arr, 0, 2);
        }

        private void Blue_Scroll(object sender, ScrollEventArgs e)
        {
            //Blue Control
            bVal = BlueBar.Value;
            blueBox.Text = bVal.ToString();
            arr[0] = (byte)'B';
            arr[1] = (byte)bVal;
            stream.Write(arr, 0, arr.Length);
        }
    }
}
