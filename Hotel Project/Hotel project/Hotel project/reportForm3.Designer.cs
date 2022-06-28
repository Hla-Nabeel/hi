namespace Hotel_project
{
    partial class reportForm3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dspayment = new Hotel_project.Dspayment();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentTableAdapter = new Hotel_project.DspaymentTableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dspayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotel_project.payreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(661, 307);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dspayment
            // 
            this.Dspayment.DataSetName = "Dspayment";
            this.Dspayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentBindingSource
            // 
            this.PaymentBindingSource.DataMember = "Payment";
            this.PaymentBindingSource.DataSource = this.Dspayment;
            // 
            // PaymentTableAdapter
            // 
            this.PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // reportForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 307);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportForm3";
            this.Text = "reportForm3";
            this.Load += new System.EventHandler(this.reportForm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dspayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PaymentBindingSource;
        private Dspayment Dspayment;
        private DspaymentTableAdapters.PaymentTableAdapter PaymentTableAdapter;
    }
}