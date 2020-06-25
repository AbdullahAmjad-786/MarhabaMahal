namespace MarhabaMahal.Views
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.ledtSideBarPanel = new System.Windows.Forms.Panel();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnItemsReport = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.billitemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marhabaDataSetBillItemT = new MarhabaMahal.MarhabaDataSetBillItemT();
            this.billEditDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billEditDataSet = new MarhabaMahal.BillEditDataSet();
            this.marhabaDataSetDailyClosing = new MarhabaMahal.MarhabaDataSetDailyClosing();
            this.marhabaDataSetDailyClosingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closingTableAdapter = new MarhabaMahal.MarhabaDataSetDailyClosingTableAdapters.closingTableAdapter();
            this.marhabaDataSet1 = new MarhabaMahal.MarhabaDataSet1();
            this.totalForCashClosingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalForCashClosingTableAdapter = new MarhabaMahal.MarhabaDataSet1TableAdapters.TotalForCashClosingTableAdapter();
            this.dateReportDataSet = new MarhabaMahal.DateReportDataSet();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new MarhabaMahal.DateReportDataSetTableAdapters.billTableAdapter();
            this.dateReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_itemTableAdapter = new MarhabaMahal.BillEditDataSetTableAdapters.bill_itemTableAdapter();
            this.bill_itemTableAdapter1 = new MarhabaMahal.MarhabaDataSetBillItemTTableAdapters.bill_itemTableAdapter();
            this.btnSetting = new System.Windows.Forms.Button();
            this.ledtSideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billitemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetBillItemT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billEditDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billEditDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetDailyClosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetDailyClosingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalForCashClosingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billitemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ledtSideBarPanel
            // 
            this.ledtSideBarPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ledtSideBarPanel.Controls.Add(this.btnSetting);
            this.ledtSideBarPanel.Controls.Add(this.btnTax);
            this.ledtSideBarPanel.Controls.Add(this.btnItemsReport);
            this.ledtSideBarPanel.Controls.Add(this.btnDailySales);
            this.ledtSideBarPanel.Controls.Add(this.btnChangePassword);
            this.ledtSideBarPanel.Controls.Add(this.btnLogout);
            this.ledtSideBarPanel.Controls.Add(this.label1);
            this.ledtSideBarPanel.Controls.Add(this.btnDelivery);
            this.ledtSideBarPanel.Controls.Add(this.btnSales);
            this.ledtSideBarPanel.Controls.Add(this.btnAddItems);
            this.ledtSideBarPanel.Controls.Add(this.btnExit);
            this.ledtSideBarPanel.Controls.Add(this.btnUsers);
            this.ledtSideBarPanel.Controls.Add(this.btnReports);
            this.ledtSideBarPanel.Location = new System.Drawing.Point(0, -2);
            this.ledtSideBarPanel.Name = "ledtSideBarPanel";
            this.ledtSideBarPanel.Size = new System.Drawing.Size(250, 774);
            this.ledtSideBarPanel.TabIndex = 2;
            // 
            // btnTax
            // 
            this.btnTax.BackColor = System.Drawing.Color.Black;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTax.Location = new System.Drawing.Point(-6, 240);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(253, 36);
            this.btnTax.TabIndex = 9;
            this.btnTax.Text = "TAX";
            this.btnTax.UseVisualStyleBackColor = false;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            this.btnTax.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnTax.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnItemsReport
            // 
            this.btnItemsReport.BackColor = System.Drawing.Color.Black;
            this.btnItemsReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnItemsReport.Location = new System.Drawing.Point(-3, 207);
            this.btnItemsReport.Name = "btnItemsReport";
            this.btnItemsReport.Size = new System.Drawing.Size(253, 36);
            this.btnItemsReport.TabIndex = 8;
            this.btnItemsReport.Text = "Items Report";
            this.btnItemsReport.UseVisualStyleBackColor = false;
            this.btnItemsReport.Click += new System.EventHandler(this.btnItemsReport_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.Black;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDailySales.Location = new System.Drawing.Point(-3, 176);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(253, 36);
            this.btnDailySales.TabIndex = 6;
            this.btnDailySales.Text = "Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Black;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.Location = new System.Drawing.Point(-2, 669);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(253, 36);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            this.btnChangePassword.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnChangePassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(-1, 702);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(253, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnLogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogout_MouseMove);
            // 
            // label1
            // 
            this.label1.Image = global::MarhabaMahal.Properties.Resources.logo_s;
            this.label1.Location = new System.Drawing.Point(36, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 181);
            this.label1.TabIndex = 0;
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.Black;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelivery.Location = new System.Drawing.Point(-1, 108);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(253, 36);
            this.btnDelivery.TabIndex = 3;
            this.btnDelivery.Text = "Deliveries";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            this.btnDelivery.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnDelivery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Black;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSales.Location = new System.Drawing.Point(-1, 72);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(253, 36);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Orders";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.btnSales.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnSales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Black;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddItems.Location = new System.Drawing.Point(-1, 36);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(253, 36);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            this.btnAddItems.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnAddItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImage = global::MarhabaMahal.Properties.Resources.Close_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(-3, 737);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Black;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsers.Location = new System.Drawing.Point(-2, 144);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(253, 36);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnUsers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Black;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Location = new System.Drawing.Point(-3, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReports.Size = new System.Drawing.Size(253, 36);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnReports.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(247, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 767);
            this.panel1.TabIndex = 3;
            // 
            // billitemBindingSource1
            // 
            this.billitemBindingSource1.DataMember = "bill_item";
            this.billitemBindingSource1.DataSource = this.marhabaDataSetBillItemT;
            // 
            // marhabaDataSetBillItemT
            // 
            this.marhabaDataSetBillItemT.DataSetName = "MarhabaDataSetBillItemT";
            this.marhabaDataSetBillItemT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billEditDataSetBindingSource
            // 
            this.billEditDataSetBindingSource.DataSource = this.billEditDataSet;
            this.billEditDataSetBindingSource.Position = 0;
            // 
            // billEditDataSet
            // 
            this.billEditDataSet.DataSetName = "BillEditDataSet";
            this.billEditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marhabaDataSetDailyClosing
            // 
            this.marhabaDataSetDailyClosing.DataSetName = "MarhabaDataSetDailyClosing";
            this.marhabaDataSetDailyClosing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marhabaDataSetDailyClosingBindingSource
            // 
            this.marhabaDataSetDailyClosingBindingSource.DataSource = this.marhabaDataSetDailyClosing;
            this.marhabaDataSetDailyClosingBindingSource.Position = 0;
            // 
            // closingBindingSource
            // 
            this.closingBindingSource.DataMember = "closing";
            this.closingBindingSource.DataSource = this.marhabaDataSetDailyClosingBindingSource;
            // 
            // closingTableAdapter
            // 
            this.closingTableAdapter.ClearBeforeFill = true;
            // 
            // marhabaDataSet1
            // 
            this.marhabaDataSet1.DataSetName = "MarhabaDataSet1";
            this.marhabaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalForCashClosingBindingSource
            // 
            this.totalForCashClosingBindingSource.DataMember = "TotalForCashClosing";
            this.totalForCashClosingBindingSource.DataSource = this.marhabaDataSet1;
            // 
            // totalForCashClosingTableAdapter
            // 
            this.totalForCashClosingTableAdapter.ClearBeforeFill = true;
            // 
            // dateReportDataSet
            // 
            this.dateReportDataSet.DataSetName = "DateReportDataSet";
            this.dateReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.dateReportDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // dateReportDataSetBindingSource
            // 
            this.dateReportDataSetBindingSource.DataSource = this.dateReportDataSet;
            this.dateReportDataSetBindingSource.Position = 0;
            // 
            // billitemBindingSource
            // 
            this.billitemBindingSource.DataMember = "bill_item";
            this.billitemBindingSource.DataSource = this.billEditDataSetBindingSource;
            // 
            // bill_itemTableAdapter
            // 
            this.bill_itemTableAdapter.ClearBeforeFill = true;
            // 
            // bill_itemTableAdapter1
            // 
            this.bill_itemTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Black;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetting.Location = new System.Drawing.Point(-3, 636);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(253, 36);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ledtSideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ledtSideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billitemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetBillItemT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billEditDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billEditDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetDailyClosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetDailyClosingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalForCashClosingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billitemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ledtSideBarPanel;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private MarhabaDataSetDailyClosing marhabaDataSetDailyClosing;
        private System.Windows.Forms.BindingSource marhabaDataSetDailyClosingBindingSource;
        private System.Windows.Forms.BindingSource closingBindingSource;
        private MarhabaDataSetDailyClosingTableAdapters.closingTableAdapter closingTableAdapter;
        private MarhabaDataSet1 marhabaDataSet1;
        private System.Windows.Forms.BindingSource totalForCashClosingBindingSource;
        private MarhabaDataSet1TableAdapters.TotalForCashClosingTableAdapter totalForCashClosingTableAdapter;
        private System.Windows.Forms.BindingSource billBindingSource;
        private DateReportDataSet dateReportDataSet;
        private DateReportDataSetTableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.BindingSource dateReportDataSetBindingSource;
        private System.Windows.Forms.BindingSource billEditDataSetBindingSource;
        private BillEditDataSet billEditDataSet;
        private System.Windows.Forms.BindingSource billitemBindingSource;
        private BillEditDataSetTableAdapters.bill_itemTableAdapter bill_itemTableAdapter;
        private MarhabaDataSetBillItemT marhabaDataSetBillItemT;
        private System.Windows.Forms.BindingSource billitemBindingSource1;
        private MarhabaDataSetBillItemTTableAdapters.bill_itemTableAdapter bill_itemTableAdapter1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnItemsReport;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnSetting;
    }
}