using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyDraw
{
    public partial class Form1 : Form
    {
        SerialNumber serialNumber;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 30;            
            serialNumber = new SerialNumber(4);
            //this.TransparencyKey = Color.LimeGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialNumber.Start();
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            serialNumber.Draw(e.Graphics);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialNumber.Stop(1059);
            //timer1.Stop();
        }

    }
}
