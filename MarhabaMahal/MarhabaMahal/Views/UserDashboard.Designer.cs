namespace MarhabaMahal.Views
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.ledtSideBarPanel = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.userDailyReportsDataSet = new MarhabaMahal.UserDailyReportsDataSet();
            this.closingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closingTableAdapter = new MarhabaMahal.UserDailyReportsDataSetTableAdapters.closingTableAdapter();
            this.dailyReportSum = new MarhabaMahal.DailyReportSum();
            this.closingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.closingTableAdapter1 = new MarhabaMahal.DailyReportSumTableAdapters.closingTableAdapter();
            this.ledtSideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDailyReportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(248, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 769);
            this.panel1.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(-1, 524);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(253, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnLogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogout_MouseMove);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.Black;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelivery.Location = new System.Drawing.Point(-1, 39);
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
            this.btnSales.Location = new System.Drawing.Point(-1, 3);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(253, 36);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Orders";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.btnSales.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnSales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // ledtSideBarPanel
            // 
            this.ledtSideBarPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ledtSideBarPanel.Controls.Add(this.btnChangePassword);
            this.ledtSideBarPanel.Controls.Add(this.btnDailySales);
            this.ledtSideBarPanel.Controls.Add(this.btnLogout);
            this.ledtSideBarPanel.Controls.Add(this.label1);
            this.ledtSideBarPanel.Controls.Add(this.btnDelivery);
            this.ledtSideBarPanel.Controls.Add(this.btnSales);
            this.ledtSideBarPanel.Controls.Add(this.btnExit);
            this.ledtSideBarPanel.Location = new System.Drawing.Point(1, -1);
            this.ledtSideBarPanel.Name = "ledtSideBarPanel";
            this.ledtSideBarPanel.Size = new System.Drawing.Size(250, 772);
            this.ledtSideBarPanel.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Black;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.Location = new System.Drawing.Point(-1, 491);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(253, 36);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            this.btnChangePassword.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnChangePassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.Black;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDailySales.Location = new System.Drawing.Point(-3, 71);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(253, 36);
            this.btnDailySales.TabIndex = 5;
            this.btnDailySales.Text = "Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            this.btnDailySales.MouseLeave += new System.EventHandler(this.btnAdminPanel_MouseLeave);
            this.btnDailySales.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.Image = global::MarhabaMahal.Properties.Resources.logo_s;
            this.label1.Location = new System.Drawing.Point(40, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 181);
            this.label1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImage = global::MarhabaMahal.Properties.Resources.Close_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(-1, 559);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // userDailyReportsDataSet
            // 
            this.userDailyReportsDataSet.DataSetName = "UserDailyReportsDataSet";
            this.userDailyReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closingBindingSource
            // 
            this.closingBindingSource.DataMember = "closing";
            this.closingBindingSource.DataSource = this.userDailyReportsDataSet;
            // 
            // closingTableAdapter
            // 
            this.closingTableAdapter.ClearBeforeFill = true;
            // 
            // dailyReportSum
            // 
            this.dailyReportSum.DataSetName = "DailyReportSum";
            this.dailyReportSum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closingBindingSource1
            // 
            this.closingBindingSource1.DataMember = "closing";
            this.closingBindingSource1.DataSource = this.dailyReportSum;
            // 
            // closingTableAdapter1
            // 
            this.closingTableAdapter1.ClearBeforeFill = true;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1024, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ledtSideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.ledtSideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDailyReportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel ledtSideBarPanel;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.BindingSource closingBindingSource;
        private UserDailyReportsDataSet userDailyReportsDataSet;
        private UserDailyReportsDataSetTableAdapters.closingTableAdapter closingTableAdapter;
        private DailyReportSum dailyReportSum;
        private System.Windows.Forms.BindingSource closingBindingSource1;
        private DailyReportSumTableAdapters.closingTableAdapter closingTableAdapter1;
    }
}