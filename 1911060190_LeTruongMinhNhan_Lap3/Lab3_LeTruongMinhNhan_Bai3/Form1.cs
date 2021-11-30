using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Lab3_LeTruongMinhNhan_Bai3
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

        private void btnSo_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            txtCode.Text = txtCode.Text + num.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                txtCode.Text = txtCode.Text.Remove(txtCode.Text.Length - 1, 1);
            }
            if (txtCode.Text == "")
            {
                txtCode.Text = "";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String access = txtCode.Text;
                DateTime d = DateTime.Now;
                FileStream fileStream = new FileStream(@"D:\Tai_Lieu_Hoc_ONLINE\TH_LaptrinhWindown\1911060190_LeTruongMinhNhan_Lap3\Lab3_LeTruongMinhNhan_Bai3\text.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fileStream);
                sw.WriteLine(access);
                sw.Flush();
                sw.Close();
                fileStream.Close();

                if (access.Length == 1)
                {
                    lbx.Items.Add(d + "     “Restricted Access”");
                }
                else
                {
                    switch (access)
                    {
                        case "1645":
                            lbx.Items.Add(d + "       Technicians");
                            break;
                        case "1689":
                            lbx.Items.Add(d + "       Technicians");
                            break;
                        case "8345":
                            lbx.Items.Add(d + "       Custodians");
                            break;
                        case "9998":
                            lbx.Items.Add(d + "       Scientist");
                            break;
                        case "1006":
                            lbx.Items.Add(d + "       Scientist");
                            break;
                        case "1008":
                            lbx.Items.Add(d + "       Scientist");
                            break;
                        default:
                            lbx.Items.Add(d + "       Access denied");
                            break;
                    }
                }
            }

        }
    }
}
