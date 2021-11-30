using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab7_LeTruongMinhNhan
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KetQua' table. You can move, or remove it, as needed.
            //this.ketQuaTableAdapter.Fill(this.qL_SinhVienDataSet.KetQua);
            //// TODO: This line of code loads data into the 'qL_SinhVienDataSet.KetQua' table. You can move, or remove it, as needed.
            //this.ketQuaTableAdapter.Fill(this.qL_SinhVienDataSet.KetQua);

        }

        private void sbtnNhapSinhVien_Click(object sender, EventArgs e)
        {
           

            
            
            foreach (Form f in this.MdiChildren)

                if (f.Name == "SinhVien")
                {
                    f.Activate();
                    return;
                }

            SinhVien sinhVien = new SinhVien();
            sinhVien.MdiParent = this;
            sinhVien.Show();
           

        }

        private void sbtnNhapKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "KHOA")
                {
                    f.Activate();
                    return;
                }

            KHOA k = new KHOA();
            k.MdiParent = this;
            k.Show();
        }

        private void sptnNhapMon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "Mon")
                {
                    f.Activate();
                    return;
                }

            Mon m = new Mon();
            m.MdiParent = this;
            m.Show();
        }

        private void sptnNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "NhapDiem")
                {
                    f.Activate();
                    return;
                }

            NhapDiem nd = new NhapDiem();
            nd.MdiParent = this;
            nd.Show();
        }

        private void sptnXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "XemDiem")
                {
                    f.Activate();
                    return;
                }

            XemDiem xd = new XemDiem();
            xd.MdiParent = this;
            xd.Show();
        }

        private void sbtnThongKe_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

                if (f.Name == "ThongKe")
                {
                    f.Activate();
                    return;
                }

            ThongKe tk = new ThongKe();
            tk.MdiParent = this;
            tk.Show();
        }

        private void sbtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
