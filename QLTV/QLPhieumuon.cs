using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.lib.modelsss;

namespace QLTV
{
    public partial class QLPhieumuon : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public QLPhieumuon()
        {
            InitializeComponent();
            Dtngaymuon.Format = DateTimePickerFormat.Custom;
            Dtngaymuon.CustomFormat = "dd/MM/yyyy";
            DtNgaytra.Format = DateTimePickerFormat.Custom;
            DtNgaytra.CustomFormat = "dd/MM/yyyy";
        }

        private void themcapnhat1_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieuMuon = txtmaphieu.Text.Trim();
                string maSachString = cbbmasach.SelectedValue?.ToString(); // Lưu ý: sử dụng ?. để tránh lỗi nếu SelectedValue là null
                string maDocGiaString = cbTendg.SelectedValue?.ToString(); // Lưu ý: sử dụng ?. để tránh lỗi nếu SelectedValue là null
                int soLuongMuon;

                if (!int.TryParse(txtsoluong.Text.Trim(), out soLuongMuon) || soLuongMuon <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayMuon = DateTime.Now;
                DateTime ngayTra = ngayMuon.AddDays(14);
                DateTimePicker ngayMuonPicker = Dtngaymuon;
                DateTimePicker ngayTraPicker = DtNgaytra;

                // Gán giá trị ngày mượn và ngày trả cho DateTimePicker
                ngayMuonPicker.Value = ngayMuon;
                ngayTraPicker.Value = ngayTra;

                int maSach, maDocGia;

                // Kiểm tra và chuyển đổi chuỗi mã sách thành kiểu int
                if (!int.TryParse(maSachString, out maSach))
                {
                    MessageBox.Show("Mã sách không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra và chuyển đổi chuỗi mã độc giả thành kiểu int
                if (!int.TryParse(maDocGiaString, out maDocGia))
                {
                    MessageBox.Show("Mã độc giả không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var docGia = db.Docgias.SingleOrDefault(dg => dg.MaDG == maDocGia);
                var sach = db.Saches.SingleOrDefault(s => s.Masach == maSach);

                if (docGia == null || sach == null)
                {
                    MessageBox.Show("Không tìm thấy độc giả hoặc sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (sach.Soluong < soLuongMuon)
                {
                    MessageBox.Show("Không đủ số lượng sách trong kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Phieumuon newMuonSach = new Phieumuon
                {
                    Maphieu = int.Parse(maPhieuMuon),
                    Masach = maSach,
                    MaDG = maDocGia,
                    Soluong = soLuongMuon,
                    Ngaymuon = ngayMuon,
                    Ngaytra = ngayTra
                };

                sach.Soluong -= soLuongMuon;

                db.Phieumuons.Add(newMuonSach);
                db.SaveChanges();

                List<Phieumuon> dss = db.Phieumuons.ToList();
                fillGriddsmuon(dss);
                txtmaphieu.Text = string.Empty;
                cbbmasach.SelectedIndex = -1;
                cbTendg.SelectedIndex = -1;
                txtsoluong.Text = string.Empty;
                Dtngaymuon.Value = DateTime.Now;
                DtNgaytra.Value = DateTime.Now.AddDays(14);

                MessageBox.Show("Đã mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException ex)
            {
                // Lỗi chính là DbUpdateException, nên chúng ta kiểm tra inner exception
                Exception innerException = ex.InnerException;

                // Kiểm tra inner exception có tồn tại hay không
                if (innerException != null)
                {
                    // Hiển thị thông báo lỗi chi tiết
                    MessageBox.Show($"Lỗi: {innerException.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
                private void fillCbSach(List<Sach> dss)
        {
            this.cbbmasach.DataSource = dss;
            this.cbbmasach.DisplayMember = "TenSach";
            this.cbbmasach.ValueMember = "MaSach";
        }
        private void fillCbDG(List<Docgia> dsdg)
        {
            this.cbTendg.DataSource = dsdg;
            this.cbTendg.DisplayMember = "TenDG";
            this.cbTendg.ValueMember = "MaDG";
        }
        private void fillGriddsmuon(List<Phieumuon> dsdg)
        {
            dtgPhieumuon.Rows.Clear();
            foreach (var iterm in dsdg)
            {
                int index = dtgPhieumuon.Rows.Add();
                dtgPhieumuon.Rows[index].Cells[0].Value = iterm.Maphieu;
                dtgPhieumuon.Rows[index].Cells[1].Value = iterm.Sach.Tensach;
                dtgPhieumuon.Rows[index].Cells[2].Value = iterm.Docgia.TenDG;
                dtgPhieumuon.Rows[index].Cells[3].Value = iterm.Ngaymuon;
                dtgPhieumuon.Rows[index].Cells[4].Value = iterm.Ngaytra;
                dtgPhieumuon.Rows[index].Cells[5].Value = iterm.Soluong;
            }
        }

        private void QLPhieumuon_Load(object sender, EventArgs e)
        {
            List<Phieumuon> muon = db.Phieumuons.ToList();
            fillGriddsmuon(muon);
            List<Sach> sach = db.Saches.ToList();
            fillCbSach(sach);
            List<Docgia> dg = db.Docgias.ToList();
            fillCbDG(dg);
            Dtngaymuon.Value = DateTime.Now;
            DtNgaytra.Value = DateTime.Now.AddDays(14);
        }

        private void dtgPhieumuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgPhieumuon.Rows[e.RowIndex];
                string mapm = selectedRow.Cells["MaPhieu"].Value.ToString();
                txtmaphieu.Text = mapm;
                string tenSach = selectedRow.Cells["Tensach"].Value.ToString();
                cbbmasach.Text = tenSach;
                string theLoai = selectedRow.Cells["TenDG"].Value.ToString();
                cbTendg.Text = theLoai;
                DateTime ngayMuon;
                if (DateTime.TryParse(selectedRow.Cells["NgayMuon"].Value.ToString(), out ngayMuon))
                {
                    Dtngaymuon.Value = ngayMuon;
                }
                DateTime ngayTra;
                if (DateTime.TryParse(selectedRow.Cells["Ngaytra"].Value.ToString(), out ngayTra))
                {
                    DtNgaytra.Value = ngayTra;
                }
                int soLuong;
                if (int.TryParse(selectedRow.Cells["SoLuong"].Value.ToString(), out soLuong))
                {
                    txtsoluong.Text = soLuong.ToString();
                }
            }
        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            string maPhieuMuon = txtmaphieu.Text.Trim();

            // Sửa lỗi CS0019 ở dòng 187: Chuyển đổi kiểu int sang string
            var muonSach = db.Phieumuons.FirstOrDefault(qpm => qpm.Maphieu.ToString() == maPhieuMuon);

            if (muonSach != null)
            {
                string maSach = muonSach.Masach.ToString();
                int soLuongMuon;
                if (muonSach.Soluong.HasValue)
                {
                    soLuongMuon = muonSach.Soluong.Value;
                }
                else
                {
                    soLuongMuon = 0;
                }

                // Sửa lỗi CS0019 ở dòng 202: Chuyển đổi kiểu int sang string
                var sach = db.Saches.FirstOrDefault(s => s.Masach.ToString() == maSach);

                if (sach != null)
                {
                    sach.Soluong += soLuongMuon;
                    db.Phieumuons.Remove(muonSach);
                    db.SaveChanges();

                    List<Phieumuon> dss = db.Phieumuons.ToList();
                    fillGriddsmuon(dss);

                    MessageBox.Show("Đã xóa phiếu mượn và cập nhật lại số lượng sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách tương ứng với phiếu mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu mượn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
