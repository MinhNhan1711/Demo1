
namespace Lab4_LeTruongMinhNhan_Bai1
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
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Location = new System.Drawing.Point(434, 91);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(49, 13);
            this.lblCleanCost.TabIndex = 0;
            this.lblCleanCost.Text = "$ 100.00";
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Location = new System.Drawing.Point(67, 87);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(62, 17);
            this.chkClean.TabIndex = 1;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Location = new System.Drawing.Point(67, 129);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(71, 17);
            this.chkWhitening.TabIndex = 1;
            this.chkWhitening.Text = "Tẩy trắng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Location = new System.Drawing.Point(67, 165);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(98, 17);
            this.chkXRay.TabIndex = 1;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            this.chkXRay.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Location = new System.Drawing.Point(422, 130);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(61, 13);
            this.lblWhiteningCost.TabIndex = 0;
            this.lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Location = new System.Drawing.Point(431, 169);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(52, 13);
            this.lblXRayCost.TabIndex = 0;
            this.lblXRayCost.Text = "$200.000";
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Location = new System.Drawing.Point(418, 207);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(65, 13);
            this.lblFillCost.TabIndex = 0;
            this.lblFillCost.Text = "$80.000/cái";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(64, 207);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(55, 13);
            this.lblFilling.TabIndex = 0;
            this.lblFilling.Text = "Trám răng";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(160, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dental Payment Form";
            this.lblTitle.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên khách hàng";
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(140, 200);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(120, 20);
            this.numFilling.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(286, 248);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(94, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(355, 281);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(344, 241);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(127, 320);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 134);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 469);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.lblCleanCost);
            this.Name = "Form1";
            this.Text = "Dental Payment Application";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.CheckBox chkWhitening;
        private System.Windows.Forms.CheckBox chkXRay;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox listBox1;
    }
}

