
namespace TetsLab5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbbTenBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBPmB = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBPmG = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(198, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fastfood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.btnBPmG);
            this.groupBox1.Controls.Add(this.btnBPmB);
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // gvOrder
            // 
            this.gvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Location = new System.Drawing.Point(12, 258);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.Size = new System.Drawing.Size(416, 180);
            this.gvOrder.TabIndex = 3;
            this.gvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbTenBan
            // 
            this.cbbTenBan.FormattingEnabled = true;
            this.cbbTenBan.Location = new System.Drawing.Point(185, 231);
            this.cbbTenBan.Name = "cbbTenBan";
            this.cbbTenBan.Size = new System.Drawing.Size(137, 21);
            this.cbbTenBan.TabIndex = 5;
            this.cbbTenBan.SelectedIndexChanged += new System.EventHandler(this.cbbTenBan_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(328, 229);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(99, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên bàn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBPmB
            // 
            this.btnBPmB.Location = new System.Drawing.Point(6, 19);
            this.btnBPmB.Name = "btnBPmB";
            this.btnBPmB.Size = new System.Drawing.Size(134, 23);
            this.btnBPmB.TabIndex = 4;
            this.btnBPmB.Text = "Burger Phô mai Bò";
            this.btnBPmB.UseVisualStyleBackColor = true;
            this.btnBPmB.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tôm viên Cola";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(286, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Pessi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(348, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Coca";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // btnBPmG
            // 
            this.btnBPmG.Location = new System.Drawing.Point(6, 48);
            this.btnBPmG.Name = "btnBPmG";
            this.btnBPmG.Size = new System.Drawing.Size(134, 23);
            this.btnBPmG.TabIndex = 4;
            this.btnBPmG.Text = "Burger Phô mai Gà";
            this.btnBPmG.UseVisualStyleBackColor = true;
            this.btnBPmG.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(146, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Gà viên Cola";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(286, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "7 Up";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(348, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "Lipton";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 79);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(134, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "Burger Phô mai Tôm";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 108);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(134, 23);
            this.button12.TabIndex = 4;
            this.button12.Text = "Burger Phô mai Cá";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(146, 79);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(134, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "Gà rán phần";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(146, 108);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(134, 23);
            this.button14.TabIndex = 4;
            this.button14.Text = "Cơm gà Tender";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(286, 79);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 23);
            this.button15.TabIndex = 4;
            this.button15.Text = "Cafe";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(286, 108);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(118, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "Khoai Tay Chiên";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(348, 79);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(56, 23);
            this.button17.TabIndex = 4;
            this.button17.Text = "Cam";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnBPmB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTenBan);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gvOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbTenBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnBPmG;
        private System.Windows.Forms.Button btnBPmB;
    }
}

