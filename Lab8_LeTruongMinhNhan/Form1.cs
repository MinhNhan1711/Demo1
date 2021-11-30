using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab8_LeTruongMinhNhan
{
    public partial class Form1 : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();
        public Form1()
        {
            InitializeComponent();
        }

        void HienthiNhanvien()
        {
            lsvNhanVien.Items.Clear();
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =

                lsvNhanVien.Items.Add(dt.Rows[i][0].ToString());

                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void setNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void HienthiBangcap()
        {
            DataTable dt = nv.LayBangcap();
            cboBangCap.DataSource = dt;
            cboBangCap.DisplayMember = "TenBangcap";
            cboBangCap.ValueMember = "MaBangcap";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienthiNhanvien();
            HienthiBangcap();

        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtpNgaySinh.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                cboBangCap.SelectedIndex = cboBangCap.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txtHoTen.Focus();

        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(

                    lsvNhanVien.SelectedItems[0].SubItems[0].Text);

                    lsvNhanVien.Items.RemoveAt(

                    lsvNhanVien.SelectedIndices[0]);

                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver

            if (themmoi)
            {
                nv.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text,
                txtDienThoai.Text, cboBangCap.SelectedValue.ToString());

                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(

                lsvNhanVien.SelectedItems[0].SubItems[0].Text,
                txtHoTen.Text, ngay, txtDiaChi.Text, txtDienThoai.Text,
                cboBangCap.SelectedValue.ToString());

                MessageBox.Show("Cập nhật thành công");
            }
            HienthiNhanvien();
            setNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
