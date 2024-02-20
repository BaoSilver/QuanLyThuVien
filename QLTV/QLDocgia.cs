using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.lib.modelsss;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLTV
{

    public partial class QLDocgia : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public QLDocgia()
        {
            InitializeComponent();
            dtNgaysinh.Format = DateTimePickerFormat.Custom;
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void fillgriddocgia(List<Docgia> dg)
        {
            dtgvQLDG.Rows.Clear();
            foreach (var iterm in dg)
            {
                int index = dtgvQLDG.Rows.Add();
                dtgvQLDG.Rows[index].Cells[0].Value = iterm.MaDG;
                dtgvQLDG.Rows[index].Cells[1].Value = iterm.TenDG;
                dtgvQLDG.Rows[index].Cells[2].Value = iterm.Ngaysinh;
                dtgvQLDG.Rows[index].Cells[3].Value = iterm.Gioitinh;
                dtgvQLDG.Rows[index].Cells[4].Value = iterm.Diachi;
                dtgvQLDG.Rows[index].Cells[5].Value = iterm.Sodt;
            }
        }
        private void Docgia_Load(object sender, EventArgs e)
        {
            List<Docgia> dg = db.Docgias.ToList();
            fillgriddocgia(dg);
        }

        private void themcapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasinhvien.Text) ||
       string.IsNullOrEmpty(txttenDG.Text) ||
       string.IsNullOrEmpty(dtNgaysinh.Text) ||
      string.IsNullOrEmpty(txtdiachi.Text) ||
       string.IsNullOrEmpty(txtSdt.Text) || txtSdt.Text.Length !=10 || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string madgValue = txtmasinhvien.Text.Trim();
            string tendgValue = txttenDG.Text.Trim();
            string gioitinhValue = radioButton1.Checked ? "Nam" : "Nữ";
            string diachiValue = txtdiachi.Text.Trim();
            string sodtValue = txtSdt.Text.Trim();       
            string Ngaysinhstring = dtNgaysinh.Value.ToString("dd-MM-YYYY");
            DateTime? Ngaysinh = dtNgaysinh.Value ;
           
            int madocgia;
            if (!int.TryParse(madgValue, out madocgia))
            {
                MessageBox.Show("Mã sách không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }
            if (db.Docgias.Any(dg => dg.MaDG == madocgia))
            {
                MessageBox.Show("Mã độc giả đã tồn tại. Vui lòng nhập một mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Docgia newDocGia = new Docgia
            {
                MaDG = madocgia,
                TenDG = tendgValue,
                Gioitinh = gioitinhValue,
                Ngaysinh = Ngaysinh,
                Diachi=diachiValue,
                Sodt = int.Parse(sodtValue),
            };

            db.Docgias.Add(newDocGia);
            db.SaveChanges();

            List<Docgia> dsDocGia = db.Docgias.ToList();
            fillgriddocgia(dsDocGia);

            MessageBox.Show("Đã thêm độc giả mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            private void btnUpd_Click(object sender, EventArgs e)
         {      
            string madgValue = txtmasinhvien.Text.Trim();
            string tendgValue = txttenDG.Text.Trim();
            string gioitinhValue = radioButton1.Checked ? "Nam" : "Nữ";
            string diachiValue = txtdiachi.Text.Trim();
            string sodtValue = txtSdt.Text.Trim();
            string Ngaysinhstring = dtNgaysinh.Value.ToString("dd-MM-yyyy"); // Corrected date format
            DateTime? Ngaysinh = dtNgaysinh.Value;

            int madocgia;
            if (!int.TryParse(madgValue, out madocgia))
            {
                MessageBox.Show("Mã sách không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }

           
            Docgia existingDocGia = db.Docgias.FirstOrDefault(dg => dg.MaDG == madocgia);

            if (existingDocGia == null)
            {
                MessageBox.Show("Không tìm thấy độc giả với mã đã nhập. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            existingDocGia.TenDG = tendgValue;
            existingDocGia.Gioitinh = gioitinhValue;
            existingDocGia.Ngaysinh = Ngaysinh;
            existingDocGia.Diachi = diachiValue;
            existingDocGia.Sodt = int.Parse(sodtValue);

            
            db.SaveChanges();

            List<Docgia> dsDocGia = db.Docgias.ToList();
            fillgriddocgia(dsDocGia);

            MessageBox.Show("Đã cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (dtgvQLDG.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvQLDG.SelectedRows[0];
                if (int.TryParse(selectedRow.Cells["Masinhvien"].Value.ToString(), out int madocgia))
                {
                    var madg = db.Docgias.SingleOrDefault(id => id.MaDG == madocgia);
                    db.Docgias.Remove(madg);
                    db.SaveChanges();
                    List<Docgia> QuanLyDocGia = db.Docgias.ToList();
                    fillgriddocgia(QuanLyDocGia);
                    MessageBox.Show("Đã xóa độc giả thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả để xóa.");
            }
        }

        private void dtgvQLDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgQLDG_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = dtgvQLDG.Rows[e.RowIndex];
                string madg = selectedrow.Cells["Masinhvien"].Value.ToString();
                txtmasinhvien.Text = madg;
                string tendg = selectedrow.Cells["TenDG"].Value.ToString();
                txttenDG.Text = tendg;
                string ngaysinh = selectedrow.Cells["Ngaysinh"].Value.ToString();
                dtNgaysinh.Text = ngaysinh;
                string gioitinh = selectedrow.Cells["Gioitinh"].Value.ToString();
                radioButton1.Checked = gioitinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);
                radioButton2.Checked = gioitinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase);
                string diachi = selectedrow.Cells["Diachi"].Value.ToString();
                txtdiachi.Text = diachi;
                string sodt = selectedrow.Cells["Sodt"].Value.ToString();
                txtSdt.Text = sodt;
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form 2
        }
    }
}

