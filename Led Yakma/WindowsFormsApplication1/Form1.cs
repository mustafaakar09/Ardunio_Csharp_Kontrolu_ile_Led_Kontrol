using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//Serial haberleşme için gerekli port eklendi.
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();//port nesnesinden veri türetildi.
        public Form1()
        {
            
            InitializeComponent();

            port.PortName = "COM3";
            port.BaudRate = 9600;
            port.Open();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Write("1");
            label1.Text = "Led Yanıyor";
            button1.Enabled = false;
            button2.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.Write("0");
            label1.Text ="Led Sondu";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port.IsOpen) {
                port.Write("0"); 
                port.Close(); }
        }

    }
}
