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
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.qL_SinhVienDataSet.KetQua);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string conn = 
            global::Lab7_LeTruongMinhNhan.Properties.Settings.Default.QL_SinhVienConnectionString;
            string str;
            
            str = string.Format(" Select TenMH, Diem From KetQua,Mon where [KetQua].MaMH = [Mon].MaMH AND MaSo = {0} ",comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
         
            da.Fill(ds);
           
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
