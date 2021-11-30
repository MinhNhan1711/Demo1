using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3_LeTruongMinhNhan_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtSoA.Text == "" || txtSoB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            } 
            else
            {
                int KetQua;
                if (rdoUSCLN.Checked)
                    KetQua = UCLN();
                else
                    KetQua = BCNN();

                txtKetqua.Text = KetQua.ToString();
            }    
        }


        private int BCNN()
        {
            int i, j, hcf = 1, bcnn;
            int n = int.Parse(txtSoA.Text);
            int m = int.Parse(txtSoB.Text);

            j = (n < m) ? n : m;

            for (i = 1; i <= j; i++)
            {

                if (n % i == 0 && m % i == 0)
                {
                    hcf = i;
                }
            }
            return bcnn = (n * m) / hcf;
        }

        private int UCLN()
        {
            int i, j, ucln = 1;

            int n = int.Parse(txtSoA.Text);
            int m = int.Parse(txtSoB.Text);

            j = (n < m) ? n : m;
            for (i = 1; i <= j; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    ucln = i;
                }
            }

            return ucln;
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetqua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
