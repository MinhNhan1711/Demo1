
namespace Lap03_Bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.btBoqua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbUCLN = new System.Windows.Forms.CheckBox();
            this.cbBCNN = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapB);
            this.groupBox1.Controls.Add(this.txtNhapA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBCNN);
            this.groupBox2.Controls.Add(this.cbUCLN);
            this.groupBox2.Location = new System.Drawing.Point(416, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btThoat);
            this.groupBox3.Controls.Add(this.btBoqua);
            this.groupBox3.Controls.Add(this.btTim);
            this.groupBox3.Controls.Add(this.txtKetQua);
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết Quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B:";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(110, 26);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(194, 20);
            this.txtNhapA.TabIndex = 2;
            this.txtNhapA.TextChanged += new System.EventHandler(this.txtNhapA_TextChanged);
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(110, 61);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(194, 20);
            this.txtNhapB.TabIndex = 3;
            this.txtNhapB.TextChanged += new System.EventHandler(this.txtNhapB_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(110, 19);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(248, 20);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(110, 59);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(229, 59);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 23);
            this.btBoqua.TabIndex = 5;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(354, 59);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbUCLN
            // 
            this.cbUCLN.AutoSize = true;
            this.cbUCLN.Location = new System.Drawing.Point(41, 24);
            this.cbUCLN.Name = "cbUCLN";
            this.cbUCLN.Size = new System.Drawing.Size(55, 17);
            this.cbUCLN.TabIndex = 0;
            this.cbUCLN.Text = "ƯCLN";
            this.cbUCLN.UseVisualStyleBackColor = true;
            this.cbUCLN.CheckedChanged += new System.EventHandler(this.cbUCLN_CheckedChanged);
            // 
            // cbBCNN
            // 
            this.cbBCNN.AutoSize = true;
            this.cbBCNN.Location = new System.Drawing.Point(41, 60);
            this.cbBCNN.Name = "cbBCNN";
            this.cbBCNN.Size = new System.Drawing.Size(56, 17);
            this.cbBCNN.TabIndex = 1;
            this.cbBCNN.Text = "BCNN";
            this.cbBCNN.UseVisualStyleBackColor = true;
            this.cbBCNN.CheckedChanged += new System.EventHandler(this.cbBCNN_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 225);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.CheckBox cbBCNN;
        private System.Windows.Forms.CheckBox cbUCLN;
    }
}

