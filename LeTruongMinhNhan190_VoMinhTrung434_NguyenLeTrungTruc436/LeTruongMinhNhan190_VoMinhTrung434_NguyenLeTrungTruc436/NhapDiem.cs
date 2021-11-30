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
    public partial class NhapDiem : Form
    {
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qL_SinhVienDataSet.Mon);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet.SinhVien);

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string conn =
            global::Lab7_LeTruongMinhNhan.Properties.Settings.Default.QL_SinhVienConnectionString;
            string str;

            str = string.Format("Insert Into KetQua(MaSo, MaMH, Diem) Values( '{0}', '{1}', '{2}')", comboBox1.Text, comboBox3.Text, textBox1.Text);

            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            MessageBox.Show("Nhập điểm thành công");
        }
    }
}
