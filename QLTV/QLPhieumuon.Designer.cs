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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpd = new System.Windows.Forms.Button();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1211, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // Dtngaymuon
            // 
            this.Dtngaymuon.CustomFormat = "dd/MM/yyyy";
            this.Dtngaymuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtngaymuon.Location = new System.Drawing.Point(199, 171);
            this.Dtngaymuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtngaymuon.Name = "Dtngaymuon";
            this.Dtngaymuon.Size = new System.Drawing.Size(312, 30);
            this.Dtngaymuon.TabIndex = 6;
            // 
            // DtNgaytra
            // 
            this.DtNgaytra.CustomFormat = "dd/MM/yyyy";
            this.DtNgaytra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtNgaytra.Location = new System.Drawing.Point(686, 66);
            this.DtNgaytra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtNgaytra.Name = "DtNgaytra";
            this.DtNgaytra.Size = new System.Drawing.Size(319, 30);
            this.DtNgaytra.TabIndex = 7;
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphieu.Location = new System.Drawing.Point(199, 66);
            this.txtmaphieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(312, 30);
            this.txtmaphieu.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(686, 133);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(319, 30);
            this.txtsoluong.TabIndex = 10;
            // 
            // thoat1
            // 
            this.thoat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat1.Location = new System.Drawing.Point(653, 226);
            this.thoat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thoat1.Name = "thoat1";
            this.thoat1.Size = new System.Drawing.Size(103, 33);
            this.thoat1.TabIndex = 16;
            this.thoat1.Text = "Thoát";
            this.thoat1.UseVisualStyleBackColor = true;
            // 
            // xoa1
            // 
            this.xoa1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa1.Location = new System.Drawing.Point(500, 226);
            this.xoa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(103, 33);
            this.xoa1.TabIndex = 15;
            this.xoa1.Text = "Xóa";
            this.xoa1.UseVisualStyleBackColor = true;
            // 
            // themcapnhat1
            // 
            this.themcapnhat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themcapnhat1.Location = new System.Drawing.Point(199, 226);
            this.themcapnhat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themcapnhat1.Name = "themcapnhat1";
            this.themcapnhat1.Size = new System.Drawing.Size(103, 33);
            this.themcapnhat1.TabIndex = 14;
            this.themcapnhat1.Text = "Thêm";
            this.themcapnhat1.UseVisualStyleBackColor = true;
            this.themcapnhat1.Click += new System.EventHandler(this.themcapnhat1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Masach,
            this.NgayMuon,
            this.Ngaytra,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(-11, 279);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 355);
            this.dataGridView1.TabIndex = 17;
            // 
            // Maphieu
            // 
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 8;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.ReadOnly = true;
            this.Maphieu.Width = 150;
            // 
            // Masach
            // 
            this.Masach.HeaderText = "Mã sách";
            this.Masach.MinimumWidth = 8;
            this.Masach.Name = "Masach";
            this.Masach.ReadOnly = true;
            this.Masach.Width = 150;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 8;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            this.NgayMuon.Width = 150;
            // 
            // Ngaytra
            // 
            this.Ngaytra.HeaderText = "Ngày trả";
            this.Ngaytra.MinimumWidth = 8;
            this.Ngaytra.Name = "Ngaytra";
            this.Ngaytra.ReadOnly = true;
            this.Ngaytra.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 150;
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(340, 226);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(103, 33);
            this.btnUpd.TabIndex = 18;
            this.btnUpd.Text = "Cập nhật";
            this.btnUpd.UseVisualStyleBackColor = true;
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(199, 117);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(312, 24);
            this.cbbmasach.TabIndex = 19;
            // 
            // QLPhieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 636);
            this.Controls.Add(this.cbbmasach);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.thoat1);
            this.Controls.Add(this.xoa1);
            this.Controls.Add(this.themcapnhat1);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmaphieu);
            this.Controls.Add(this.DtNgaytra);
            this.Controls.Add(this.Dtngaymuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLPhieumuon";
            this.Text = "Phieumuon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLPhieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.ComboBox cbbmasach;
    }
}