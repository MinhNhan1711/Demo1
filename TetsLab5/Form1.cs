using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetsLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ban = new string[] { "B1", "B2", "B3", "B4" };
        DataTable tbOrder;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cbbTenBan.Items.AddRange(ban);

            tbOrder = new DataTable();
            tbOrder.Columns.Add("Món Ăn");
            tbOrder.Columns.Add("Số Lượng");

            gvOrder.DataSource = tbOrder;

            gvOrder.Columns[0].Width = (int)(gvOrder.Width * 0.4);
            gvOrder.Columns[1].Width = (int)(gvOrder.Width * 0.5);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbTenBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbTenBan.SelectedItem.ToString());
        }

        private void btnBPmB_Click(object sender, EventArgs e)
        {
            DataRow r;
            bool co = true;
            Button b = (Button)sender;

            r = tbOrder.NewRow();

            foreach (DataRow item in tbOrder.Rows)
            {
                if (item[0].ToString() == b.Text)
                {
                    co = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    break;
                }
            }
            if(co)
            {
                r[0] = b.Text;
                r[1] = 1;

                tbOrder.Rows.Add(r);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbOrder.Rows.Clear();
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
                fileName = @"D:\FileLog.txt";
            }

            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);

                streamWriter.WriteLine(String.Format("{0,-10}", "Bàn") +
                    String.Format("{0,-40}", gvOrder.Columns[0].HeaderText) +
                    String.Format("{0,-20}", gvOrder.Columns[1].HeaderText));

                for (int i = 0; i < gvOrder.Rows.Count - 1; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-10}", cbbTenBan.SelectedItem.ToString())
                    + String.Format("{0,-40}", gvOrder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-20}", gvOrder.Rows[i].Cells[1].Value));
                    //streamWriter.WriteLine(gvOrder.Rows[i].Cells[0].Value.ToString() + " " +
                    //    gvOrder.Rows[i].Cells[1].Value.ToString());
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                for (int i = 0; i < gvOrder.Rows.Count - 1; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-10}", cbbTenBan.SelectedItem.ToString())
                    + String.Format("{0,-40}", gvOrder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-20}", gvOrder.Rows[i].Cells[1].Value));
                    //streamWriter.WriteLine(gvOrder.Rows[i].Cells[0].Value.ToString() + " " +
                    //    gvOrder.Rows[i].Cells[1].Value.ToString());
                }
                streamWriter.Close();
            }
        }
    }
}
