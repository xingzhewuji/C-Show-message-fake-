using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MessageModule
{
    public partial class FormShowMessage : Form
    {
        public string mess;
        public FormShowMessage()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Enabled = true;
            mess = ":message";

            
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        public void ShowMessage()
        {

            textBox1.AppendText(System.DateTime.Now.ToString() + ":Start making connection"+"\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Connecting." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Connecting.." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Connecting..." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Complete the connection" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Start receiving data" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Receiving." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Receiving.." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Receiving..." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Complete the receiving" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Receive 65535 bytes form 127.12.1.6" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Show message" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + mess + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Start deconding" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Deconding." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Deconding.." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Deconding..." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Complete deconding" + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Translating..." + "\r\n");
            MySleep(2000);
            textBox1.AppendText(System.DateTime.Now.ToString() + ":Successful!" + "\r\n");
            MySleep(2000);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Enabled = false;
            ShowMessage();
        }
        public static void MySleep(uint ms)
        {
            uint start = GetTickCount();
            while (GetTickCount() - start < ms)
            {
                Application.DoEvents();
            }
        }
    }
}
