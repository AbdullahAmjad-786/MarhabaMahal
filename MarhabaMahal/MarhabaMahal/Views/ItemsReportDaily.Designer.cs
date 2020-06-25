namespace MarhabaMahal.Views
{
    partial class ItemsReportDaily
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.marhabaDataSet4 = new MarhabaMahal.MarhabaDataSet4();
            this.itemClosingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemClosingViewTableAdapter = new MarhabaMahal.MarhabaDataSet4TableAdapters.ItemClosingViewTableAdapter();
            this.marhabaDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemClosingViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemClosingViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemClosingViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.itemClosingViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MarhabaMahal.Reports.ItemClosingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(777, 715);
            this.reportViewer1.TabIndex = 2;
            // 
            // marhabaDataSet4
            // 
            this.marhabaDataSet4.DataSetName = "MarhabaDataSet4";
            this.marhabaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemClosingViewBindingSource
            // 
            this.itemClosingViewBindingSource.DataMember = "ItemClosingView";
            this.itemClosingViewBindingSource.DataSource = this.marhabaDataSet4;
            // 
            // itemClosingViewTableAdapter
            // 
            this.itemClosingViewTableAdapter.ClearBeforeFill = true;
            // 
            // marhabaDataSet4BindingSource
            // 
            this.marhabaDataSet4BindingSource.DataSource = this.marhabaDataSet4;
            this.marhabaDataSet4BindingSource.Position = 0;
            // 
            // itemClosingViewBindingSource1
            // 
            this.itemClosingViewBindingSource1.DataMember = "ItemClosingView";
            this.itemClosingViewBindingSource1.DataSource = this.marhabaDataSet4BindingSource;
            // 
            // ItemsReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ItemsReportDaily";
            this.Size = new System.Drawing.Size(777, 767);
            this.Load += new System.EventHandler(this.ItemsReportDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemClosingViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marhabaDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemClosingViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource itemClosingViewBindingSource;
        private MarhabaDataSet4 marhabaDataSet4;
        private MarhabaDataSet4TableAdapters.ItemClosingViewTableAdapter itemClosingViewTableAdapter;
        private System.Windows.Forms.BindingSource marhabaDataSet4BindingSource;
        private System.Windows.Forms.BindingSource itemClosingViewBindingSource1;
    }
}
