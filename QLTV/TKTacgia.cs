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
    public partial class TKTacgia : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public TKTacgia()
        {
            InitializeComponent();
        }
        private void fillCbTG(List<Tacgia> dstg)
        {
            this.cbTtg.DataSource = dstg;
            this.cbTtg.DisplayMember = "TenTG";
            this.cbTtg.ValueMember = "MaTG";
        }


        private void TKTacgia_Load(object sender, EventArgs e)
        {
            List<Tacgia> dg = db.Tacgias.ToList();
            fillCbTG(dg);
        }

        private void cbTtg_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new LibModelsssContextDB())
            {
                var selectedTacGia = cbTtg.SelectedItem as Tacgia;
                if (selectedTacGia != null)
                {
                    var query = from sach in context.Saches
                                join tacgia in context.Tacgias on sach.MaTG equals tacgia.MaTG
                                where tacgia.MaTG == selectedTacGia.MaTG
                                group new { tacgia.MaTG, tacgia.TenTG, sach.Tensach, sach.Soluong } by new { tacgia.MaTG, tacgia.TenTG, sach.Tensach, sach.Soluong } into g
                                select new
                                {
                                   Mã_tác_giả= g.Key.MaTG,
                                    Tên_tác_giả =g.Key.TenTG,
                                    Tên_sách = g.Key.Tensach,
                                    Số_lượng = g.Key.Soluong
                                };
                    int tongSoSach = query.Sum(sach => sach.Số_lượng ?? 0);
                    txtTs.Text = tongSoSach.ToString();

                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
