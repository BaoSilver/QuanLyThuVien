using QLTV.lib.modelsss;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace QLTV
{
    public partial class QLTacgia : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public QLTacgia()
        {
            InitializeComponent();
        }
        private void FillgridQLtacgia(List<Tacgia> tg)
        {
            dtgTacgia.Rows.Clear();
            foreach (var iterm in tg)
            {
                int index = dtgTacgia.Rows.Add();
                dtgTacgia.Rows[index].Cells[0].Value = iterm.MaTG;
                dtgTacgia.Rows[index].Cells[1].Value = iterm.TenTG;  
            }
        }
       
       

        private void QLChung_Load(object sender, EventArgs e)
        {
            List<Tacgia> tacgia = db.Tacgias.ToList();
            FillgridQLtacgia(tacgia);      
        }

        private void dtgTacgia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgTacgia.Rows[e.RowIndex];
                string matg = selectedRow.Cells["MaTG"].Value.ToString();
                txtMtg.Text = matg;
                string tentg = selectedRow.Cells["TenTG"].Value.ToString();
                txtTentg.Text = tentg;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string ma = txtMtg.Text.Trim();
            string ten = txtTentg.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã và tên nhà xuất bản.");
                return;
            }

            if (db.Tacgias.Any(Ma => Ma.MaTG == ma) || db.Tacgias.Any(Ten => Ten.TenTG == ten))
            {
                MessageBox.Show("Dữ liệu đã tồn tại. Vui lòng nhập dữ liệu khác.");
                return;
            }

            Tacgia newtacgia = new Tacgia
            {
                MaTG = ma,
                TenTG = ten
            };

            db.Tacgias.Add(newtacgia);
            db.SaveChanges();

            List<Tacgia> tg = db.Tacgias.ToList();
            FillgridQLtacgia(tg);

            MessageBox.Show("Đã thêm tác giả mới thành công!");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgTacgia.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgTacgia.SelectedRows[0];
                if (selectedRow.Cells["MaTG"].Value != null && selectedRow.Cells["TenTG"].Value != null)
                {
                    string ma = selectedRow.Cells["MaTG"].Value.ToString();
                    string ten = selectedRow.Cells["TenTG"].Value.ToString();

                    var tg = db.Tacgias.SingleOrDefault(n => n.MaTG == ma);

                    if (tg != null)
                    {
                        if (tg.Saches != null && tg.Saches.Any())
                        {
                            MessageBox.Show("Không thể xóa tác giả có sách. Hãy xóa sách trước khi tiếp tục.");
                        }
                        else
                        {
                            db.Tacgias.Remove(tg);
                            db.SaveChanges();
                            List<Tacgia> tgList = db.Tacgias.ToList();
                            FillgridQLtacgia(tgList);
                            MessageBox.Show("Đã xóa tác giả thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tác giả đã chọn.");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ cho mã tác giả hoặc tên tác giả.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác giả để xóa.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

