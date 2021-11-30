using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab5_LeTruongMinhNhan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lsvNhanVien.Columns[0].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[1].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[2].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[3].Width = (int)(lsvNhanVien.Width * 0.25);

            lsvNhanVien.View = View.Details;
            lsvNhanVien.GridLines = true;
            lsvNhanVien.FullRowSelect = true;
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtDienThoai.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đủ các mục");
            }
            else
            {
                ListViewItem item = lsvNhanVien.Items.Add(txtHoTen.Text);
                item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(txtDienThoai.Text);

                txtDienThoai.Text = "";
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                dtpNgaySinh.Value = DateTime.Now;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txtDiaChi.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txtDienThoai.Text;
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
