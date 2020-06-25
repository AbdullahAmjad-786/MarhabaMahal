namespace MarhabaMahal.Views
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCashRcvd = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkPaymentMode = new System.Windows.Forms.CheckBox();
            this.lblBillId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bill";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBill.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.Color.White;
            this.lblTotalBill.Location = new System.Drawing.Point(299, 98);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(145, 36);
            this.lblTotalBill.TabIndex = 1;
            this.lblTotalBill.Text = "0.0";
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cash Recieved";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.LawnGreen;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(299, 295);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(145, 36);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0.0";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MarhabaMahal.Properties.Resources._1497617131_printer_2;
            this.button1.Location = new System.Drawing.Point(363, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 57);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCashRcvd
            // 
            this.txtCashRcvd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCashRcvd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashRcvd.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCashRcvd.Location = new System.Drawing.Point(299, 161);
            this.txtCashRcvd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCashRcvd.Name = "txtCashRcvd";
            this.txtCashRcvd.Size = new System.Drawing.Size(144, 44);
            this.txtCashRcvd.TabIndex = 8;
            this.txtCashRcvd.Text = "0.0";
            this.txtCashRcvd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCashRcvd.TextChanged += new System.EventHandler(this.txtCashRcvd_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 374);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkPaymentMode
            // 
            this.chkPaymentMode.AutoSize = true;
            this.chkPaymentMode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkPaymentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaymentMode.Location = new System.Drawing.Point(285, 242);
            this.chkPaymentMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPaymentMode.Name = "chkPaymentMode";
            this.chkPaymentMode.Size = new System.Drawing.Size(145, 29);
            this.chkPaymentMode.TabIndex = 10;
            this.chkPaymentMode.Text = "Credit Card";
            this.chkPaymentMode.UseVisualStyleBackColor = false;
            this.chkPaymentMode.CheckedChanged += new System.EventHandler(this.chkPaymentMode_CheckedChanged);
            // 
            // lblBillId
            // 
            this.lblBillId.BackColor = System.Drawing.Color.Black;
            this.lblBillId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblBillId.Location = new System.Drawing.Point(-3, -1);
            this.lblBillId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(472, 36);
            this.lblBillId.TabIndex = 11;
            this.lblBillId.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 31);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(211, 42);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 30);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone#:";
            this.lblPhone.Visible = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SteelBlue;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(77, 42);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 30);
            this.txtName.TabIndex = 16;
            this.txtName.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhone.Location = new System.Drawing.Point(298, 42);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 30);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Visible = false;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 437);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBillId);
            this.Controls.Add(this.chkPaymentMode);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCashRcvd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCashRcvd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkPaymentMode;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
    }
}