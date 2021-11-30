using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab7_LeTruongMinhNhan
{
    public partial class KHOA : Form
    {
        public KHOA()
        {
            InitializeComponent();
        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void KHOA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qL_SinhVienDataSet.KHOA);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qL_SinhVienDataSet.Mon);

        }
    }
}
