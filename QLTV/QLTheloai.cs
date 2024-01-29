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
    }
}
