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
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpd = new System.Windows.Forms.Button();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTendg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1470, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // Dtngaymuon
            // 
            this.Dtngaymuon.CustomFormat = "dd/MM/yyyy";
            this.Dtngaymuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtngaymuon.Location = new System.Drawing.Point(772, 82);
            this.Dtngaymuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtngaymuon.Name = "Dtngaymuon";
            this.Dtngaymuon.Size = new System.Drawing.Size(355, 35);
            this.Dtngaymuon.TabIndex = 6;
            // 
            // DtNgaytra
            // 
            this.DtNgaytra.CustomFormat = "dd/MM/yyyy";
            this.DtNgaytra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtNgaytra.Location = new System.Drawing.Point(769, 148);
            this.DtNgaytra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtNgaytra.Name = "DtNgaytra";
            this.DtNgaytra.Size = new System.Drawing.Size(358, 35);
            this.DtNgaytra.TabIndex = 7;
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphieu.Location = new System.Drawing.Point(224, 82);
            this.txtmaphieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(350, 35);
            this.txtmaphieu.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(772, 217);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(358, 35);
            this.txtsoluong.TabIndex = 10;
            // 
            // thoat1
            // 
            this.thoat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat1.Location = new System.Drawing.Point(735, 282);
            this.thoat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thoat1.Name = "thoat1";
            this.thoat1.Size = new System.Drawing.Size(116, 42);
            this.thoat1.TabIndex = 16;
            this.thoat1.Text = "Thoát";
            this.thoat1.UseVisualStyleBackColor = true;
            // 
            // xoa1
            // 
            this.xoa1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa1.Location = new System.Drawing.Point(562, 282);
            this.xoa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(116, 42);
            this.xoa1.TabIndex = 15;
            this.xoa1.Text = "Xóa";
            this.xoa1.UseVisualStyleBackColor = true;
            this.xoa1.Click += new System.EventHandler(this.xoa1_Click);
            // 
            // themcapnhat1
            // 
            this.themcapnhat1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themcapnhat1.Location = new System.Drawing.Point(224, 282);
            this.themcapnhat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themcapnhat1.Name = "themcapnhat1";
            this.themcapnhat1.Size = new System.Drawing.Size(116, 42);
            this.themcapnhat1.TabIndex = 14;
            this.themcapnhat1.Text = "Thêm";
            this.themcapnhat1.UseVisualStyleBackColor = true;
            this.themcapnhat1.Click += new System.EventHandler(this.themcapnhat1_Click);
            // 
            // dtgPhieumuon
            // 
            this.dtgPhieumuon.AllowUserToAddRows = false;
            this.dtgPhieumuon.AllowUserToDeleteRows = false;
            this.dtgPhieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieumuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Tensach,
            this.TenDG,
            this.NgayMuon,
            this.Ngaytra,
            this.SoLuong});
            this.dtgPhieumuon.Location = new System.Drawing.Point(-12, 349);
            this.dtgPhieumuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPhieumuon.Name = "dtgPhieumuon";
            this.dtgPhieumuon.ReadOnly = true;
            this.dtgPhieumuon.RowHeadersWidth = 62;
            this.dtgPhieumuon.RowTemplate.Height = 28;
            this.dtgPhieumuon.Size = new System.Drawing.Size(1500, 445);
            this.dtgPhieumuon.TabIndex = 17;
            this.dtgPhieumuon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPhieumuon_CellMouseClick);
            // 
            // Maphieu
            // 
            this.Maphieu.HeaderText = "Mã phiếu";
            this.Maphieu.MinimumWidth = 8;
            this.Maphieu.Name = "Maphieu";
            this.Maphieu.ReadOnly = true;
            this.Maphieu.Width = 150;
            // 
            // Tensach
            // 
            this.Tensach.HeaderText = "Tên sách ";
            this.Tensach.MinimumWidth = 8;
            this.Tensach.Name = "Tensach";
            this.Tensach.ReadOnly = true;
            this.Tensach.Width = 150;
            // 
            // TenDG
            // 
            this.TenDG.HeaderText = "Tên độc giả";
            this.TenDG.MinimumWidth = 8;
            this.TenDG.Name = "TenDG";
            this.TenDG.ReadOnly = true;
            this.TenDG.Width = 150;
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
            this.btnUpd.Location = new System.Drawing.Point(382, 282);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(116, 42);
            this.btnUpd.TabIndex = 18;
            this.btnUpd.Text = "Cập nhật";
            this.btnUpd.UseVisualStyleBackColor = true;
            // 
            // cbbmasach
            // 
            this.cbbmasach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(224, 146);
            this.cbbmasach.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(350, 35);
            this.cbbmasach.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên độc giả";
            // 
            // cbTendg
            // 
            this.cbTendg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTendg.FormattingEnabled = true;
            this.cbTendg.Location = new System.Drawing.Point(224, 212);
            this.cbTendg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbTendg.Name = "cbTendg";
            this.cbTendg.Size = new System.Drawing.Size(350, 35);
            this.cbTendg.TabIndex = 19;
            // 
            // QLPhieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 906);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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