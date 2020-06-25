namespace MarhabaMahal.Views
{
    partial class ReportsPanel
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.closingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marhabaDataSetDailyClosing = new MarhabaMahal.MarhabaDataSetDailyClosing();
            this.totalForCashClosingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marhabaDataSet1 = new MarhabaMahal.MarhabaDataSet1();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateReportDataSet = new MarhabaMahal.DateReportDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportClosing = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClosing = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptSales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.closingTableAdapter = new MarhabaMahal.MarhabaDataSetDailyClosingTableAdapters.closingTableAdapter();
            this.totalForCashClosingTableAdapter = new MarhabaMahal.MarhabaDataSet1TableAdapters.TotalForCashClosingTableAdapter();
            this.marhabaDataSet = new MarhabaMahal.MarhabaDataSet();
            this.marhabaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new MarhabaMahal.DateReportDataSetTableAdapters.billTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetDailyClosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalForCashClosingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReportDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closingBindingSource
            // 
            this.closingBindingSource.DataMember = "closing";
            this.closingBindingSource.DataSource = this.marhabaDataSetDailyClosing;
            // 
            // marhabaDataSetDailyClosing
            // 
            this.marhabaDataSetDailyClosing.DataSetName = "MarhabaDataSetDailyClosing";
            this.marhabaDataSetDailyClosing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalForCashClosingBindingSource
            // 
            this.totalForCashClosingBindingSource.DataMember = "TotalForCashClosing";
            this.totalForCashClosingBindingSource.DataSource = this.marhabaDataSet1;
            // 
            // marhabaDataSet1
            // 
            this.marhabaDataSet1.DataSetName = "MarhabaDataSet1";
            this.marhabaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.dateReportDataSet;
            // 
            // dateReportDataSet
            // 
            this.dateReportDataSet.DataSetName = "DateReportDataSet";
            this.dateReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 767);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.reportClosing);
            this.tabPage1.Controls.Add(this.btnClosing);
            this.tabPage1.Controls.Add(this.btnGetReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Closing Report";
            // 
            // reportClosing
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.closingBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.totalForCashClosingBindingSource;
            this.reportClosing.LocalReport.DataSources.Add(reportDataSource4);
            this.reportClosing.LocalReport.DataSources.Add(reportDataSource5);
            this.reportClosing.LocalReport.ReportEmbeddedResource = "MarhabaMahal.Reports.DailyClosing.rdlc";
            this.reportClosing.Location = new System.Drawing.Point(6, 46);
            this.reportClosing.Name = "reportClosing";
            this.reportClosing.Size = new System.Drawing.Size(757, 689);
            this.reportClosing.TabIndex = 2;
            // 
            // btnClosing
            // 
            this.btnClosing.Location = new System.Drawing.Point(6, 6);
            this.btnClosing.Name = "btnClosing";
            this.btnClosing.Size = new System.Drawing.Size(115, 23);
            this.btnClosing.TabIndex = 1;
            this.btnClosing.Text = "Close Daily Account";
            this.btnClosing.UseVisualStyleBackColor = true;
            this.btnClosing.Click += new System.EventHandler(this.btnClosing_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(563, 6);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 0;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnReport);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtTimeTo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtTimeFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom Reports";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rptSales);
            this.panel1.Location = new System.Drawing.Point(-1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 658);
            this.panel1.TabIndex = 41;
            // 
            // rptSales
            // 
            this.rptSales.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.billBindingSource;
            this.rptSales.LocalReport.DataSources.Add(reportDataSource6);
            this.rptSales.LocalReport.ReportEmbeddedResource = "MarhabaMahal.Reports.SalesReport.rdlc";
            this.rptSales.Location = new System.Drawing.Point(0, 0);
            this.rptSales.Name = "rptSales";
            this.rptSales.Size = new System.Drawing.Size(771, 658);
            this.rptSales.TabIndex = 0;
            this.rptSales.Load += new System.EventHandler(this.rptSales_Load);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(574, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 38);
            this.btnReport.TabIndex = 40;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "To";
            // 
            // dtTimeTo
            // 
            this.dtTimeTo.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.dtTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeTo.Location = new System.Drawing.Point(272, 26);
            this.dtTimeTo.Name = "dtTimeTo";
            this.dtTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dtTimeTo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "From";
            // 
            // dtTimeFrom
            // 
            this.dtTimeFrom.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.dtTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeFrom.Location = new System.Drawing.Point(46, 28);
            this.dtTimeFrom.Name = "dtTimeFrom";
            this.dtTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dtTimeFrom.TabIndex = 0;
            // 
            // closingTableAdapter
            // 
            this.closingTableAdapter.ClearBeforeFill = true;
            // 
            // totalForCashClosingTableAdapter
            // 
            this.totalForCashClosingTableAdapter.ClearBeforeFill = true;
            // 
            // marhabaDataSet
            // 
            this.marhabaDataSet.DataSetName = "MarhabaDataSet";
            this.marhabaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marhabaDataSetBindingSource
            // 
            this.marhabaDataSetBindingSource.DataSource = this.marhabaDataSet;
            this.marhabaDataSetBindingSource.Position = 0;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportsPanel";
            this.Size = new System.Drawing.Size(777, 767);
            this.Load += new System.EventHandler(this.ReportsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetDailyClosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalForCashClosingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReportDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClosing;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.BindingSource closingBindingSource;
        private MarhabaDataSetDailyClosing marhabaDataSetDailyClosing;
        private System.Windows.Forms.BindingSource totalForCashClosingBindingSource;
        private MarhabaDataSet1 marhabaDataSet1;
        private MarhabaDataSetDailyClosingTableAdapters.closingTableAdapter closingTableAdapter;
        private MarhabaDataSet1TableAdapters.TotalForCashClosingTableAdapter totalForCashClosingTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportClosing;
        private System.Windows.Forms.DateTimePicker dtTimeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTimeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptSales;
        private System.Windows.Forms.BindingSource billBindingSource;
        private DateReportDataSet dateReportDataSet;
        private MarhabaDataSet marhabaDataSet;
        private System.Windows.Forms.BindingSource marhabaDataSetBindingSource;
        private DateReportDataSetTableAdapters.billTableAdapter billTableAdapter;
    }
}
