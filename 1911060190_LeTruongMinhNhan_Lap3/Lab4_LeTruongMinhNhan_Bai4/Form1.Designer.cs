
namespace Lab4_LeTruongMinhNhan_Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btChonsolecuoi = new System.Windows.Forms.Button();
            this.btChonsochandau = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(114, 24);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(191, 20);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // btCapnhat
            // 
            this.btCapnhat.Location = new System.Drawing.Point(425, 22);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btCapnhat.TabIndex = 2;
            this.btCapnhat.Text = "cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.Location = new System.Drawing.Point(23, 76);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(212, 238);
            this.lstKetqua.TabIndex = 3;
            this.lstKetqua.SelectedIndexChanged += new System.EventHandler(this.lstKetqua_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXoaphantucuoi);
            this.groupBox1.Controls.Add(this.btXoaphantudau);
            this.groupBox1.Controls.Add(this.btXoaphantudangchon);
            this.groupBox1.Controls.Add(this.btChonsolecuoi);
            this.groupBox1.Controls.Add(this.btChonsochandau);
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Location = new System.Drawing.Point(283, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.Location = new System.Drawing.Point(7, 221);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.Size = new System.Drawing.Size(211, 23);
            this.btXoaphantucuoi.TabIndex = 0;
            this.btXoaphantucuoi.Text = "Xóa phần tử cuối";
            this.btXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.Location = new System.Drawing.Point(7, 183);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.Size = new System.Drawing.Size(211, 23);
            this.btXoaphantudau.TabIndex = 0;
            this.btXoaphantudau.Text = "Xóa phần tử đầu";
            this.btXoaphantudau.UseVisualStyleBackColor = true;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.Location = new System.Drawing.Point(7, 142);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.Size = new System.Drawing.Size(211, 23);
            this.btXoaphantudangchon.TabIndex = 0;
            this.btXoaphantudangchon.Text = "Xóa phần tử đang chọn";
            this.btXoaphantudangchon.UseVisualStyleBackColor = true;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btChonsolecuoi
            // 
            this.btChonsolecuoi.Location = new System.Drawing.Point(6, 100);
            this.btChonsolecuoi.Name = "btChonsolecuoi";
            this.btChonsolecuoi.Size = new System.Drawing.Size(211, 23);
            this.btChonsolecuoi.TabIndex = 0;
            this.btChonsolecuoi.Text = "Chọn số lẻ cuối";
            this.btChonsolecuoi.UseVisualStyleBackColor = true;
            this.btChonsolecuoi.Click += new System.EventHandler(this.btChonsolecuoi_Click);
            // 
            // btChonsochandau
            // 
            this.btChonsochandau.Location = new System.Drawing.Point(7, 61);
            this.btChonsochandau.Name = "btChonsochandau";
            this.btChonsochandau.Size = new System.Drawing.Size(211, 23);
            this.btChonsochandau.TabIndex = 0;
            this.btChonsochandau.Text = "Chọn số chẳn đầu";
            this.btChonsochandau.UseVisualStyleBackColor = true;
            this.btChonsochandau.Click += new System.EventHandler(this.btChonsochandau_Click);
            // 
            // btTang2
            // 
            this.btTang2.Location = new System.Drawing.Point(7, 19);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(211, 23);
            this.btTang2.TabIndex = 0;
            this.btTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = true;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(23, 321);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(484, 23);
            this.btnKetthuc.TabIndex = 5;
            this.btnKetthuc.Text = "Kết Thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 356);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btChonsolecuoi;
        private System.Windows.Forms.Button btChonsochandau;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btnKetthuc;
    }
}

