namespace MarhabaMahal.Views
{
    partial class OrdersPanel
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkManual = new System.Windows.Forms.RadioButton();
            this.chkAutomatic = new System.Windows.Forms.RadioButton();
            this.btnRefreshNewOrderTables = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNewOrders = new System.Windows.Forms.DataGridView();
            this.cmbTableNumbers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pendingOrders = new System.Windows.Forms.TabPage();
            this.txtGST = new System.Windows.Forms.ComboBox();
            this.chkNameNmbr = new System.Windows.Forms.CheckBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.txtNewId = new System.Windows.Forms.TextBox();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.checkBoxService = new System.Windows.Forms.CheckBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBillId = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.chkGST = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefreshTables = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.txtPendingTotal = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPendingOrders = new System.Windows.Forms.DataGridView();
            this.listTables = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPendingBillsRefresh = new System.Windows.Forms.Button();
            this.btnRcvdDone = new System.Windows.Forms.Button();
            this.listPending = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxClosingBillsId = new System.Windows.Forms.ListBox();
            this.marhabaDataSet = new MarhabaMahal.MarhabaDataSet();
            this.pendingorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pending_orderTableAdapter = new MarhabaMahal.MarhabaDataSetTableAdapters.pending_orderTableAdapter();
            this.printBill = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrders)).BeginInit();
            this.pendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.pendingOrders);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 767);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.chkManual);
            this.tabPage1.Controls.Add(this.chkAutomatic);
            this.tabPage1.Controls.Add(this.btnRefreshNewOrderTables);
            this.tabPage1.Controls.Add(this.btnPlaceOrder);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewNewOrders);
            this.tabPage1.Controls.Add(this.cmbTableNumbers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Order";
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Checked = true;
            this.chkManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkManual.Location = new System.Drawing.Point(455, 15);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(60, 17);
            this.chkManual.TabIndex = 64;
            this.chkManual.TabStop = true;
            this.chkManual.Text = "Manual";
            this.chkManual.UseVisualStyleBackColor = true;
            // 
            // chkAutomatic
            // 
            this.chkAutomatic.AutoSize = true;
            this.chkAutomatic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAutomatic.Location = new System.Drawing.Point(521, 15);
            this.chkAutomatic.Name = "chkAutomatic";
            this.chkAutomatic.Size = new System.Drawing.Size(72, 17);
            this.chkAutomatic.TabIndex = 63;
            this.chkAutomatic.TabStop = true;
            this.chkAutomatic.Text = "Automatic";
            this.chkAutomatic.UseVisualStyleBackColor = true;
            this.chkAutomatic.CheckedChanged += new System.EventHandler(this.chkAutomatic_CheckedChanged_1);
            // 
            // btnRefreshNewOrderTables
            // 
            this.btnRefreshNewOrderTables.Image = global::MarhabaMahal.Properties.Resources.refresh__2_;
            this.btnRefreshNewOrderTables.Location = new System.Drawing.Point(333, 13);
            this.btnRefreshNewOrderTables.Name = "btnRefreshNewOrderTables";
            this.btnRefreshNewOrderTables.Size = new System.Drawing.Size(26, 21);
            this.btnRefreshNewOrderTables.TabIndex = 47;
            this.btnRefreshNewOrderTables.UseVisualStyleBackColor = true;
            this.btnRefreshNewOrderTables.Click += new System.EventHandler(this.btnRefreshNewOrderTables_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(688, 637);
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
            this.txtTotal.Location = new System.Drawing.Point(121, 45);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(206, 26);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0.0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Total";
            // 
            // dataGridViewNewOrders
            // 
            this.dataGridViewNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewOrders.Location = new System.Drawing.Point(0, 119);
            this.dataGridViewNewOrders.Name = "dataGridViewNewOrders";
            this.dataGridViewNewOrders.Size = new System.Drawing.Size(770, 482);
            this.dataGridViewNewOrders.TabIndex = 32;
            this.dataGridViewNewOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewOrders_CellEnter);
            this.dataGridViewNewOrders.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewNewOrders_CellValidating);
            this.dataGridViewNewOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewOrders_CellValueChanged);
            this.dataGridViewNewOrders.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewNewOrders_CurrentCellDirtyStateChanged);
            this.dataGridViewNewOrders.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewNewOrders_EditingControlShowing);
            this.dataGridViewNewOrders.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewNewOrders_RowsRemoved);
            this.dataGridViewNewOrders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewNewOrders_UserDeletingRow);
            this.dataGridViewNewOrders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewNewOrders_KeyPress);
            // 
            // cmbTableNumbers
            // 
            this.cmbTableNumbers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTableNumbers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTableNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTableNumbers.FormattingEnabled = true;
            this.cmbTableNumbers.Location = new System.Drawing.Point(121, 14);
            this.cmbTableNumbers.Name = "cmbTableNumbers";
            this.cmbTableNumbers.Size = new System.Drawing.Size(206, 21);
            this.cmbTableNumbers.TabIndex = 31;
            this.cmbTableNumbers.SelectedIndexChanged += new System.EventHandler(this.cmbTableNumbers_SelectedIndexChanged);
            this.cmbTableNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTableNumbers_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Table Number";
            // 
            // pendingOrders
            // 
            this.pendingOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.pendingOrders.Controls.Add(this.txtGST);
            this.pendingOrders.Controls.Add(this.chkNameNmbr);
            this.pendingOrders.Controls.Add(this.cmbDiscount);
            this.pendingOrders.Controls.Add(this.chkDiscount);
            this.pendingOrders.Controls.Add(this.txtNewId);
            this.pendingOrders.Controls.Add(this.chkId);
            this.pendingOrders.Controls.Add(this.checkBoxService);
            this.pendingOrders.Controls.Add(this.txtService);
            this.pendingOrders.Controls.Add(this.label9);
            this.pendingOrders.Controls.Add(this.btnSwap);
            this.pendingOrders.Controls.Add(this.btnSearch);
            this.pendingOrders.Controls.Add(this.txtSearchBillId);
            this.pendingOrders.Controls.Add(this.lblSearch);
            this.pendingOrders.Controls.Add(this.chkGST);
            this.pendingOrders.Controls.Add(this.btnUpdate);
            this.pendingOrders.Controls.Add(this.btnRefreshTables);
            this.pendingOrders.Controls.Add(this.label7);
            this.pendingOrders.Controls.Add(this.btnBill);
            this.pendingOrders.Controls.Add(this.txtPendingTotal);
            this.pendingOrders.Controls.Add(this.txtGrandTotal);
            this.pendingOrders.Controls.Add(this.label5);
            this.pendingOrders.Controls.Add(this.label4);
            this.pendingOrders.Controls.Add(this.label3);
            this.pendingOrders.Controls.Add(this.dataGridViewPendingOrders);
            this.pendingOrders.Controls.Add(this.listTables);
            this.pendingOrders.Location = new System.Drawing.Point(4, 22);
            this.pendingOrders.Name = "pendingOrders";
            this.pendingOrders.Padding = new System.Windows.Forms.Padding(3);
            this.pendingOrders.Size = new System.Drawing.Size(769, 741);
            this.pendingOrders.TabIndex = 1;
            this.pendingOrders.Text = "Pending Orders";
            this.pendingOrders.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtGST
            // 
            this.txtGST.FormattingEnabled = true;
            this.txtGST.Items.AddRange(new object[] {
            "16",
            "5"});
            this.txtGST.Location = new System.Drawing.Point(703, 576);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(40, 21);
            this.txtGST.TabIndex = 61;
            this.txtGST.Text = "16";
            this.txtGST.SelectedIndexChanged += new System.EventHandler(this.txtGST_SelectedIndexChanged);
            // 
            // chkNameNmbr
            // 
            this.chkNameNmbr.AutoSize = true;
            this.chkNameNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNameNmbr.ForeColor = System.Drawing.Color.White;
            this.chkNameNmbr.Location = new System.Drawing.Point(361, 556);
            this.chkNameNmbr.Name = "chkNameNmbr";
            this.chkNameNmbr.Size = new System.Drawing.Size(157, 17);
            this.chkNameNmbr.TabIndex = 60;
            this.chkNameNmbr.Text = "Add Name And Number";
            this.chkNameNmbr.UseVisualStyleBackColor = true;
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
            this.cmbDiscount.Location = new System.Drawing.Point(487, 629);
            this.cmbDiscount.MaxLength = 10;
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(40, 21);
            this.cmbDiscount.TabIndex = 59;
            this.cmbDiscount.Text = "5";
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.CmbDiscount_SelectedIndexChanged);
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiscount.ForeColor = System.Drawing.Color.White;
            this.chkDiscount.Location = new System.Drawing.Point(361, 633);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(111, 17);
            this.chkDiscount.TabIndex = 58;
            this.chkDiscount.Text = "Add Discount%";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.ChkDiscount_CheckedChanged);
            // 
            // txtNewId
            // 
            this.txtNewId.Enabled = false;
            this.txtNewId.Location = new System.Drawing.Point(128, 630);
            this.txtNewId.Name = "txtNewId";
            this.txtNewId.Size = new System.Drawing.Size(182, 20);
            this.txtNewId.TabIndex = 57;
            this.txtNewId.Visible = false;
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkId.ForeColor = System.Drawing.Color.White;
            this.chkId.Location = new System.Drawing.Point(128, 603);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(63, 17);
            this.chkId.TabIndex = 56;
            this.chkId.Text = "Add Id";
            this.chkId.UseVisualStyleBackColor = true;
            this.chkId.Visible = false;
            this.chkId.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxService
            // 
            this.checkBoxService.AutoSize = true;
            this.checkBoxService.Checked = true;
            this.checkBoxService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxService.ForeColor = System.Drawing.Color.White;
            this.checkBoxService.Location = new System.Drawing.Point(361, 609);
            this.checkBoxService.Name = "checkBoxService";
            this.checkBoxService.Size = new System.Drawing.Size(145, 17);
            this.checkBoxService.TabIndex = 55;
            this.checkBoxService.Text = "Add Service Charges";
            this.checkBoxService.UseVisualStyleBackColor = true;
            this.checkBoxService.CheckedChanged += new System.EventHandler(this.checkBoxService_CheckedChanged);
            // 
            // txtService
            // 
            this.txtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtService.Cursor = System.Windows.Forms.Cursors.No;
            this.txtService.Location = new System.Drawing.Point(703, 608);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(42, 20);
            this.txtService.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(559, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Service Charges %age";
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(6, 574);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 52;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Visible = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBillId
            // 
            this.txtSearchBillId.Location = new System.Drawing.Point(209, 12);
            this.txtSearchBillId.Name = "txtSearchBillId";
            this.txtSearchBillId.Size = new System.Drawing.Size(191, 20);
            this.txtSearchBillId.TabIndex = 50;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(118, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(85, 13);
            this.lblSearch.TabIndex = 49;
            this.lblSearch.Text = "Search Bill ID";
            // 
            // chkGST
            // 
            this.chkGST.AutoSize = true;
            this.chkGST.Checked = true;
            this.chkGST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGST.ForeColor = System.Drawing.Color.White;
            this.chkGST.Location = new System.Drawing.Point(361, 584);
            this.chkGST.Name = "chkGST";
            this.chkGST.Size = new System.Drawing.Size(77, 17);
            this.chkGST.TabIndex = 48;
            this.chkGST.Text = "Add GST";
            this.chkGST.UseVisualStyleBackColor = true;
            this.chkGST.CheckedChanged += new System.EventHandler(this.chkGST_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 556);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 47;
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
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tables";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(654, 672);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(91, 34);
            this.btnBill.TabIndex = 44;
            this.btnBill.Text = "&Print Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // txtPendingTotal
            // 
            this.txtPendingTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendingTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPendingTotal.Location = new System.Drawing.Point(654, 551);
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
            this.txtGrandTotal.Location = new System.Drawing.Point(654, 634);
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
            this.label5.Location = new System.Drawing.Point(559, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "GrandTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(559, 584);
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
            this.label3.Location = new System.Drawing.Point(589, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total";
            // 
            // dataGridViewPendingOrders
            // 
            this.dataGridViewPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingOrders.Location = new System.Drawing.Point(104, 38);
            this.dataGridViewPendingOrders.Name = "dataGridViewPendingOrders";
            this.dataGridViewPendingOrders.Size = new System.Drawing.Size(665, 507);
            this.dataGridViewPendingOrders.TabIndex = 1;
            this.dataGridViewPendingOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendingOrders_CellEnter);
            this.dataGridViewPendingOrders.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewPendingOrders_CellValidating);
            this.dataGridViewPendingOrders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPendingOrders_CellValueChanged);
            this.dataGridViewPendingOrders.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewPendingOrders_CurrentCellDirtyStateChanged);
            this.dataGridViewPendingOrders.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewPendingOrders_EditingControlShowing);
            this.dataGridViewPendingOrders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPendingOrders_UserDeletingRow);
            this.dataGridViewPendingOrders.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridViewPendingOrders_Validating);
            // 
            // listTables
            // 
            this.listTables.FormattingEnabled = true;
            this.listTables.Location = new System.Drawing.Point(-1, 31);
            this.listTables.Name = "listTables";
            this.listTables.Size = new System.Drawing.Size(102, 537);
            this.listTables.TabIndex = 0;
            this.listTables.SelectedIndexChanged += new System.EventHandler(this.listTables_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lblTotalBill);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnPendingBillsRefresh);
            this.tabPage3.Controls.Add(this.btnRcvdDone);
            this.tabPage3.Controls.Add(this.listPending);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 741);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pending Bills";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tables";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBill.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.Color.White;
            this.lblTotalBill.Location = new System.Drawing.Point(511, 104);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(109, 29);
            this.lblTotalBill.TabIndex = 4;
            this.lblTotalBill.Text = "0.0";
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Bill";
            // 
            // btnPendingBillsRefresh
            // 
            this.btnPendingBillsRefresh.Location = new System.Drawing.Point(511, 16);
            this.btnPendingBillsRefresh.Name = "btnPendingBillsRefresh";
            this.btnPendingBillsRefresh.Size = new System.Drawing.Size(158, 23);
            this.btnPendingBillsRefresh.TabIndex = 2;
            this.btnPendingBillsRefresh.Text = "Refresh";
            this.btnPendingBillsRefresh.UseVisualStyleBackColor = true;
            this.btnPendingBillsRefresh.Click += new System.EventHandler(this.btnPendingBillsRefresh_Click);
            // 
            // btnRcvdDone
            // 
            this.btnRcvdDone.Location = new System.Drawing.Point(289, 16);
            this.btnRcvdDone.Name = "btnRcvdDone";
            this.btnRcvdDone.Size = new System.Drawing.Size(175, 23);
            this.btnRcvdDone.TabIndex = 1;
            this.btnRcvdDone.Text = "Recieved";
            this.btnRcvdDone.UseVisualStyleBackColor = true;
            this.btnRcvdDone.Click += new System.EventHandler(this.btnRcvdDone_Click);
            // 
            // listPending
            // 
            this.listPending.FormattingEnabled = true;
            this.listPending.Location = new System.Drawing.Point(18, 77);
            this.listPending.Name = "listPending";
            this.listPending.Size = new System.Drawing.Size(197, 615);
            this.listPending.TabIndex = 0;
            this.listPending.SelectedIndexChanged += new System.EventHandler(this.listPending_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage4.Controls.Add(this.listBoxClosingBillsId);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(769, 741);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bills For Today";
            // 
            // listBoxClosingBillsId
            // 
            this.listBoxClosingBillsId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxClosingBillsId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxClosingBillsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxClosingBillsId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBoxClosingBillsId.FormattingEnabled = true;
            this.listBoxClosingBillsId.ItemHeight = 24;
            this.listBoxClosingBillsId.Location = new System.Drawing.Point(6, 6);
            this.listBoxClosingBillsId.Name = "listBoxClosingBillsId";
            this.listBoxClosingBillsId.Size = new System.Drawing.Size(285, 626);
            this.listBoxClosingBillsId.TabIndex = 0;
            this.listBoxClosingBillsId.SelectedIndexChanged += new System.EventHandler(this.listBoxClosingBillsId_SelectedIndexChanged);
            // 
            // marhabaDataSet
            // 
            this.marhabaDataSet.DataSetName = "MarhabaDataSet";
            this.marhabaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pendingorderBindingSource
            // 
            this.pendingorderBindingSource.DataMember = "pending_order";
            this.pendingorderBindingSource.DataSource = this.marhabaDataSet;
            // 
            // pending_orderTableAdapter
            // 
            this.pending_orderTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tabControl1);
            this.Name = "OrdersPanel";
            this.Size = new System.Drawing.Size(777, 742);
            this.Load += new System.EventHandler(this.OrdersPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrders)).EndInit();
            this.pendingOrders.ResumeLayout(false);
            this.pendingOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewNewOrders;
        private System.Windows.Forms.ComboBox cmbTableNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage pendingOrders;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dataGridViewPendingOrders;
        private System.Windows.Forms.ListBox listTables;
        private System.Windows.Forms.TextBox txtPendingTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefreshTables;
        private System.Windows.Forms.BindingSource pendingorderBindingSource;
        private MarhabaDataSet marhabaDataSet;
        private MarhabaDataSetTableAdapters.pending_orderTableAdapter pending_orderTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Drawing.Printing.PrintDocument printBill;
        private System.Windows.Forms.CheckBox chkGST;
        private System.Windows.Forms.TextBox txtSearchBillId;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listPending;
        private System.Windows.Forms.Button btnRcvdDone;
        private System.Windows.Forms.Button btnPendingBillsRefresh;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBoxClosingBillsId;
        private System.Windows.Forms.Button btnRefreshNewOrderTables;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.CheckBox checkBoxService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkId;
        private System.Windows.Forms.TextBox txtNewId;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.CheckBox chkNameNmbr;
        private System.Windows.Forms.RadioButton chkManual;
        private System.Windows.Forms.RadioButton chkAutomatic;
        private System.Windows.Forms.ComboBox txtGST;
    }
}
