namespace MarhabaMahal.Views
{
    partial class TaxData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxData));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxDataSetClosingTable = new MarhabaMahal.TaxDataSetClosingTable();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.closingTableAdapter = new MarhabaMahal.TaxDataSetClosingTableTableAdapters.closingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartBillId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxDataSetClosingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billidDataGridViewTextBoxColumn,
            this.billcodeDataGridViewTextBoxColumn,
            this.billdateDataGridViewTextBoxColumn,
            this.totalbillDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.tablenoDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.closingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(804, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // billidDataGridViewTextBoxColumn
            // 
            this.billidDataGridViewTextBoxColumn.DataPropertyName = "bill_id";
            this.billidDataGridViewTextBoxColumn.HeaderText = "bill_id";
            this.billidDataGridViewTextBoxColumn.Name = "billidDataGridViewTextBoxColumn";
            this.billidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billcodeDataGridViewTextBoxColumn
            // 
            this.billcodeDataGridViewTextBoxColumn.DataPropertyName = "bill_code";
            this.billcodeDataGridViewTextBoxColumn.HeaderText = "bill_code";
            this.billcodeDataGridViewTextBoxColumn.Name = "billcodeDataGridViewTextBoxColumn";
            this.billcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billdateDataGridViewTextBoxColumn
            // 
            this.billdateDataGridViewTextBoxColumn.DataPropertyName = "bill_date";
            this.billdateDataGridViewTextBoxColumn.HeaderText = "bill_date";
            this.billdateDataGridViewTextBoxColumn.Name = "billdateDataGridViewTextBoxColumn";
            this.billdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalbillDataGridViewTextBoxColumn
            // 
            this.totalbillDataGridViewTextBoxColumn.DataPropertyName = "total_bill";
            this.totalbillDataGridViewTextBoxColumn.HeaderText = "total_bill";
            this.totalbillDataGridViewTextBoxColumn.Name = "totalbillDataGridViewTextBoxColumn";
            this.totalbillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablenoDataGridViewTextBoxColumn
            // 
            this.tablenoDataGridViewTextBoxColumn.DataPropertyName = "table_no";
            this.tablenoDataGridViewTextBoxColumn.HeaderText = "table_no";
            this.tablenoDataGridViewTextBoxColumn.Name = "tablenoDataGridViewTextBoxColumn";
            this.tablenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            this.customerphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closingBindingSource
            // 
            this.closingBindingSource.DataMember = "closing";
            this.closingBindingSource.DataSource = this.taxDataSetClosingTable;
            this.closingBindingSource.CurrentItemChanged += new System.EventHandler(this.closingBindingSource_CurrentItemChanged);
            this.closingBindingSource.PositionChanged += new System.EventHandler(this.closingBindingSource_PositionChanged);
            // 
            // taxDataSetClosingTable
            // 
            this.taxDataSetClosingTable.DataSetName = "TaxDataSetClosingTable";
            this.taxDataSetClosingTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(12, 12);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(127, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-2, 75);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(804, 23);
            this.progressBar.TabIndex = 2;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(324, 11);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(97, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Upload RIMS";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // closingTableAdapter
            // 
            this.closingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Index:";
            // 
            // txtStartBillId
            // 
            this.txtStartBillId.Location = new System.Drawing.Point(644, 13);
            this.txtStartBillId.Name = "txtStartBillId";
            this.txtStartBillId.Size = new System.Drawing.Size(56, 20);
            this.txtStartBillId.TabIndex = 5;
            this.txtStartBillId.Text = "1";
            // 
            // TaxData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.txtStartBillId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaxData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaxData_FormClosed);
            this.Load += new System.EventHandler(this.TaxData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxDataSetClosingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TaxDataSetClosingTable taxDataSetClosingTable;
        private System.Windows.Forms.BindingSource closingBindingSource;
        private TaxDataSetClosingTableTableAdapters.closingTableAdapter closingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartBillId;
    }
}