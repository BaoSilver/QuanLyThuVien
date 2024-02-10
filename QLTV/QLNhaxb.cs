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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTV
{
    public partial class QLNhaxb : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public QLNhaxb()
        {
            InitializeComponent();
        }
        private void FillgridQLnxb(List<NhaXB> nxb)
        {
            dtgNhaXB.Rows.Clear();
            foreach (var iterm in nxb)
            {
                int index = dtgNhaXB.Rows.Add();
                dtgNhaXB.Rows[index].Cells[0].Value = iterm.Manhaxb;
                dtgNhaXB.Rows[index].Cells[1].Value = iterm.TenNhaxb;
            }
        }
        private void QLNhaxb_Load(object sender, EventArgs e)
        {
            List<NhaXB> nhaXB = db.NhaXBs.ToList();
            FillgridQLnxb(nhaXB);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ma = textBox3.Text.Trim();
            string ten = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã và tên nhà xuất bản.");
                return;
            }

            if (db.NhaXBs.Any(nhaxb => nhaxb.Manhaxb == int.Parse(ma)) || db.NhaXBs.Any(nhaxb => nhaxb.TenNhaxb == ten))
            {
                MessageBox.Show("Dữ liệu đã tồn tại. Vui lòng nhập dữ liệu khác.");
                return;
            }

            NhaXB nhaxbmoi = new NhaXB
            {
                Manhaxb = int.Parse(ma),
                TenNhaxb = ten
            };

            db.NhaXBs.Add(nhaxbmoi);
            db.SaveChanges();

            List<NhaXB> tl = db.NhaXBs.ToList();
            FillgridQLnxb(tl);

            MessageBox.Show("Đã thêm nhà xuất bản mới thành công!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dtgNhaXB.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgNhaXB.SelectedRows[0];
                if (selectedRow.Cells["MaNXB"].Value != null && selectedRow.Cells["TenNXB"].Value != null)
                {
                    string ma = selectedRow.Cells["MaNXB"].Value.ToString();
                    string ten = selectedRow.Cells["TenNXB"].Value.ToString();

                    int maInt;
                    if (!int.TryParse(ma, out maInt))
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ cho mã nhà xuất bản.");
                        return;
                    }

                    var nxb = db.NhaXBs.SingleOrDefault(n => n.Manhaxb == maInt);

                    if (nxb != null)
                    {
                        if (nxb.Saches != null && nxb.Saches.Any())
                        {
                            MessageBox.Show("Không thể xóa  nhà xuất bản có sách. Hãy xóa sách trước khi tiếp tục.");
                        }
                        else
                        {
                            db.NhaXBs.Remove(nxb);
                            db.SaveChanges();
                            List<NhaXB> tgList = db.NhaXBs.ToList();
                            FillgridQLnxb(tgList);
                            MessageBox.Show("Đã xóa nhà xuất bản thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà xuất bản đã chọn.");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ cho mã nhà xuất bản hoặc tên nhà xuất bản.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản để xóa.");
            }
        }
    }
}
