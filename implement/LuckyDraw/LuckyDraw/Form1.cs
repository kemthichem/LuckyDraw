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
        LuckyDrawController luckyDrawController;

        public Form1()
        {
            InitializeComponent();

            tmDeltaTime.Interval = 30;
            serialNumber = new SerialNumber(4);

            luckyDrawController = new LuckyDrawController();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            serialNumber.Draw(e.Graphics);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void btOpenDatabase_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Excel Files (.xls)|*.xls";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            var userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                this.tbDatabase.Text = openFileDialog1.FileName;
            }
        }

        private void ctIExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //luckyDrawController.StartLucky();
            pnControl.Visible = false;
            ctIBack.Enabled = true;
            btDial.Enabled = true;

        }

        private void ctIList_Click(object sender, EventArgs e)
        {
            ListAwardsFrm frm2 = new ListAwardsFrm();
            frm2.ShowDialog();
        }

        private void btDial_Click(object sender, EventArgs e)
        {
            if (luckyDrawController.IsDialing)
            {
                int dialNumber = luckyDrawController.Dial();
                serialNumber.Stop(dialNumber);
                //tmDeltaTime.Stop();

                //
                btDial.Text = "Quay";
            }
            else
            {
                serialNumber.Start();
                tmDeltaTime.Start();

                luckyDrawController.StartLucky();
                //
                btDial.Text = "Chốt";
            }
        }

        private void ctIBack_Click(object sender, EventArgs e)
        {
            pnControl.Visible = true;
            ctIBack.Enabled = false;
            btDial.Enabled = false;
        }

        private void btNextAward_Click(object sender, EventArgs e)
        {

        }

        private void btPreAward_Click(object sender, EventArgs e)
        {

        }

    }
}
