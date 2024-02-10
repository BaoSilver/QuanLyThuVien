namespace QLTV
{
    partial class QLDocgia
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
            this.themcapnhat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgvQLDG = new System.Windows.Forms.DataGridView();
            this.Masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.txttenDG = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnUpd = new System.Windows.Forms.Button();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1474, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(778, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(778, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // themcapnhat
            // 
            this.themcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themcapnhat.Location = new System.Drawing.Point(442, 295);
            this.themcapnhat.Name = "themcapnhat";
            this.themcapnhat.Size = new System.Drawing.Size(116, 42);
            this.themcapnhat.TabIndex = 6;
            this.themcapnhat.Text = "Thêm";
            this.themcapnhat.UseVisualStyleBackColor = true;
            this.themcapnhat.Click += new System.EventHandler(this.themcapnhat_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(784, 295);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(116, 42);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(986, 295);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(116, 42);
            this.thoat.TabIndex = 8;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // dtgvQLDG
            // 
            this.dtgvQLDG.AllowUserToAddRows = false;
            this.dtgvQLDG.AllowUserToDeleteRows = false;
            this.dtgvQLDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masinhvien,
            this.TenDG,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi,
            this.Sodt});
            this.dtgvQLDG.Location = new System.Drawing.Point(-2, 369);
            this.dtgvQLDG.Name = "dtgvQLDG";
            this.dtgvQLDG.ReadOnly = true;
            this.dtgvQLDG.RowHeadersWidth = 62;
            this.dtgvQLDG.RowTemplate.Height = 28;
            this.dtgvQLDG.Size = new System.Drawing.Size(1476, 536);
            this.dtgvQLDG.TabIndex = 9;
            this.dtgvQLDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLDG_CellContentClick);
            this.dtgvQLDG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgQLDG_MouseClick);
            // 
            // Masinhvien
            // 
            this.Masinhvien.HeaderText = "Mã độc giả ";
            this.Masinhvien.MinimumWidth = 8;
            this.Masinhvien.Name = "Masinhvien";
            this.Masinhvien.ReadOnly = true;
            this.Masinhvien.Width = 150;
            // 
            // TenDG
            // 
            this.TenDG.HeaderText = "Tên độc giả";
            this.TenDG.MinimumWidth = 8;
            this.TenDG.Name = "TenDG";
            this.TenDG.ReadOnly = true;
            this.TenDG.Width = 150;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 8;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Width = 150;
            // 
            // Gioitinh
            // 
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 8;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.ReadOnly = true;
            this.Gioitinh.Width = 150;
            // 
            // Diachi
            // 
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 8;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 150;
            // 
            // Sodt
            // 
            this.Sodt.HeaderText = "Số điện thoại ";
            this.Sodt.MinimumWidth = 8;
            this.Sodt.Name = "Sodt";
            this.Sodt.ReadOnly = true;
            this.Sodt.Width = 150;
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasinhvien.Location = new System.Drawing.Point(476, 97);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(278, 35);
            this.txtmasinhvien.TabIndex = 10;
            // 
            // txttenDG
            // 
            this.txttenDG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenDG.Location = new System.Drawing.Point(476, 175);
            this.txttenDG.Name = "txttenDG";
            this.txttenDG.Size = new System.Drawing.Size(278, 35);
            this.txttenDG.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(936, 155);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(268, 35);
            this.txtdiachi.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(936, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 31);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1052, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 31);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(612, 295);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(116, 42);
            this.btnUpd.TabIndex = 17;
            this.btnUpd.Text = "Cập nhật";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaysinh.Location = new System.Drawing.Point(476, 245);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(278, 35);
            this.dtNgaysinh.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(778, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(936, 232);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(268, 35);
            this.txtSdt.TabIndex = 14;
            // 
            // QLDocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1470, 906);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenDG);
            this.Controls.Add(this.txtmasinhvien);
            this.Controls.Add(this.dtgvQLDG);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.themcapnhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLDocgia";
            this.Text = "Docgia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Docgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLDG)).EndInit();
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
        private System.Windows.Forms.Button themcapnhat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgvQLDG;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.TextBox txttenDG;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodt;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSdt;
    }
}