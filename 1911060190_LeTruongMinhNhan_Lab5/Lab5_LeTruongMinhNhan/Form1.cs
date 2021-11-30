using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab5_LeTruongMinhNhan
{
    public partial class Form1 : Form
    {
        string[] ban = new string[] { "B1", "B2", "B3", "B4" };
        DataTable tbOrder;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow dtr = tbOrder.Rows.Find(btn.Text);
            if (dtr == null)
            {
                DataRow r = tbOrder.NewRow();
                r["Món Ăn"] = btn.Text;
                r["Số Lượng"] = 1;

                tbOrder.Rows.Add(r);
                gvOrder.DataSource = tbOrder;
            }
            else 
            {
                dtr["Số Lượng"] = int.Parse(dtr["Số Lượng"].ToString()) + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbTenBan.Items.AddRange(ban);

            tbOrder = new DataTable();
            tbOrder.Columns.Add("Món Ăn");
            tbOrder.Columns.Add("Số Lượng");
            tbOrder.PrimaryKey = new DataColumn[]{tbOrder.Columns["Món Ăn"]};

            gvOrder.DataSource = tbOrder;

            gvOrder.Columns[0].Width = (int)(gvOrder.Width * 0.4);
            gvOrder.Columns[1].Width = (int)(gvOrder.Width * 0.5);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gvOrder.SelectedRows)
            {
                if (gvOrder.SelectedRows.Count > 0)
                {
                    tbOrder.Rows[r.Index].Delete();
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string fileName = "";
            saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            else
            {
                fileName = @"D:\File.txt";
            }

             streamWriter = new StreamWriter(fileName);

             streamWriter.WriteLine(String.Format("{0,-10}", "Bàn") +
                  String.Format("{0,-50}", gvOrder.Columns[0].HeaderText) +
                  String.Format("{0,-20}", gvOrder.Columns[1].HeaderText));

             for (int i = 0; i < gvOrder.Rows.Count - 1; i++)
             {
                  streamWriter.WriteLine(String.Format("{0,-10}", cbbTenBan.SelectedItem.ToString())
                  + String.Format("{0,-50}", gvOrder.Rows[i].Cells[0].Value)
                  + String.Format("{0,-20}", gvOrder.Rows[i].Cells[1].Value));
             }
             streamWriter.Close();
            
             tbOrder.Rows.Clear();
        }
    }
}
