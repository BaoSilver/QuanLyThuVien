//using QLTV.Modelsss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.lib.modelsss;

namespace QLTV
{
    public partial class QLSach : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public QLSach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dtgvQLS.Rows[index].Cells[2].Value = iterm.Tacgia.TenTG;
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
            txtmasach.Text = "";
            txttensach.Text = "";
            cbTacgia.SelectedIndex = -1; // Chọn mục "Trống" (nếu có)
            cbTheloai.SelectedIndex = -1;
            cbNhaxb.SelectedIndex = -1;
        }

        private void themcapnhat1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmasach.Text) ||
       string.IsNullOrEmpty(txttensach.Text) ||
       string.IsNullOrEmpty(cbTheloai.Text) ||
       string.IsNullOrEmpty(cbNhaxb.Text) ||
       string.IsNullOrEmpty(cbTacgia.Text) ||
       string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string masachValue = txtmasach.Text.Trim();
            string tensachValue = txttensach.Text.Trim();
            string theloaiValue = cbTheloai.SelectedValue?.ToString();
            string nhaxbValue = cbNhaxb.SelectedValue?.ToString();
            string tentacgiaValue = cbTacgia.SelectedValue?.ToString();
            int soluongValue;
            if (!int.TryParse(txtSoluong.Text.Trim(), out soluongValue))
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int mnhaxb;
            if (!int.TryParse(nhaxbValue, out mnhaxb))
            {
                MessageBox.Show("Mã Nhà xuất bản không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }
            int masach;
            if (!int.TryParse(masachValue, out masach))
            {
                MessageBox.Show("Mã sách không hợp lệ. Vui lòng nhập số nguyên.");
                return;
            }
            if (db.Saches.Any(sach => sach.Masach == masach))
            {
                MessageBox.Show("Mã sách đã tồn tại. Vui lòng nhập một mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sach newSach = new Sach
            {
                Masach = masach,
                Tensach = tensachValue,
                Maloai = theloaiValue,
                Manhaxb = mnhaxb,
                MaTG = tentacgiaValue,
                Soluong = soluongValue,
            };
            db.Saches.Add(newSach);
            db.SaveChanges();
            List<Sach> dss = db.Saches.ToList();
            FillgridSach(dss);
            MessageBox.Show("Đã thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            if (dtgvQLS.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvQLS.SelectedRows[0];
                if (int.TryParse(selectedRow.Cells["Masach"].Value.ToString(), out int masach))
                {
                    var mas = db.Saches.SingleOrDefault(id => id.Masach == masach);
                    db.Saches.Remove(mas);
                    db.SaveChanges();
                    List<Sach> QuanLySach = db.Saches.ToList();
                    FillgridSach(QuanLySach);
                    MessageBox.Show("Đã xóa sách thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa.");
            }
        }

        private void dtgvQLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            string masachValue = txtmasach.Text.Trim();

            if (int.TryParse(masachValue, out int masach))
            {

                var existingBook = db.Saches.SingleOrDefault(book => book.Masach == masach);

                if (existingBook != null)
                {
                    string tensach = txttensach.Text.Trim();
                    string theloai = cbTheloai.SelectedValue?.ToString();
                    string nhaxb = cbNhaxb.SelectedValue?.ToString();
                    string tentacgia = cbTacgia.SelectedValue?.ToString();
                    int soluong;

                    if (!int.TryParse(txtSoluong.Text.Trim(), out soluong))
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                        return;
                    }
                    existingBook.Tensach = tensach;
                    existingBook.Maloai = theloai;
                    existingBook.Manhaxb = int.Parse(nhaxb);
                    existingBook.MaTG = tentacgia;
                    existingBook.Soluong = soluong;
                    db.SaveChanges();

                    List<Sach> dss = db.Saches.ToList();
                    FillgridSach(dss);

                    MessageBox.Show("Đã cập nhật thông tin sách thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã tương ứng để cập nhật.");
            }
        }

        private void dtgvQLS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvQLS.Rows[e.RowIndex];
                string mas = selectedRow.Cells["Masach"].Value.ToString();
                txtmasach.Text = mas;
                string tens = selectedRow.Cells["Tensach"].Value.ToString();
                txttensach.Text = tens;
                string tentg = selectedRow.Cells["Tentg"].Value.ToString();
                cbTacgia.Text = tentg;
                string thel = selectedRow.Cells["Theloai"].Value.ToString();
                cbTheloai.Text = thel;
                string nhaxb = selectedRow.Cells["NhaXB"].Value.ToString();
                cbNhaxb.Text = nhaxb;
                string sol = selectedRow.Cells["Soluong"].Value.ToString();
                txtSoluong.Text = sol;
            }
        }

        private void btnTacgia_Click(object sender, EventArgs e)
        {
            QLTacgia qLTacgia = new QLTacgia();
            qLTacgia.Show();
        }

        private void btnTheloai_Click(object sender, EventArgs e)
        {
            QLTheloai qLTheloai = new QLTheloai();
            qLTheloai.Show();
        }

        private void btnNhaxb_Click(object sender, EventArgs e)
        {
            QLNhaxb qLNhaxb = new QLNhaxb();
            qLNhaxb.Show();
        }
        private List<Sach> SearchByMaSach(int maSach)
        {
            // Truy vấn lấy sách có mã sách bằng "maSach"
            var sach = db.Saches.Where(s => s.Masach == maSach).FirstOrDefault();

            // Tạo danh sách rỗng nếu không tìm thấy sách
            if (sach == null)
            {
                return new List<Sach>();
            }

            // Tạo danh sách chứa sách tìm được
            return new List<Sach>() { sach };
        }


        private void timkiem_Click(object sender, EventArgs e)
        {
            string maHoacTen = txtSearch.Text.Trim();
            List<Sach> danhSachSach = new List<Sach>();

            if (cbSearch.SelectedItem.ToString() == "Mã sách")
            {
                int maSach;
                if (int.TryParse(maHoacTen, out maSach))
                {
                    // Lấy sách đầu tiên từ kết quả tìm kiếm
                    var sach = SearchByMaSach(maSach).FirstOrDefault();
                    danhSachSach = sach == null ? new List<Sach>() : new List<Sach>() { sach };
                }
            }
            else if (cbSearch.SelectedItem.ToString() == "Tên sách")
            {
                danhSachSach = db.Saches.Where(x => x.Tensach.Contains(maHoacTen)).ToList();
            }

            dtgvQLS.Rows.Clear();

            // Sửa đổi: Truyền danh sách sách vào FillgridSach
            FillgridSach(danhSachSach);
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}






