using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab7_LeTruongMinhNhan
{
    public partial class DangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
                f.Thoat += F_Thoat;
                MessageBox.Show("Đăng nhập thành công!!");
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txtTaiKhoan.Focus();
            }    
            
        }

        bool KiemTraDangNhap(string TaiKhoan,string MatKhau)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (TaiKhoan == listTaiKhoan[i].TenTaiKhoan && MatKhau == listTaiKhoan[i].MatKhau)
                {
                    return true;
                }
            }
            return false;
        }

        private void F_Thoat(object sender, EventArgs e)
        {
            (sender as Form1).isOut = false;
            (sender as Form1).Close();
            this.Show();
        }
    }
}
