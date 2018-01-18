namespace LuckyDraw
{
    partial class ListAwardsFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwardClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClm,
            this.NameClm,
            this.InfoClm,
            this.AwardClm});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // IdClm
            // 
            this.IdClm.HeaderText = "ID";
            this.IdClm.Name = "IdClm";
            this.IdClm.ReadOnly = true;
            // 
            // NameClm
            // 
            this.NameClm.HeaderText = "Tên";
            this.NameClm.Name = "NameClm";
            this.NameClm.ReadOnly = true;
            // 
            // InfoClm
            // 
            this.InfoClm.HeaderText = "Thông tin";
            this.InfoClm.Name = "InfoClm";
            this.InfoClm.ReadOnly = true;
            // 
            // AwardClm
            // 
            this.AwardClm.HeaderText = "Giải Thưởng";
            this.AwardClm.Name = "AwardClm";
            this.AwardClm.ReadOnly = true;
            // 
            // ListAwardsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 376);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListAwardsFrm";
            this.Text = "ListAwardsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardClm;
    }
}