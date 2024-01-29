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
    }
}
