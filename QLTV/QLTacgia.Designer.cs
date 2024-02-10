namespace QLTV
{
    partial class QLTacgia
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
            this.txtTentg = new System.Windows.Forms.TextBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgTacgia = new System.Windows.Forms.DataGridView();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMtg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTentg
            // 
            this.txtTentg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentg.Location = new System.Drawing.Point(195, 182);
            this.txtTentg.Name = "txtTentg";
            this.txtTentg.Size = new System.Drawing.Size(244, 35);
            this.txtTentg.TabIndex = 27;
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(170, 274);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(124, 42);
            this.btnUpd.TabIndex = 26;
            this.btnUpd.Text = "Cập nhật";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(38, 274);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgTacgia
            // 
            this.dtgTacgia.AllowUserToAddRows = false;
            this.dtgTacgia.AllowUserToDeleteRows = false;
            this.dtgTacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTG,
            this.TenTG});
            this.dtgTacgia.Location = new System.Drawing.Point(-1, 337);
            this.dtgTacgia.Name = "dtgTacgia";
            this.dtgTacgia.ReadOnly = true;
            this.dtgTacgia.RowHeadersWidth = 62;
            this.dtgTacgia.RowTemplate.Height = 28;
            this.dtgTacgia.Size = new System.Drawing.Size(613, 266);
            this.dtgTacgia.TabIndex = 23;
            this.dtgTacgia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTacgia_CellMouseClick);
            // 
            // MaTG
            // 
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.MinimumWidth = 8;
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            this.MaTG.Width = 150;
            // 
            // TenTG
            // 
            this.TenTG.HeaderText = "Tên tác giả";
            this.TenTG.MinimumWidth = 8;
            this.TenTG.Name = "TenTG";
            this.TenTG.ReadOnly = true;
            this.TenTG.Width = 150;
            // 
            // txtMtg
            // 
            this.txtMtg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMtg.Location = new System.Drawing.Point(195, 128);
            this.txtMtg.Name = "txtMtg";
            this.txtMtg.Size = new System.Drawing.Size(244, 35);
            this.txtMtg.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên tác giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã tác giả ";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(345, 274);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 42);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 71);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ TÁC GIẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QLTacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTentg);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgTacgia);
            this.Controls.Add(this.txtMtg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "QLTacgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTacgia";
            this.Load += new System.EventHandler(this.QLChung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTentg;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgTacgia;
        private System.Windows.Forms.TextBox txtMtg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
    }
}