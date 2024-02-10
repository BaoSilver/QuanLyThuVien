namespace QLTV
{
    partial class QLTheloai
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgTheloai = new System.Windows.Forms.DataGridView();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(359, 269);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(182, 269);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgTheloai
            // 
            this.dtgTheloai.AllowUserToAddRows = false;
            this.dtgTheloai.AllowUserToDeleteRows = false;
            this.dtgTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTL,
            this.TenTL});
            this.dtgTheloai.Location = new System.Drawing.Point(-6, 371);
            this.dtgTheloai.Name = "dtgTheloai";
            this.dtgTheloai.ReadOnly = true;
            this.dtgTheloai.RowHeadersWidth = 62;
            this.dtgTheloai.RowTemplate.Height = 28;
            this.dtgTheloai.Size = new System.Drawing.Size(651, 366);
            this.dtgTheloai.TabIndex = 23;
            // 
            // MaTL
            // 
            this.MaTL.HeaderText = "Mã thể loại ";
            this.MaTL.MinimumWidth = 8;
            this.MaTL.Name = "MaTL";
            this.MaTL.ReadOnly = true;
            this.MaTL.Width = 150;
            // 
            // TenTL
            // 
            this.TenTL.HeaderText = "Tên thể loại ";
            this.TenTL.MinimumWidth = 8;
            this.TenTL.Name = "TenTL";
            this.TenTL.ReadOnly = true;
            this.TenTL.Width = 150;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(282, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 35);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(282, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 35);
            this.textBox1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tên thể loại ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã thể loại ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 71);
            this.label1.TabIndex = 27;
            this.label1.Text = "QUẢN LÝ THỂ LOẠI ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QLTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtgTheloai);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLTheloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLTheloai";
            this.Load += new System.EventHandler(this.QLTheloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgTheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}