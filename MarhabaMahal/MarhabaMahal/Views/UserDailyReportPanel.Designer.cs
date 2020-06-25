namespace MarhabaMahal.Views
{
    partial class UserDailyReportPanel
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.closingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDailyReportsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDailyReportsDataSet = new MarhabaMahal.UserDailyReportsDataSet();
            this.closingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dailyReportSumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyReportSum = new MarhabaMahal.DailyReportSum();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.closingTableAdapter = new MarhabaMahal.UserDailyReportsDataSetTableAdapters.closingTableAdapter();
            this.closingTableAdapter1 = new MarhabaMahal.DailyReportSumTableAdapters.closingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDailyReportsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDailyReportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportSumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportSum)).BeginInit();
            this.SuspendLayout();
            // 
            // closingBindingSource
            // 
            this.closingBindingSource.DataMember = "closing";
            this.closingBindingSource.DataSource = this.userDailyReportsDataSetBindingSource;
            // 
            // userDailyReportsDataSetBindingSource
            // 
            this.userDailyReportsDataSetBindingSource.DataSource = this.userDailyReportsDataSet;
            this.userDailyReportsDataSetBindingSource.Position = 0;
            // 
            // userDailyReportsDataSet
            // 
            this.userDailyReportsDataSet.DataSetName = "UserDailyReportsDataSet";
            this.userDailyReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closingBindingSource1
            // 
            this.closingBindingSource1.DataMember = "closing";
            this.closingBindingSource1.DataSource = this.dailyReportSumBindingSource;
            // 
            // dailyReportSumBindingSource
            // 
            this.dailyReportSumBindingSource.DataSource = this.dailyReportSum;
            this.dailyReportSumBindingSource.Position = 0;
            // 
            // dailyReportSum
            // 
            this.dailyReportSum.DataSetName = "DailyReportSum";
            this.dailyReportSum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.closingBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.closingBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MarhabaMahal.Reports.UserDailyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 715);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closingTableAdapter
            // 
            this.closingTableAdapter.ClearBeforeFill = true;
            // 
            // closingTableAdapter1
            // 
            this.closingTableAdapter1.ClearBeforeFill = true;
            // 
            // UserDailyReportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UserDailyReportPanel";
            this.Size = new System.Drawing.Size(777, 767);
            this.Load += new System.EventHandler(this.UserDailyReportPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDailyReportsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDailyReportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportSumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private UserDailyReportsDataSet userDailyReportsDataSet;
        private System.Windows.Forms.BindingSource userDailyReportsDataSetBindingSource;
        private DailyReportSum dailyReportSum;
        private System.Windows.Forms.BindingSource dailyReportSumBindingSource;
        private System.Windows.Forms.BindingSource closingBindingSource;
        private UserDailyReportsDataSetTableAdapters.closingTableAdapter closingTableAdapter;
        private System.Windows.Forms.BindingSource closingBindingSource1;
        private DailyReportSumTableAdapters.closingTableAdapter closingTableAdapter1;
    }
}
