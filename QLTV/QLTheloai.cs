using QLTV.lib.modelsss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QLTheloai : Form
    {
        LibModelsssContextDB db =new LibModelsssContextDB();
        public QLTheloai()
        {
            InitializeComponent();
        }
        private void FillgridQLtheloai(List<Theloai> tl)
        {
            dtgTheloai.Rows.Clear();
            foreach (var iterm in tl)
            {
                int index = dtgTheloai.Rows.Add();
                dtgTheloai.Rows[index].Cells[0].Value = iterm.Maloai;
                dtgTheloai.Rows[index].Cells[1].Value = iterm.Tenloai;
            }
        }

        private void QLTheloai_Load(object sender, EventArgs e)
        {
            List<Theloai> theloai = db.Theloais.ToList();
            FillgridQLtheloai(theloai);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text.Trim();
            string ten = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã và tên thể loại.");
                return;
            }

            if (db.Theloais.Any(nhaxb => nhaxb.Maloai == ma) || db.Theloais.Any(nhaxb => nhaxb.Tenloai == ten))
            {
                MessageBox.Show("Dữ liệu đã tồn tại. Vui lòng nhập dữ liệu khác.");
                return;
            }

            Theloai tlmoi = new Theloai
            {
                Maloai = ma,
                Tenloai = ten
            };

            db.Theloais.Add(tlmoi);
            db.SaveChanges();

            List<Theloai> tl = db.Theloais.ToList();
               FillgridQLtheloai(tl);

            MessageBox.Show("Đã thêm thể loại mới thành công!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dtgTheloai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgTheloai.SelectedRows[0];
                if (selectedRow.Cells["MaTL"].Value != null && selectedRow.Cells["TenTL"].Value != null)
                {
                    string ma = selectedRow.Cells["MaTL"].Value.ToString();
                    string ten = selectedRow.Cells["TenTL"].Value.ToString();

                    var tg = db.Theloais.SingleOrDefault(n => n.Maloai == ma);

                    if (tg != null)
                    {
                        if (tg.Saches != null && tg.Saches.Any())
                        {
                            MessageBox.Show("Không thể xóa thể loại có sách. Hãy xóa sách trước khi tiếp tục.");
                        }
                        else
                        {
                            db.Theloais.Remove(tg);
                            db.SaveChanges();
                            List<Theloai> tgList = db.Theloais.ToList();
                            FillgridQLtheloai(tgList);
                            MessageBox.Show("Đã xóa thể loại thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thể loại đã chọn.");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ cho mã thể loại hoặc tên thể loại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn  thể loại để xóa.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
