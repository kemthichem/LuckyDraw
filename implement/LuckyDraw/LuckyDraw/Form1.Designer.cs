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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAwardName = new System.Windows.Forms.TextBox();
            this.tbAwardCount = new System.Windows.Forms.TextBox();
            this.tbBgImage = new System.Windows.Forms.TextBox();
            this.cbAward = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btBgImage = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btOpenDatabase = new System.Windows.Forms.Button();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ctMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctISave = new System.Windows.Forms.ToolStripMenuItem();
            this.ctIBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ctIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ctMainForm.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giải";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(328, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số giải";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(87, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình nền";
            // 
            // tbAwardName
            // 
            this.tbAwardName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAwardName.Location = new System.Drawing.Point(87, 34);
            this.tbAwardName.Name = "tbAwardName";
            this.tbAwardName.Size = new System.Drawing.Size(235, 20);
            this.tbAwardName.TabIndex = 0;
            // 
            // tbAwardCount
            // 
            this.tbAwardCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAwardCount.Location = new System.Drawing.Point(328, 34);
            this.tbAwardCount.Name = "tbAwardCount";
            this.tbAwardCount.Size = new System.Drawing.Size(100, 20);
            this.tbAwardCount.TabIndex = 1;
            // 
            // tbBgImage
            // 
            this.tbBgImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbBgImage.Location = new System.Drawing.Point(87, 113);
            this.tbBgImage.Name = "tbBgImage";
            this.tbBgImage.Size = new System.Drawing.Size(304, 20);
            this.tbBgImage.TabIndex = 6;
            // 
            // cbAward
            // 
            this.cbAward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAward.FormattingEnabled = true;
            this.cbAward.Location = new System.Drawing.Point(87, 62);
            this.cbAward.Name = "cbAward";
            this.cbAward.Size = new System.Drawing.Size(235, 21);
            this.cbAward.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAdd.Location = new System.Drawing.Point(328, 60);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(26, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btRemove.Location = new System.Drawing.Point(402, 60);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(26, 23);
            this.btRemove.TabIndex = 5;
            this.btRemove.Text = "x";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEdit.Location = new System.Drawing.Point(365, 60);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(26, 23);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = ">";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btBgImage
            // 
            this.btBgImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btBgImage.Location = new System.Drawing.Point(402, 110);
            this.btBgImage.Name = "btBgImage";
            this.btBgImage.Size = new System.Drawing.Size(26, 23);
            this.btBgImage.TabIndex = 7;
            this.btBgImage.Text = "...";
            this.btBgImage.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(721, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Bắt đầu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(177, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 304);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(636, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(532, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giai 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOpenDatabase
            // 
            this.btOpenDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOpenDatabase.Location = new System.Drawing.Point(402, 153);
            this.btOpenDatabase.Name = "btOpenDatabase";
            this.btOpenDatabase.Size = new System.Drawing.Size(26, 23);
            this.btOpenDatabase.TabIndex = 9;
            this.btOpenDatabase.Text = "...";
            this.btOpenDatabase.UseVisualStyleBackColor = true;
            this.btOpenDatabase.Click += new System.EventHandler(this.btOpenDatabase_Click);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDatabase.Location = new System.Drawing.Point(87, 156);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(304, 20);
            this.tbDatabase.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ctMainForm
            // 
            this.ctMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctISave,
            this.toolStripSeparator1,
            this.ctIBack,
            this.ctIExit});
            this.ctMainForm.Name = "ctMainForm";
            this.ctMainForm.Size = new System.Drawing.Size(118, 76);
            // 
            // ctISave
            // 
            this.ctISave.Name = "ctISave";
            this.ctISave.Size = new System.Drawing.Size(117, 22);
            this.ctISave.Text = "Lưu";
            // 
            // ctIBack
            // 
            this.ctIBack.Name = "ctIBack";
            this.ctIBack.Size = new System.Drawing.Size(117, 22);
            this.ctIBack.Text = "Quay lại";
            // 
            // ctIExit
            // 
            this.ctIExit.Name = "ctIExit";
            this.ctIExit.Size = new System.Drawing.Size(117, 22);
            this.ctIExit.Text = "Thoát";
            this.ctIExit.Click += new System.EventHandler(this.ctIExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(87, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cơ sở dữ liệu";
            // 
            // gbControl
            // 
            this.gbControl.BackColor = System.Drawing.Color.Transparent;
            this.gbControl.Controls.Add(this.tbAwardName);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.btOpenDatabase);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.tbDatabase);
            this.gbControl.Controls.Add(this.tbAwardCount);
            this.gbControl.Controls.Add(this.tbBgImage);
            this.gbControl.Controls.Add(this.button1);
            this.gbControl.Controls.Add(this.cbAward);
            this.gbControl.Controls.Add(this.btAdd);
            this.gbControl.Controls.Add(this.button6);
            this.gbControl.Controls.Add(this.btRemove);
            this.gbControl.Controls.Add(this.btBgImage);
            this.gbControl.Controls.Add(this.btEdit);
            this.gbControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbControl.Location = new System.Drawing.Point(177, 579);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(840, 197);
            this.gbControl.TabIndex = 21;
            this.gbControl.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(657, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(503, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 788);
            this.ContextMenuStrip = this.ctMainForm;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "LuckyDraw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ctMainForm.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAwardName;
        private System.Windows.Forms.TextBox tbAwardCount;
        private System.Windows.Forms.TextBox tbBgImage;
        private System.Windows.Forms.ComboBox cbAward;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btBgImage;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOpenDatabase;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip ctMainForm;
        private System.Windows.Forms.ToolStripMenuItem ctISave;
        private System.Windows.Forms.ToolStripMenuItem ctIBack;
        private System.Windows.Forms.ToolStripMenuItem ctIExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}

