using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.lib.modelsss;

namespace QLTV
{
    public partial class TKDocgia : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public TKDocgia()
        {
            InitializeComponent();
        }
        private Docgia selectedDocGia;

        private void fillGriddsmuon(List<Phieumuon> dsdg)
        {
            dataGridView1.Rows.Clear();
            foreach (var iterm in dsdg)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = iterm.Maphieu;
                dataGridView1.Rows[index].Cells[1].Value = iterm.Sach.Tensach;
                dataGridView1.Rows[index].Cells[2].Value = iterm.Docgia.TenDG;
                dataGridView1.Rows[index].Cells[3].Value = iterm.Ngaymuon;
                dataGridView1.Rows[index].Cells[4].Value = iterm.Ngaytra;
                dataGridView1.Rows[index].Cells[5].Value = iterm.Soluong;
            }
        }
        private void cbTdg_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDocGia = cbTdg.SelectedItem as Docgia;
            if (selectedDocGia != null)
            {
                int soluongsachmuon = db.Phieumuons.Count(p => p.MaDG == selectedDocGia.MaDG);
                txtSl.Text = soluongsachmuon.ToString();

                var phieumuonlist = db.Phieumuons.Where(p => p.MaDG == selectedDocGia.MaDG).ToList();
                fillGriddsmuon( phieumuonlist);
            }
        }

        private void fillCbDG(List<Docgia> dsdg)
        {
            this.cbTdg.DataSource = dsdg;
            this.cbTdg.DisplayMember = "TenDG";
            this.cbTdg.ValueMember = "MaDG";
        }

        private void TKDocgia_Load(object sender, EventArgs e)
        {
            List<Docgia> dg = db.Docgias.ToList();
            fillCbDG(dg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
