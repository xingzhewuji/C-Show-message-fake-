using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mess = ":10111100100101011011001111101010110101101010101010011" +
                "1001001110000110010101011100110110100101001011010100110111" +
                "0100011110111010110110011111011010011100110101010101010111" +
                "1111010010101101101010111111011100011110000110101010100111" +
                "11110111100011110011101011111100110101101111001000110010101" +
                "01111001110101101010100111011110011011101010101000011010011" +
                "111011001101101010100100001110110111100110111101101111110101" +
                "1000010111001001011111001101001111001110011010101001010011010" +
                "1111001001010110110011111010101101011010101010100111001001110" +
                "0001100101010111001101101001010010110101001101110100011110111" +
                "0101101100111110110100111001101010101010101111111010010101101" +
                "1010101111110111000111100001101010101001111111011110001111001" +
                "1101011111100110101101111001000110010101011110011101011010101" +
                "0011101111001101110101010100001101001111101100110110101010010" +
                "0001110110111100110111101101111110101100001011100100101111100" +
                "1101001111001110011010110111100100101011011001111101010110101" +
                "1010101010100111001001110000110010101011100110110100101001011" +
                "0101001101110100011110111010110110011111011010011100110101010" +
                "1010101111111010010101101101010111111011100011110000110101010" +
                "10011111110111100011110011101011111100110101101111001000110010" +
                "10101111001110101101010100111011110011011101010101000011010011" +
                "11101100110110101010010000111011011110011011110110111111010110" +
                "000101110010010111110011010011110011100110101101111001001010110" +
                "110011111010101101011010101010100111001001110000110010101011100" +
                "11011010010100101101010011011101000111101110101101100111110110" +
                "100111001101010101010101111111010010101101101010111111011100011" +
                "110000110101010100111111101111000111100111010111111001101011011" +
                "110010001100101010111100111010110101010011101111001101110101010" +
                "1000011010011111011001101101010100100001110110111100110111101101" +
                "1111101011000010111001001011111001101001111001110011010110111100" +
                "1001010110110011111010101101011010101010100111001001110000110010" +
                "1010111001101101001010010110101001101110100011110111010110110011" +
                "1110110100111001101010101010101111111010010101101101010111111011" +
                "1000111100001101010101001111111011110001111001110101111110011010" +
                "11011110010001100101010111100111010110101010011101111001101110101" +
                "01010000110100111110110011011010101001000011101101111001101111011" +
                "0111111010110000101110010010111110011010011110011100110";

            
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
