using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab7_LeTruongMinhNhan
{
    public partial class Mon : Form
    {
        public Mon()
        {
            InitializeComponent();
        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void Mon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qL_SinhVienDataSet.Mon);

        }
    }
}
