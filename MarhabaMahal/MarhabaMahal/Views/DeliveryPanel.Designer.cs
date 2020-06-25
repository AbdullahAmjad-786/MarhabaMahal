namespace MarhabaMahal.Views
{
    partial class DeliveryPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNewOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.txtNewId = new System.Windows.Forms.TextBox();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.chkService = new System.Windows.Forms.CheckBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.chkGST = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefreshTables = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.txtPendingTotal = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPendingOrders = new System.Windows.Forms.DataGridView();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 774);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnPlaceOrder);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewNewOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 748);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Delivery";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 70);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 88);
            this.txtAddress.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(103, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(167, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 20);
            this.txtPhone.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(103, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(677, 632);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 25);
            this.btnPlaceOrder.TabIndex = 35;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Black;
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtTotal.Location = new System.Drawing.Point(455, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(108, 26);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0.0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Total";
            // 
            // dataGridViewNewOrders
            // 
            this.dataGridViewNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewOrders.Location = new System.Drawing.Point(-3, 165);
            this.dataGridViewNewOrders.Name = "dataGridViewNewOrders";
            this.dataGridViewNewOrders.Size = new System.Drawing.Size(772, 461);
            this.dataGridViewNewOrders.TabIndex = 32;
            this.dataGridViewNewOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewOrders_CellEnter);
            this.dataGridViewNewOrders.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewNewOrders_CellValidating);
            this.dataGridViewNewOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewOrders_CellValueChanged_1);
            this.dataGridViewNewOrders.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewNewOrders_CurrentCellDirtyStateChanged);
            this.dataGridViewNewOrders.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewNewOrders_EditingControlShowing);
            this.dataGridViewNewOrders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewNewOrders_UserDeletingRow);
            this.dataGridViewNewOrders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewNewOrders_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.cmbDiscount);
            this.tabPage2.Controls.Add(this.chkDiscount);
            this.tabPage2.Controls.Add(this.txtNewId);
            this.tabPage2.Controls.Add(this.chkId);
            this.tabPage2.Controls.Add(this.chkService);
            this.tabPage2.Controls.Add(this.txtService);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPhoneSearch);
            this.tabPage2.Controls.Add(this.chkGST);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.btnRefreshTables);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnBill);
            this.tabPage2.Controls.Add(this.txtPendingTotal);
            this.tabPage2.Controls.Add(this.txtGrandTotal);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtGST);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridViewPendingOrders);
            this.tabPage2.Controls.Add(this.listOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 748);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pending Deliveries";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Enabled = false;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "1",
            "10",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbDiscount.Location = new System.Drawing.Point(498, 633);
            this.cmbDiscount.MaxLength = 10;
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(40, 21);
            this.cmbDiscount.TabIndex = 63;
            this.cmbDiscount.Text = "5";
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.CmbDiscount_SelectedIndexChanged);
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiscount.ForeColor = System.Drawing.Color.White;
            this.chkDiscount.Location = new System.Drawing.Point(381, 636);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(111, 17);
            this.chkDiscount.TabIndex = 62;
            this.chkDiscount.Text = "Add Discount%";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.ChkDiscount_CheckedChanged);
            // 
            // txtNewId
            // 
            this.txtNewId.Enabled = false;
            this.txtNewId.Location = new System.Drawing.Point(159, 634);
            this.txtNewId.Name = "txtNewId";
            this.txtNewId.Size = new System.Drawing.Size(182, 20);
            this.txtNewId.TabIndex = 61;
            this.txtNewId.Visible = false;
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkId.ForeColor = System.Drawing.Color.White;
            this.chkId.Location = new System.Drawing.Point(159, 607);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(63, 17);
            this.chkId.TabIndex = 60;
            this.chkId.Text = "Add Id";
            this.chkId.UseVisualStyleBackColor = true;
            this.chkId.Visible = false;
            this.chkId.CheckedChanged += new System.EventHandler(this.ChkId_CheckedChanged);
            // 
            // chkService
            // 
            this.chkService.AutoSize = true;
            this.chkService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkService.ForeColor = System.Drawing.Color.White;
            this.chkService.Location = new System.Drawing.Point(381, 607);
            this.chkService.Name = "chkService";
            this.chkService.Size = new System.Drawing.Size(145, 17);
            this.chkService.TabIndex = 55;
            this.chkService.Text = "Add Service Charges";
            this.chkService.UseVisualStyleBackColor = true;
            this.chkService.CheckedChanged += new System.EventHandler(this.ChkService_CheckedChanged);
            // 
            // txtService
            // 
            this.txtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtService.Cursor = System.Windows.Forms.Cursors.No;
            this.txtService.Location = new System.Drawing.Point(698, 600);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(42, 20);
            this.txtService.TabIndex = 54;
            this.txtService.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(554, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Service Charges %age";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(483, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(153, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Search Order With Phone";
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(311, 7);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(248, 20);
            this.txtPhoneSearch.TabIndex = 50;
            // 
            // chkGST
            // 
            this.chkGST.AutoSize = true;
            this.chkGST.Checked = true;
            this.chkGST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGST.ForeColor = System.Drawing.Color.White;
            this.chkGST.Location = new System.Drawing.Point(381, 572);
            this.chkGST.Name = "chkGST";
            this.chkGST.Size = new System.Drawing.Size(77, 17);
            this.chkGST.TabIndex = 49;
            this.chkGST.Text = "Add GST";
            this.chkGST.UseVisualStyleBackColor = true;
            this.chkGST.CheckedChanged += new System.EventHandler(this.chkGST_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefreshTables
            // 
            this.btnRefreshTables.Image = global::MarhabaMahal.Properties.Resources.refresh__2_;
            this.btnRefreshTables.Location = new System.Drawing.Point(66, 3);
            this.btnRefreshTables.Name = "btnRefreshTables";
            this.btnRefreshTables.Size = new System.Drawing.Size(26, 21);
            this.btnRefreshTables.TabIndex = 46;
            this.btnRefreshTables.UseVisualStyleBackColor = true;
            this.btnRefreshTables.Click += new System.EventHandler(this.btnRefreshTables_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 45;
            this.label7.Text = "Orders";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(649, 669);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(91, 34);
            this.btnBill.TabIndex = 44;
            this.btnBill.Text = "Print Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // txtPendingTotal
            // 
            this.txtPendingTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendingTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPendingTotal.Location = new System.Drawing.Point(649, 539);
            this.txtPendingTotal.Name = "txtPendingTotal";
            this.txtPendingTotal.ReadOnly = true;
            this.txtPendingTotal.Size = new System.Drawing.Size(91, 20);
            this.txtPendingTotal.TabIndex = 41;
            this.txtPendingTotal.Text = "0.0";
            this.txtPendingTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPendingTotal.TextChanged += new System.EventHandler(this.txtPendingTotal_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.Black;
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtGrandTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtGrandTotal.Location = new System.Drawing.Point(649, 636);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(91, 26);
            this.txtGrandTotal.TabIndex = 40;
            this.txtGrandTotal.TabStop = false;
            this.txtGrandTotal.Text = "0.0";
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(554, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "GrandTotal";
            // 
            // txtGST
            // 
            this.txtGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGST.Cursor = System.Windows.Forms.Cursors.No;
            this.txtGST.Location = new System.Drawing.Point(698, 565);
            this.txtGST.Name = "txtGST";
            this.txtGST.ReadOnly = true;
            this.txtGST.Size = new System.Drawing.Size(42, 20);
            this.txtGST.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(554, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "GST %age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(584, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total";
            // 
            // dataGridViewPendingOrders
            // 
            this.dataGridViewPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingOrders.Location = new System.Drawing.Point(108, 72);
            this.dataGridViewPendingOrders.Name = "dataGridViewPendingOrders";
            this.dataGridViewPendingOrders.Size = new System.Drawing.Size(665, 461);
            this.dataGridViewPendingOrders.TabIndex = 1;
            this.dataGridViewPendingOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendingOrders_CellEnter);
            this.dataGridViewPendingOrders.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewPendingOrders_CellValidating);
            this.dataGridViewPendingOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendingOrders_CellValueChanged);
            this.dataGridViewPendingOrders.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewPendingOrders_CurrentCellDirtyStateChanged);
            this.dataGridViewPendingOrders.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewPendingOrders_EditingControlShowing);
            this.dataGridViewPendingOrders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPendingOrders_UserDeletingRow);
            // 
            // listOrders
            // 
            this.listOrders.FormattingEnabled = true;
            this.listOrders.Location = new System.Drawing.Point(0, 30);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(102, 719);
            this.listOrders.TabIndex = 0;
            this.listOrders.SelectedIndexChanged += new System.EventHandler(this.listOrders_SelectedIndexChanged);
            // 
            // DeliveryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.tabControl1);
            this.Name = "DeliveryPanel";
            this.Size = new System.Drawing.Size(777, 742);
            this.Load += new System.EventHandler(this.DeliveryPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNewOrders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRefreshTables;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.TextBox txtPendingTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPendingOrders;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkGST;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.CheckBox chkService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.TextBox txtNewId;
        private System.Windows.Forms.CheckBox chkId;
    }
}
