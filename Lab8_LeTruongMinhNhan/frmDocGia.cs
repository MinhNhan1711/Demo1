using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab8_LeTruongMinhNhan
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        DocGia dg = new DocGia();
        Database db = new Database (frmMDI.srvName, frmMDI.dbName, frmMDI.IntergratedMode, "", "");
        DataTable dt = new DataTable();

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            dt = dg.LayDSDocGia();
            dgvDocGia.DataSource = dt;
            dgvDocGia.Columns[0].Visible = false;
            dgvDocGia.Columns[1].Width = 180;
            dgvDocGia.Columns[3].Width = 200;
            dgvDocGia.Columns[4].Width = 200;
        }

        public DataTable LayDSDocGia()
        {
            string strSQL = "Select MaDocGia, HoTenDocGia, Ngaysinh, Diachi, Email, NgayLapThe, NgayHetHan From DocGia N, BANGCAP B Where N.MaBangCap = B.MaBangCap";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                db.Update ("Select * from DocGia", dt);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (DataException de)
            {
                MessageBox.Show("Có lỗi khi cập nhật \n" + de.ToString(), "lỗi",

                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
