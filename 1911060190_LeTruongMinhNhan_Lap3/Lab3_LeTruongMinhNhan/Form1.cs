using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_LeTruongMinhNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");

            }
            else
            {
                int n = int.Parse(txtSon.Text);
                int m = int.Parse(txtSom.Text);
                int Tong = n + m;
                txtKetqua.Text = Tong.ToString();
            }    
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");

            }
            else
            {
                int n = int.Parse(txtSon.Text);
                int m = int.Parse(txtSom.Text);
                int Hieu = n - m;
                txtKetqua.Text = Hieu.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");

            }
            else
            {
                int n = int.Parse(txtSon.Text);
                int m = int.Parse(txtSom.Text);
                int Tich = n * m;
                txtKetqua.Text = Tich.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");

            }
            else
            {
                float n = float.Parse(txtSon.Text);
                float m = float.Parse(txtSom.Text);
                float Thuong = n / m;
                txtKetqua.Text = Thuong.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
