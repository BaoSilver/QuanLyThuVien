﻿using QLTV.lib.modelsss;
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
    public partial class TKSach : Form
    {
        LibModelsssContextDB db = new LibModelsssContextDB();
        public TKSach()
        {
            InitializeComponent();
        }
        private void fillCbSach(List<Sach> saches)
        {
            this.cbSach.DataSource = saches;
            this.cbSach.DisplayMember = "Tensach";
            this.cbSach.ValueMember = "Masach";
        }

        private void TKSach_Load(object sender, EventArgs e)
        {
            List<Sach> s = db.Saches.ToList();
            fillCbSach(s);
        }

        private void cbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSach = cbSach.SelectedItem as Sach;
            if (selectedSach != null)
            {
                using (var context = new LibModelsssContextDB())
                {
                    var query = from sach in context.Saches
                                where sach.Masach == selectedSach.Masach
                                select new
                                {
                                    sach.Masach,
                                    sach.Tensach,
                                    sach.Soluong,
                                    SoLuongChoMuon = context.Phieumuons.Count(pm => pm.Masach == sach.Masach)
                                };

                    dataGridView1.DataSource = query.ToList();
                }
            }
        }
    }
}
