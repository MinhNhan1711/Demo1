using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab4_LeTruongMinhNhan_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = 0;
                if (chkClean.Checked == true) { Total += 100000; }
                if (chkWhitening.Checked == true) { Total += 1200000; }
                if (chkXRay.Checked == true) { Total += 200000; }

                int num = int.Parse(numFilling.Text);
                Total += num * 80000;
                txtTotal.Text = Total.ToString();
                listBox1.Items.Add(txtName.Text + "       " + Total.ToString());
                String access = (txtName.Text + "       " + Total.ToString());
                FileStream fileStream = new FileStream(@"D:\Tai_Lieu_Hoc_ONLINE\TH_LaptrinhWindown\1911060190_LeTruongMinhNhan_Lap3\Lab4_LeTruongMinhNhan_Bai1\text.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fileStream);
                sw.WriteLine(access);
                sw.Flush();
                sw.Close();
                fileStream.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
