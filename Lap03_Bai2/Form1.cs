using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lap03_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbUCLN_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbBCNN_CheckedChanged(object sender, EventArgs e)
        {
            
        
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapA.Text);
            int m = int.Parse(txtNhapB.Text);
            int KetQua;

            if (cbUCLN.Checked)
                KetQua = UCLN();
            else
                KetQua = BCNN();

            txtKetQua.Text = KetQua.ToString();
        }

        private int BCNN()
        {
            int i, j, hcf = 1, bcnn;
            int n = int.Parse(txtNhapA.Text);
            int m = int.Parse(txtNhapB.Text);

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

            int n = int.Parse(txtNhapA.Text);
            int m = int.Parse(txtNhapB.Text);

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

        private void btBoqua_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtKetQua.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
