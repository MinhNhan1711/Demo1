using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab7_LeTruongMinhNhan
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qL_SinhVienDataSet.KHOA);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet.SinhVien);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";


            string str;

            str = string.Format(" Select HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai From SinhVien, KHOA where  [SinhVien].MaKhoa = [KHOA].MaKhoa AND TenKhoa = N'{0}' ", comboBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
