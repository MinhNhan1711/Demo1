using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.IO;

namespace Lab4_LeTruongMinhNhan_Bai4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {

            //Control ctrSonguyen = (Control)sender;
            //if (ctrSonguyen.Text.Length > 0)
            //    if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
            //        this.txtSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
            //    else
            //        this.txtSonguyen.Clear();

            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsNumber(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                {
                    this.txtSonguyen.Clear();
                    MessageBox.Show("Bạn phải nhập vào số nguyên!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void frmThaotactrenListbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)

            e.Cancel = true;
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (txtSonguyen.Text == "")
            {
                MessageBox.Show("Chưa nhập giá trị \n");
            }
            else
            {
                lstKetqua.Items.Add(txtSonguyen.Text);
                txtSonguyen.Text = "";
                txtSonguyen.Focus();
            }    

        }

        
        private void btKetthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstKetqua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items.RemoveAt(i);
                lstKetqua.Items.Insert(i, tam.ToString());
            }
        }

        private void btChonsochandau_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; 
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();
                    lstKetqua.SelectedItem = s;
                    break; 
                }
            }
        }

        private void btChonsolecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; 
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetqua.Items[i].ToString();
                    lstKetqua.SelectedItem = s;
                    break; 
                }
            }
        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; 
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());
        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());
        }
    }
}
