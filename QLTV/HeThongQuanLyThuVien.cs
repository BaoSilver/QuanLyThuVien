﻿using System;
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
    public partial class HeThongQuanLyThuVien : Form
    {
        public HeThongQuanLyThuVien()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSach sach = new QLSach();
            sach.MdiParent = this;
            sach.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDocgia docgia = new QLDocgia();
            docgia.MdiParent = this;
            docgia.Show();
        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLPhieumuon phieumuon = new QLPhieumuon();
            phieumuon.MdiParent = this;
            phieumuon.Show();
        }

        private void thốngKêĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDocgia tk = new TKDocgia();
            tk.MdiParent = this;
            tk.Show();
        }

        private void thốngKêTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKTacgia tg = new TKTacgia();
            tg.MdiParent = this;
            tg.Show();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKSach tKSach = new TKSach();
            tKSach.MdiParent = this;
            tKSach.Show();
        }
    }
}
