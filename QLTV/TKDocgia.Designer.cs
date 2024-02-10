namespace QLTV
{
    partial class TKDocgia
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTdg = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tên độc giả";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1470, 71);
            this.label1.TabIndex = 32;
            this.label1.Text = "THỐNG KÊ ĐỘC GIẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSl
            // 
            this.txtSl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSl.Location = new System.Drawing.Point(626, 266);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(244, 35);
            this.txtSl.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tổng số lượng mượn ";
            // 
            // cbTdg
            // 
            this.cbTdg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTdg.FormattingEnabled = true;
            this.cbTdg.Location = new System.Drawing.Point(626, 200);
            this.cbTdg.Name = "cbTdg";
            this.cbTdg.Size = new System.Drawing.Size(244, 35);
            this.cbTdg.TabIndex = 34;
            this.cbTdg.SelectedIndexChanged += new System.EventHandler(this.cbTdg_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieu,
            this.Tensach,
            this.TenDG,
            this.NgayMuon,
            this.Ngaytra,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(9, 398);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1537, 274);
            this.dataGridView1.TabIndex = 35;
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
            // TKDocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 671);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTdg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "TKDocgia";
            this.Text = "TKDocgia";
            this.Load += new System.EventHandler(this.TKDocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTdg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}