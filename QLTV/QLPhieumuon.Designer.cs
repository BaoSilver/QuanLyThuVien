namespace QLTV
{
    partial class QLPhieumuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtngaymuon = new System.Windows.Forms.DateTimePicker();
            this.DtNgaytra = new System.Windows.Forms.DateTimePicker();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.thoat1 = new System.Windows.Forms.Button();
            this.xoa1 = new System.Windows.Forms.Button();
            this.themcapnhat1 = new System.Windows.Forms.Button();
            this.dtgPhieumuon = new System.Windows.Forms.DataGridView();
            this.btnUpd = new System.Windows.Forms.Button();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTendg = new System.Windows.Forms.ComboBox();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1102, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(730, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(738, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // Dtngaymuon
            // 
            this.Dtngaymuon.CustomFormat = "dd/MM/yyyy";
            this.Dtngaymuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtngaymuon.Location = new System.Drawing.Point(818, 62);
            this.Dtngaymuon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Dtngaymuon.Name = "Dtngaymuon";
            this.Dtngaymuon.Size = new System.Drawing.Size(238, 26);
            this.Dtngaymuon.TabIndex = 6;
            // 
            // DtNgaytra
            // 
            this.DtNgaytra.CustomFormat = "dd/MM/yyyy";
            this.DtNgaytra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtNgaytra.Location = new System.Drawing.Point(816, 105);
            this.DtNgaytra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DtNgaytra.Name = "DtNgaytra";
            this.DtNgaytra.Size = new System.Drawing.Size(240, 26);
            this.DtNgaytra.TabIndex = 7;
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphieu.Location = new System.Drawing.Point(452, 62);
            this.txtmaphieu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(235, 26);
            this.txtmaphieu.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(818, 150);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(240, 26);
            this.txtsoluong.TabIndex = 10;
            // 
            // thoat1
            // 
            this.thoat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat1.Location = new System.Drawing.Point(793, 192);
            this.thoat1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.thoat1.Name = "thoat1";
            this.thoat1.Size = new System.Drawing.Size(77, 27);
            this.thoat1.TabIndex = 16;
            this.thoat1.Text = "Thoát";
            this.thoat1.UseVisualStyleBackColor = true;
            this.thoat1.Click += new System.EventHandler(this.thoat1_Click);
            // 
            // xoa1
            // 
            this.xoa1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa1.Location = new System.Drawing.Point(678, 192);
            this.xoa1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(77, 27);
            this.xoa1.TabIndex = 15;
            this.xoa1.Text = "Xóa";
            this.xoa1.UseVisualStyleBackColor = true;
            this.xoa1.Click += new System.EventHandler(this.xoa1_Click);
            // 
            // themcapnhat1
            // 
            this.themcapnhat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themcapnhat1.Location = new System.Drawing.Point(452, 192);
            this.themcapnhat1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.themcapnhat1.Name = "themcapnhat1";
            this.themcapnhat1.Size = new System.Drawing.Size(77, 27);
            this.themcapnhat1.TabIndex = 14;
            this.themcapnhat1.Text = "Thêm";
            this.themcapnhat1.UseVisualStyleBackColor = true;
            this.themcapnhat1.Click += new System.EventHandler(this.themcapnhat1_Click);
            // 
            // dtgPhieumuon
            // 
            this.dtgPhieumuon.AllowUserToAddRows = false;
            this.dtgPhieumuon.AllowUserToDeleteRows = false;
            this.dtgPhieumuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPhieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Tensach,
            this.TenDG,
            this.NgayMuon,
            this.Ngaytra,
            this.SoLuong});
            this.dtgPhieumuon.Location = new System.Drawing.Point(-8, 227);
            this.dtgPhieumuon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgPhieumuon.Name = "dtgPhieumuon";
            this.dtgPhieumuon.ReadOnly = true;
            this.dtgPhieumuon.RowHeadersWidth = 62;
            this.dtgPhieumuon.RowTemplate.Height = 28;
            this.dtgPhieumuon.Size = new System.Drawing.Size(1112, 365);
            this.dtgPhieumuon.TabIndex = 17;
            this.dtgPhieumuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieumuon_CellContentClick);
            this.dtgPhieumuon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPhieumuon_CellMouseClick);
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(558, 192);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(77, 27);
            this.btnUpd.TabIndex = 18;
            this.btnUpd.Text = "Cập nhật";
            this.btnUpd.UseVisualStyleBackColor = true;
            // 
            // cbbmasach
            // 
            this.cbbmasach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(452, 104);
            this.cbbmasach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(235, 27);
            this.cbbmasach.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên độc giả";
            // 
            // cbTendg
            // 
            this.cbTendg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTendg.FormattingEnabled = true;
            this.cbTendg.Location = new System.Drawing.Point(452, 147);
            this.cbTendg.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbTendg.Name = "cbTendg";
            this.cbTendg.Size = new System.Drawing.Size(235, 27);
            this.cbTendg.TabIndex = 19;
            // 
            // Maphieu
            // 
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 8;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.ReadOnly = true;
            this.Maphieu.Width = 200;
            // 
            // Tensach
            // 
            this.Tensach.HeaderText = "Tên sách ";
            this.Tensach.MinimumWidth = 8;
            this.Tensach.Name = "Tensach";
            this.Tensach.ReadOnly = true;
            this.Tensach.Width = 200;
            // 
            // TenDG
            // 
            this.TenDG.HeaderText = "Tên độc giả";
            this.TenDG.MinimumWidth = 8;
            this.TenDG.Name = "TenDG";
            this.TenDG.ReadOnly = true;
            this.TenDG.Width = 200;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 8;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            this.NgayMuon.Width = 200;
            // 
            // Ngaytra
            // 
            this.Ngaytra.HeaderText = "Ngày trả";
            this.Ngaytra.MinimumWidth = 8;
            this.Ngaytra.Name = "Ngaytra";
            this.Ngaytra.ReadOnly = true;
            this.Ngaytra.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 200;
            // 
            // QLPhieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 456);
            this.Controls.Add(this.cbTendg);
            this.Controls.Add(this.cbbmasach);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.dtgPhieumuon);
            this.Controls.Add(this.thoat1);
            this.Controls.Add(this.xoa1);
            this.Controls.Add(this.themcapnhat1);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmaphieu);
            this.Controls.Add(this.DtNgaytra);
            this.Controls.Add(this.Dtngaymuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "QLPhieumuon";
            this.Text = "Phieumuon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLPhieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtngaymuon;
        private System.Windows.Forms.DateTimePicker DtNgaytra;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button thoat1;
        private System.Windows.Forms.Button xoa1;
        private System.Windows.Forms.Button themcapnhat1;
        private System.Windows.Forms.DataGridView dtgPhieumuon;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTendg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}