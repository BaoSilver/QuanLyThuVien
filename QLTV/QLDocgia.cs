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
using QLTV.lib.model;

namespace QLTV
{

    public partial class QLDocgia : Form
    {
        LibContextModelDB db = new LibContextModelDB();
        public QLDocgia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //private void FillgridDocgia(List<Docgia> dg)
        //{
        //    dtgvQLDG.Rows.Clear();
        //    foreach (var iterm in dg)
        //    {
        //        int index = dtgvQLDG.Rows.Add();
        //        dtgvQLDG.Rows[index].Cells[0].Value = iterm.MaSV;
        //        dtgvQLDG.Rows[index].Cells[1].Value = iterm.TenDG;
        //        dtgvQLDG.Rows[index].Cells[2].Value = iterm.Ngaysinh;
        //        dtgvQLDG.Rows[index].Cells[3].Value = iterm.Gioitinh;
        //        dtgvQLDG.Rows[index].Cells[4].Value = iterm.Diachi;
        //        dtgvQLDG.Rows[index].Cells[5].Value = iterm.Sodt;

        //    }
        //}
        private void Docgia_Load(object sender, EventArgs e)
        {
           // List<Docgia> dg = db.Docgias.ToList();
            //FillgridDocgia(dg);
        }

        private void themcapnhat_Click(object sender, EventArgs e)
        {
           /* string madocgiaValue = txtmasinhvien.Text.Trim();
            string tendocgiaValue = txttenDG.Text.Trim();
            string ngaysinhValue = txtngaysinh.Text.Trim();
            string gioitinhValue = radioButton1.Checked ? "Nam" : "Nữ";
            string diachiValue = txtdiachi.Text.Trim();
            string sodtValue = txtSdt.Text.Trim();

            if (string.IsNullOrEmpty(txtmasinhvien.Text) || string.IsNullOrEmpty(txttenDG.Text) || string.IsNullOrEmpty(txtngaysinh.Text) || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin độc giả.");
                return;
            }
            int madocgia;
            if (!int.TryParse(madocgiaValue, out madocgia))
            {
                MessageBox.Show("Mã độc giả không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }
            if (!DateTime.TryParseExact(ngaysinhValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng Ngày/ Tháng/ Năm");
                return;
            }
            Docgia newDocgia = new Docgia 
            {
                MaSV = madocgia,
                TenDG = tendocgiaValue,
                Ngaysinh = ngaysinh,
                Gioitinh = gioitinhValue,
                Diachi = diachiValue.ToString(),
                Sodt = sodtValue.ToString(),
            };
            if (db.Docgias.Any(Docgia => Docgia.MaSV == madocgia))
            {
                MessageBox.Show("Mã độc giả đã tồn tại. Vui lòng nhập một mã khác.");
                return;
            }
            db.Docgias.Add(newDocgia);
            db.SaveChanges();
            List<Docgia> sachl = db.Docgias.ToList();
            FillgridDocgia(sachl);
            MessageBox.Show("Đã thêm độc giả mới thành công!");*/
        }

         private void btnUpd_Click(object sender, EventArgs e)
         {
            //string madocgiaValue = txtmasinhvien.Text.Trim();
            //string tendocgiaValue = txttenDG.Text.Trim();
            //string ngaysinhValue = txtngaysinh.Text.Trim();
            //string gioitinhValue = radioButton1.Checked ? "Nam" : "Nữ";
            //string diachiValue = txtdiachi.Text.Trim();
            //string sodtValue = txtSdt.Text.Trim();

            //if (int.TryParse(madocgiaValue, out int madocgia) && DateTime.TryParseExact(ngaysinhValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaysinh))
            //{
            //    Docgia existing = db.Docgias.SingleOrDefault(p => p.MaSV == madocgia);

            //    if (existing != null)
            //    {
            //        existing.MaSV = madocgia;
            //        existing.TenDG = tendocgiaValue;
            //        existing.Ngaysinh = ngaysinh;
            //        existing.Gioitinh = gioitinhValue;
            //        existing.Diachi = diachiValue;
            //        existing.Sodt = sodtValue;

            //        db.SaveChanges();
            //        MessageBox.Show("Đã cập nhật thông tin độc giả thành công!");

            //        List<Docgia> dg = db.Docgias.ToList();
            //        FillgridDocgia(dg);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Độc giả không tồn tại trong cơ sở dữ liệu.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập mã độc giả hợp lệ (số nguyên) và ngày sinh hợp lệ (theo định dạng dd/MM/yyyy).");
            //}
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            //if (dtgvQLDG.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dtgvQLDG.SelectedRows[0];
            //    if (int.TryParse(selectedRow.Cells["Masinhvien"].Value.ToString(), out int madocgia))
            //    {
            //        var madg = db.Docgias.SingleOrDefault(id => id.MaSV == madocgia);
            //        db.Docgias.Remove(madg);
            //        db.SaveChanges();
            //        List<Docgia> QuanLyDocGia = db.Docgias.ToList();
            //        FillgridDocgia(QuanLyDocGia);
            //        MessageBox.Show("Đã xóa độc giả thành công!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn độc giả để xóa.");
            //}
        }

        private void dtgvQLDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dtgvQLDG.Rows[e.RowIndex];
            //    string madg = selectedRow.Cells["Masinhvien"].Value.ToString();
            //    txtmasinhvien.Text = madg;
            //    string tendg = selectedRow.Cells["TenDG"].Value.ToString();
            //    txttenDG.Text = tendg;
            //    string ngaysinh = selectedRow.Cells["Ngaysinh"].Value.ToString();
            //    txtngaysinh.Text = ngaysinh;
            //    string gioitinh = selectedRow.Cells["Gioitinh"].Value.ToString();
            //    radioButton1.Text = gioitinh;
            //    string diachi = selectedRow.Cells["Diachi"].Value.ToString();
            //    txtdiachi.Text = diachi;
            //    string sodt = selectedRow.Cells["Sodt"].Value.ToString();
            //    txtSdt.Text = sodt;
            //}
        }
    }
}

