using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace DNS
{
    /*class Test
    {
        static void Main(string[] args)
        {
            string ip = "188.120.38.28";
            IPAddress addr = IPAddress.Parse(ip);
            IPHostEntry entry = Dns.GetHostEntry(addr);
            MessageBox.Show(entry.HostName);
        }
    }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ip = "10.10.17.4";
            IPAddress addr = IPAddress.Parse(ip);
            IPHostEntry entry = Dns.GetHostEntry(addr);
            MessageBox.Show(entry.HostName);

        }
    }
}
