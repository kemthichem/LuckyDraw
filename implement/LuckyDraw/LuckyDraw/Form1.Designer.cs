namespace LuckyDraw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmDeltaTime = new System.Windows.Forms.Timer(this.components);
            this.lbCurAward = new System.Windows.Forms.Label();
            this.ctMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctIList = new System.Windows.Forms.ToolStripMenuItem();
            this.ctISave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctIBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ctIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btNextAward = new System.Windows.Forms.Button();
            this.btPreAward = new System.Windows.Forms.Button();
            this.pnControl = new System.Windows.Forms.Panel();
            this.lbLoadingDb = new System.Windows.Forms.Label();
            this.tbAwardName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btBgImage = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btOpenDatabase = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.cbAward = new System.Windows.Forms.ComboBox();
            this.tbBgImage = new System.Windows.Forms.TextBox();
            this.lbPersonInfo = new System.Windows.Forms.Label();
            this.lbPersonName = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbSerialNumber = new System.Windows.Forms.PictureBox();
            this.btDial = new System.Windows.Forms.Button();
            this.tmDisplayInfo = new System.Windows.Forms.Timer(this.components);
            this.ctMainForm.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tmDeltaTime
            // 
            this.tmDeltaTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCurAward
            // 
            this.lbCurAward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCurAward.BackColor = System.Drawing.Color.SlateBlue;
            this.lbCurAward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCurAward.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurAward.ForeColor = System.Drawing.Color.Yellow;
            this.lbCurAward.Location = new System.Drawing.Point(455, 42);
            this.lbCurAward.Name = "lbCurAward";
            this.lbCurAward.Size = new System.Drawing.Size(218, 44);
            this.lbCurAward.TabIndex = 15;
            this.lbCurAward.Text = "GIẢI THƯỞNG";
            this.lbCurAward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCurAward.UseCompatibleTextRendering = true;
            // 
            // ctMainForm
            // 
            this.ctMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctIList,
            this.ctISave,
            this.toolStripSeparator1,
            this.ctIBack,
            this.ctIExit});
            this.ctMainForm.Name = "ctMainForm";
            this.ctMainForm.Size = new System.Drawing.Size(204, 98);
            // 
            // ctIList
            // 
            this.ctIList.Enabled = false;
            this.ctIList.Name = "ctIList";
            this.ctIList.Size = new System.Drawing.Size(203, 22);
            this.ctIList.Text = "Danh sách trúng thưởng";
            this.ctIList.Click += new System.EventHandler(this.ctIList_Click);
            // 
            // ctISave
            // 
            this.ctISave.Enabled = false;
            this.ctISave.Name = "ctISave";
            this.ctISave.Size = new System.Drawing.Size(203, 22);
            this.ctISave.Text = "Lưu";
            this.ctISave.Click += new System.EventHandler(this.ctISave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // ctIBack
            // 
            this.ctIBack.Enabled = false;
            this.ctIBack.Name = "ctIBack";
            this.ctIBack.Size = new System.Drawing.Size(203, 22);
            this.ctIBack.Text = "Trở về";
            this.ctIBack.Click += new System.EventHandler(this.ctIBack_Click);
            // 
            // ctIExit
            // 
            this.ctIExit.Name = "ctIExit";
            this.ctIExit.Size = new System.Drawing.Size(203, 22);
            this.ctIExit.Text = "Thoát";
            this.ctIExit.Click += new System.EventHandler(this.ctIExit_Click);
            // 
            // btNextAward
            // 
            this.btNextAward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btNextAward.BackColor = System.Drawing.Color.SlateBlue;
            this.btNextAward.FlatAppearance.BorderSize = 0;
            this.btNextAward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextAward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextAward.ForeColor = System.Drawing.Color.Yellow;
            this.btNextAward.Location = new System.Drawing.Point(668, 42);
            this.btNextAward.Name = "btNextAward";
            this.btNextAward.Size = new System.Drawing.Size(39, 44);
            this.btNextAward.TabIndex = 20;
            this.btNextAward.Text = ">";
            this.btNextAward.UseVisualStyleBackColor = false;
            this.btNextAward.Click += new System.EventHandler(this.btNextAward_Click);
            // 
            // btPreAward
            // 
            this.btPreAward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPreAward.BackColor = System.Drawing.Color.SlateBlue;
            this.btPreAward.FlatAppearance.BorderSize = 0;
            this.btPreAward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPreAward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPreAward.ForeColor = System.Drawing.Color.Yellow;
            this.btPreAward.Location = new System.Drawing.Point(416, 42);
            this.btPreAward.Name = "btPreAward";
            this.btPreAward.Size = new System.Drawing.Size(39, 44);
            this.btPreAward.TabIndex = 22;
            this.btPreAward.Text = "<";
            this.btPreAward.UseVisualStyleBackColor = false;
            this.btPreAward.Click += new System.EventHandler(this.btPreAward_Click);
            // 
            // pnControl
            // 
            this.pnControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnControl.BackColor = System.Drawing.Color.Transparent;
            this.pnControl.Controls.Add(this.lbLoadingDb);
            this.pnControl.Controls.Add(this.tbAwardName);
            this.pnControl.Controls.Add(this.label5);
            this.pnControl.Controls.Add(this.btEdit);
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Controls.Add(this.btBgImage);
            this.pnControl.Controls.Add(this.btRemove);
            this.pnControl.Controls.Add(this.btOpenDatabase);
            this.pnControl.Controls.Add(this.btStart);
            this.pnControl.Controls.Add(this.label3);
            this.pnControl.Controls.Add(this.btAdd);
            this.pnControl.Controls.Add(this.tbDatabase);
            this.pnControl.Controls.Add(this.cbAward);
            this.pnControl.Controls.Add(this.tbBgImage);
            this.pnControl.ForeColor = System.Drawing.Color.Black;
            this.pnControl.Location = new System.Drawing.Point(243, 623);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(797, 169);
            this.pnControl.TabIndex = 24;
            // 
            // lbLoadingDb
            // 
            this.lbLoadingDb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbLoadingDb.AutoSize = true;
            this.lbLoadingDb.BackColor = System.Drawing.Color.Transparent;
            this.lbLoadingDb.ForeColor = System.Drawing.Color.Yellow;
            this.lbLoadingDb.Location = new System.Drawing.Point(530, 139);
            this.lbLoadingDb.Name = "lbLoadingDb";
            this.lbLoadingDb.Size = new System.Drawing.Size(98, 13);
            this.lbLoadingDb.TabIndex = 20;
            this.lbLoadingDb.Text = "Đang đọc dữ liệu...";
            this.lbLoadingDb.Visible = false;
            // 
            // tbAwardName
            // 
            this.tbAwardName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAwardName.Location = new System.Drawing.Point(183, 15);
            this.tbAwardName.Name = "tbAwardName";
            this.tbAwardName.Size = new System.Drawing.Size(235, 20);
            this.tbAwardName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(183, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cơ sở dữ liệu";
            // 
            // btEdit
            // 
            this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEdit.Location = new System.Drawing.Point(462, 15);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(26, 20);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = ">";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(183, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giải";
            // 
            // btBgImage
            // 
            this.btBgImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btBgImage.Location = new System.Drawing.Point(498, 94);
            this.btBgImage.Name = "btBgImage";
            this.btBgImage.Size = new System.Drawing.Size(26, 20);
            this.btBgImage.TabIndex = 7;
            this.btBgImage.Text = "...";
            this.btBgImage.UseVisualStyleBackColor = true;
            this.btBgImage.Click += new System.EventHandler(this.btBgImage_Click);
            // 
            // btRemove
            // 
            this.btRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btRemove.Location = new System.Drawing.Point(497, 15);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(26, 20);
            this.btRemove.TabIndex = 5;
            this.btRemove.Text = "x";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btOpenDatabase
            // 
            this.btOpenDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOpenDatabase.Location = new System.Drawing.Point(498, 137);
            this.btOpenDatabase.Name = "btOpenDatabase";
            this.btOpenDatabase.Size = new System.Drawing.Size(26, 20);
            this.btOpenDatabase.TabIndex = 9;
            this.btOpenDatabase.Text = "...";
            this.btOpenDatabase.UseVisualStyleBackColor = true;
            this.btOpenDatabase.Click += new System.EventHandler(this.btOpenDatabase_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(724, 134);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(58, 23);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "Bắt đầu";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(183, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình nền";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAdd.Location = new System.Drawing.Point(427, 15);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(26, 20);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDatabase.Location = new System.Drawing.Point(183, 137);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.ReadOnly = true;
            this.tbDatabase.Size = new System.Drawing.Size(304, 20);
            this.tbDatabase.TabIndex = 8;
            // 
            // cbAward
            // 
            this.cbAward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAward.FormattingEnabled = true;
            this.cbAward.Location = new System.Drawing.Point(183, 43);
            this.cbAward.Name = "cbAward";
            this.cbAward.Size = new System.Drawing.Size(341, 21);
            this.cbAward.TabIndex = 2;
            this.cbAward.SelectedIndexChanged += new System.EventHandler(this.cbAward_SelectedIndexChanged);
            // 
            // tbBgImage
            // 
            this.tbBgImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbBgImage.Location = new System.Drawing.Point(183, 94);
            this.tbBgImage.Name = "tbBgImage";
            this.tbBgImage.ReadOnly = true;
            this.tbBgImage.Size = new System.Drawing.Size(304, 20);
            this.tbBgImage.TabIndex = 6;
            // 
            // lbPersonInfo
            // 
            this.lbPersonInfo.AutoSize = true;
            this.lbPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPersonInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lbPersonInfo.Location = new System.Drawing.Point(12, 465);
            this.lbPersonInfo.Name = "lbPersonInfo";
            this.lbPersonInfo.Size = new System.Drawing.Size(325, 101);
            this.lbPersonInfo.TabIndex = 27;
            this.lbPersonInfo.Text = "Thông tin";
            this.lbPersonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPersonInfo.UseCompatibleTextRendering = true;
            this.lbPersonInfo.Visible = false;
            this.lbPersonInfo.VisibleChanged += new System.EventHandler(this.lbPersonInfo_VisibleChanged);
            // 
            // lbPersonName
            // 
            this.lbPersonName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPersonName.AutoSize = true;
            this.lbPersonName.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPersonName.Font = new System.Drawing.Font("Segoe UI Semibold", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonName.ForeColor = System.Drawing.Color.Yellow;
            this.lbPersonName.Location = new System.Drawing.Point(392, 465);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Size = new System.Drawing.Size(422, 101);
            this.lbPersonName.TabIndex = 26;
            this.lbPersonName.Text = "Tên-Bộ Phận";
            this.lbPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPersonName.UseCompatibleTextRendering = true;
            this.lbPersonName.VisibleChanged += new System.EventHandler(this.lbPersonName_VisibleChanged);
            this.lbPersonName.Click += new System.EventHandler(this.lbPersonName_Click);
            // 
            // pbSerialNumber
            // 
            this.pbSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbSerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.pbSerialNumber.Location = new System.Drawing.Point(137, 87);
            this.pbSerialNumber.Name = "pbSerialNumber";
            this.pbSerialNumber.Size = new System.Drawing.Size(840, 304);
            this.pbSerialNumber.TabIndex = 13;
            this.pbSerialNumber.TabStop = false;
            this.pbSerialNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSerialNumber_Paint);
            // 
            // btDial
            // 
            this.btDial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDial.BackColor = System.Drawing.Color.Transparent;
            this.btDial.BackgroundImage = global::LuckyDraw.Properties.Resources.button;
            this.btDial.Enabled = false;
            this.btDial.FlatAppearance.BorderSize = 0;
            this.btDial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDial.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDial.ForeColor = System.Drawing.Color.Yellow;
            this.btDial.Location = new System.Drawing.Point(417, 403);
            this.btDial.Name = "btDial";
            this.btDial.Size = new System.Drawing.Size(288, 62);
            this.btDial.TabIndex = 10;
            this.btDial.Text = "QUAY SỐ";
            this.btDial.UseCompatibleTextRendering = true;
            this.btDial.UseVisualStyleBackColor = true;
            this.btDial.Click += new System.EventHandler(this.btDial_Click);
            // 
            // tmDisplayInfo
            // 
            this.tmDisplayInfo.Interval = 1000;
            this.tmDisplayInfo.Tick += new System.EventHandler(this.tmDisplayInfo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1117, 788);
            this.ContextMenuStrip = this.ctMainForm;
            this.Controls.Add(this.lbPersonInfo);
            this.Controls.Add(this.lbPersonName);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.btPreAward);
            this.Controls.Add(this.btNextAward);
            this.Controls.Add(this.lbCurAward);
            this.Controls.Add(this.pbSerialNumber);
            this.Controls.Add(this.btDial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LuckyDraw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctMainForm.ResumeLayout(false);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSerialNumber;
        private System.Windows.Forms.Timer tmDeltaTime;
        private System.Windows.Forms.Label lbCurAward;
        private System.Windows.Forms.ContextMenuStrip ctMainForm;
        private System.Windows.Forms.ToolStripMenuItem ctISave;
        private System.Windows.Forms.ToolStripMenuItem ctIBack;
        private System.Windows.Forms.ToolStripMenuItem ctIExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btNextAward;
        private System.Windows.Forms.Button btPreAward;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.TextBox tbAwardName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBgImage;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btOpenDatabase;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.ComboBox cbAward;
        private System.Windows.Forms.Button btDial;
        private System.Windows.Forms.TextBox tbBgImage;
        private System.Windows.Forms.ToolStripMenuItem ctIList;
        private System.Windows.Forms.Label lbPersonInfo;
        private System.Windows.Forms.Label lbPersonName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer tmDisplayInfo;
        private System.Windows.Forms.Label lbLoadingDb;

    }
}

