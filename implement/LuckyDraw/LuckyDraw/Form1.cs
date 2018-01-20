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
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            var userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                this.tbDatabase.Text = openFileDialog1.FileName;
            }
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            luckyDrawController.LoadDataBase(this.tbAwardName.Text);
            if (luckyDrawController.StartLucky())
            {
                pnControl.Visible = false;
                ctIBack.Enabled = true;
                btDial.Enabled = true;

                lbCurAward.Text = luckyDrawController.GetCurAwardName();
            }
            else
            {
                MessageBox.Show("Danh sách trống. Hãy chọn cơ sở dữ liệu.", "Bắt đầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ctIList_Click(object sender, EventArgs e)
        {
            ListAwardsFrm frm2 = new ListAwardsFrm(this, luckyDrawController.PersonArchivedList, luckyDrawController.PersonArchivedID);
            frm2.ShowDialog();
        }

        private void btDial_Click(object sender, EventArgs e)
        {
            if (luckyDrawController.IsDialing)
            {
                int personID = luckyDrawController.StopDial();
                serialNumber.Stop(personID);
                //tmDeltaTime.Stop();
                btDial.Enabled = false;
                tmDisplayInfo.Start();

            }
            else
            {
                if (luckyDrawController.StardDial())
                {
                    serialNumber.Start();
                    tmDeltaTime.Start();                    
                    //
                    btDial.Text = "CHỐT";
                    ctIBack.Enabled = false;

                    lbPersonInfo.Visible = false;
                    lbPersonName.Visible = false;
                    
                }          
            }
        }

        private void backToControl()
        {
            pnControl.Visible = true;
            ctIBack.Enabled = false;
            ctISave.Enabled = false;
            ctIList.Enabled = false;
            btDial.Enabled = false;

            lbPersonInfo.Visible = false;
            lbPersonName.Visible = true;

            lbPersonName.Text = "Tên-Bộ Phận";
            lbCurAward.Text = luckyDrawController.GetCurAwardName();
        }

        private void ctIBack_Click(object sender, EventArgs e)
        {
            if (luckyDrawController.IsAbleToBack() || ConfirmToSaveArchivedPerson())
            {
                luckyDrawController.Reset();                                
                serialNumber.Reset();
                backToControl();
            }            
        }


        private void ctISave_Click(object sender, EventArgs e)
        {
            SaveArchivedPerson();
        }

        private void ctIExit_Click(object sender, EventArgs e)
        {
            if (luckyDrawController.IsAbleToBack() || ConfirmToSaveArchivedPerson())
            {
                luckyDrawController.Reset();
                serialNumber.Reset();
                Application.Exit();
            } 
            
        }

        private bool ConfirmToSaveArchivedPerson()
        {
            bool IsToBack = true;
            DialogResult rs = MessageBox.Show("Danh sách trúng giải chưa được lưu.\n Bạn có muốn lưu không?", "Quay về", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (SaveArchivedPerson() == false)
                {
                    IsToBack = false;
                }
            }

            return IsToBack;
        }

        public bool SaveArchivedPerson()
        {
            bool IsSaved = false;

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Danh_sach_trung_giai.xls";
            // set filters - this can be done in properties as well
            savefile.Filter = "Excel files|*.xls;*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                luckyDrawController.SavePersonArchived(savefile.FileName);               
                MessageBox.Show("Lưu thành công", "Lưu danh sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsSaved = true;

                ctISave.Enabled = false;
            }

            return IsSaved;
        }

        private void btNextAward_Click(object sender, EventArgs e)
        {
            luckyDrawController.NextAward();
            lbCurAward.Text = luckyDrawController.GetCurAwardName();
        }

        private void btPreAward_Click(object sender, EventArgs e)
        {
            luckyDrawController.PreAward();
            lbCurAward.Text = luckyDrawController.GetCurAwardName();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //combobox
            BindingCbAward();
            tbAwardName.Text = luckyDrawController.GetCurAwardName();
        }

#region Award: Add, Edit, Remove


        private void cbAward_SelectedIndexChanged(object sender, EventArgs e)
        {
            luckyDrawController.CurrentAwardID = ((Award)cbAward.SelectedItem).ID;
            tbAwardName.Text = cbAward.Text;
        }

        private void BindingCbAward()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = luckyDrawController.AwardList;
            cbAward.DataSource = bs;

            cbAward.DisplayMember = "Name";
            cbAward.ValueMember = "ID";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int newID = luckyDrawController.AddAward(tbAwardName.Text);
            if (newID != -1)
            {
                BindingCbAward();
                cbAward.SelectedValue = newID;
            }
            else
            {
                MessageBox.Show("Giải thưởng đã tồn tại", "Thêm giải thưởng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (luckyDrawController.EditAward(luckyDrawController.CurrentAwardID, tbAwardName.Text))
            {
                int currentIndex = cbAward.SelectedIndex;
                BindingCbAward();
                cbAward.SelectedIndex = currentIndex;
            }
            else
            {
                MessageBox.Show("Giải thưởng đã tồn tại", "Sửa giải thưởng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (luckyDrawController.RemoveAward(luckyDrawController.CurrentAwardID))
            {
                BindingCbAward();
            }
            else
            {
                MessageBox.Show("Không còn giải thưởng để xóa", "Xóa giải thưởng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
#endregion

        private void btBgImage_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Image Files|*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            var userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                this.tbBgImage.Text = openFileDialog1.FileName;
                Image bgImage = new Bitmap(openFileDialog1.FileName);
                this.BackgroundImage = bgImage;
            }
        }

        private void lbPersonName_VisibleChanged(object sender, EventArgs e)
        {            
            lbPersonName.Location = new Point ((this.Width - lbPersonName.Width)/2, 470);
        }

        private void lbPersonInfo_VisibleChanged(object sender, EventArgs e)
        {
            lbPersonInfo.Location = new Point((this.Width - lbPersonInfo.Width) / 2, 570);
        }

        private void lbPersonName_Click(object sender, EventArgs e)
        {
            if (pnControl.Visible == true)
            {
                if (DialogResult.OK == colorDialog1.ShowDialog())
                {
                    lbPersonName.ForeColor = colorDialog1.Color;
                    lbPersonInfo.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void tmDisplayInfo_Tick(object sender, EventArgs e)
        {
            Person person = luckyDrawController.GetPersonArchived();
            if (person != null)
            {
                lbPersonName.Text = person.Name;
                lbPersonInfo.Text = person.Info;
            }
            lbPersonInfo.Visible = true;
            lbPersonName.Visible = true;
            lbCurAward.Text = luckyDrawController.GetCurAwardName();

            btDial.Text = "QUAY SỐ";
            ctIBack.Enabled = true;
            btDial.Enabled = true;

            if (luckyDrawController.PersonList.Count == 0)
                btDial.Enabled = false;
            if (luckyDrawController.HasDataToSave)
            {
                ctIList.Enabled = true;
                ctISave.Enabled = true;
            }

            tmDisplayInfo.Stop();
        }


    }
}
