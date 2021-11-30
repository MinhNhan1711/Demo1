using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_DoNgocTrinh_Bai1_2
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //dinh dang 4 cot
            lsvNhanVien.Columns[0].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[1].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[2].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.Columns[3].Width = (int)(lsvNhanVien.Width * 0.25);
            lsvNhanVien.View = View.Details;
            lsvNhanVien.GridLines = true;
            lsvNhanVien.FullRowSelect = true;
        }

        bool CheckInput()
        {
            long result;
            if (txbHoTen.Text == "" || txbDienthoai.Text == "" || txbDiaChi.Text == "" || dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin ", "Yêu cầu");
               
                return false;
            }
            if (!(long.TryParse(txbDienthoai.Text, out result)))
            {
                MessageBox.Show("Hãy nhập đúng định dạnh Số", "Yêu cầu");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txbHoTen.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Hãy nhập đúng định dạng Tên","Yêu cầu");
                
                return false;
            }
            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18)
            {
                MessageBox.Show("Tuổi ko thể <18", "Thông báo");
                return false;
            }
            

            return true;

        }
     

            private void bntThem_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }


           


            ListViewItem item = lsvNhanVien.Items.Add(txbHoTen.Text);
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txbDiaChi.Text);
            item.SubItems.Add(txbDienthoai.Text);

            txbDienthoai.Text = "";
            txbDiaChi.Text = "";
            txbHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txbHoTen.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txbDiaChi.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txbDienthoai.Text;
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn kết thúc không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                Application.Exit();
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txbHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txbDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txbDienthoai.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
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
    }
}
