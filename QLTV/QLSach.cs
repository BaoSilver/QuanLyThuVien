//using QLTV.Modelsss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.lib.model;

namespace QLTV
{
    public partial class QLSach : Form
    {
        LibContextModelDB db = new LibContextModelDB();
        public QLSach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillgridSach(List<Sach> dg)
        {
            dtgvQLS.Rows.Clear();
            foreach (var iterm in dg)
            {
                int index = dtgvQLS.Rows.Add();
                dtgvQLS.Rows[index].Cells[0].Value = iterm.Masach;
                dtgvQLS.Rows[index].Cells[1].Value = iterm.Tensach;
                dtgvQLS.Rows[index].Cells[2].Value = iterm.Tacgia.MaTG;
                dtgvQLS.Rows[index].Cells[3].Value = iterm.Theloai.Tenloai;
                dtgvQLS.Rows[index].Cells[4].Value = iterm.NhaXB.TenNhaxb;
                dtgvQLS.Rows[index].Cells[5].Value = iterm.Soluong;
            }
        }
        private void fillCbTheloai(List<Theloai> tl)
        {
            this.cbTheloai.DataSource = tl;
            this.cbTheloai.DisplayMember = "TenLoai";
            this.cbTheloai.ValueMember = "MaLoai";
        }
        private void fillCbTacgia(List<Tacgia> tg) 
        {
            this.cbTacgia.DataSource = tg;
            this.cbTacgia.DisplayMember = "TenTG";
            this.cbTacgia.ValueMember = "MaTG";
        }
        private void fillCbNhaxb(List<NhaXB> xb)
        {
            this.cbNhaxb.DataSource = xb;
            this.cbNhaxb.DisplayMember = "TenNhaxb";
            this.cbNhaxb.ValueMember = "MaNhaxb";
        }

        private void QLSach_Load(object sender, EventArgs e)
        {
            List<Sach> sach = db.Saches.ToList();
            FillgridSach(sach);
            List<Theloai> theloais = db.Theloais.ToList();
            fillCbTheloai(theloais);
            List<NhaXB> nhaxb = db.NhaXBs.ToList();
            fillCbNhaxb(nhaxb);
            List<Tacgia> tacgia = db.Tacgias.ToList();
            fillCbTacgia(tacgia);
        }

        private void themcapnhat1_Click(object sender, EventArgs e)
        {
            string masachValue = txtmasach.Text.Trim();
            string tensachValue = txttensach.Text.Trim();
            string tentgValue = cbTacgia.Text.Trim();
            string theloaiValue = cbTheloai.Text.Trim();
            string nhaxbValue = cbNhaxb.Text.Trim();
            int soluongValue = int.Parse(txtSoluong.Text.Trim());

            // Kiểm tra xem người dùng đã nhập đầy đủ thông tin sách chưa.
            if (string.IsNullOrEmpty(masachValue) || string.IsNullOrEmpty(tensachValue) || string.IsNullOrEmpty(theloaiValue) || string.IsNullOrEmpty(nhaxbValue) || string.IsNullOrEmpty(tentgValue))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.");
                return;
            }

            // Kiểm tra xem mã sách là số nguyên và không trùng lặp.
            int masach;
            if (!int.TryParse(masachValue, out masach))
            {
                MessageBox.Show("Mã sách không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }
            if (db.Saches.Any(sach => sach.Masach == masach))
            {
                MessageBox.Show("Mã sách đã tồn tại. Vui lòng nhập một mã khác.");
                return;
            }

            // Thêm sách mới vào cơ sở dữ liệu.
            Sach newSach = new Sach
            {
                Masach = masach,
                Tensach = tensachValue,
                MaTG = tentgValue,
                Maloai = theloaiValue,
                Manhaxb = int.Parse(nhaxbValue),
                Soluong = soluongValue,
            };
            db.Saches.Add(newSach);
            db.SaveChanges();

            // Cập nhật danh sách sách trên DataGridView.
            List<Sach> sachl = db.Saches.ToList();
            FillgridSach(sachl);

            // Hiển thị thông báo thành công.
            MessageBox.Show("Đã thêm sách mới thành công!");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            //if (dtgvQLS.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dtgvQLS.SelectedRows[0];
            //    if (int.TryParse(selectedRow.Cells["Masach"].Value.ToString(), out int masach))
            //    {
            //        var mas = db.Saches.SingleOrDefault(id => id.Masach == masach);
            //        db.Saches.Remove(mas);
            //        db.SaveChanges();
            //        List<Sach> QuanLySach = db.Saches.ToList();
            //        FillgridSach(QuanLySach);
            //        MessageBox.Show("Đã xóa sách thành công!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn sách để xóa.");
            //}
        }

        private void dtgvQLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dtgvQLS.Rows[e.RowIndex];
            //    string mas = selectedRow.Cells["Masach"].Value.ToString();
            //    txtmasach.Text = mas;
            //    string tens = selectedRow.Cells["Tensach"].Value.ToString();
            //    txttensach.Text = tens;
            //    string tentg = selectedRow.Cells["Tentg"].Value.ToString();
            //    txttentg.Text = tentg;
            //    string thel = selectedRow.Cells["Theloai"].Value.ToString();
            //    cbTheloai.Text = thel;
            //    string nhaxb = selectedRow.Cells["NhaXB"].Value.ToString();
            //    txtNhaxb.Text = nhaxb;
            //    string sol = selectedRow.Cells["Soluong"].Value.ToString();
            //    txtSoluong.Text = sol;
            //}
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            //string masachValue = txtmasach.Text.Trim();
            //string tensachValue = txttensach.Text.Trim();
            //string theloaiValue = cbTheloai.Text.Trim();
            //string nhaxbValue = txtNhaxb.Text.Trim();
            //string tentacgiaValue = txttentg.Text.Trim();
            //int soluongValue = int.Parse(txtSoluong.Text.Trim());
            //if (int.TryParse(txtSoluong.Text.Trim(), out soluongValue)) 
            //{
            //    if (int.TryParse(masachValue, out int masach))
            //    {
            //        Sach existing = db.Saches.SingleOrDefault(p => p.Masach == masach);
            //        if (existing != null)
            //        {
            //            existing.Masach = masach; 
            //            existing.Tensach = tensachValue;
            //            existing.Theloai = theloaiValue;
            //            existing.NhaXB = nhaxbValue;
            //            existing.TenTG = tentacgiaValue;
            //            existing.Soluong = soluongValue;
            //            db.SaveChanges();
            //            MessageBox.Show("Đã cập nhật thông tin sách thành công!");
            //            List<Sach> dm = db.Saches.ToList();
            //            FillgridSach(dm);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Sách không tồn tại trong cơ sở dữ liệu.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng nhập Mã sách hợp lệ (số nguyên).");
            //    }
            //}
        }
    }
}

